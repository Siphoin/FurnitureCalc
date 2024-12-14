using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;

namespace FurnitureCalc.Sources.Services
{
    public static class ExcelConvertService
    {
        static ExcelConvertService ()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        }
        public static async Task ToExcelAsync<T>(T obj, string filePath)
        {
            Type type = typeof(T);
           
            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add(type.Name);

                // Заголовки столбцов (свойства)
                int row = 1;
                int col = 1;
                foreach (var property in type.GetProperties())
                {
                    string propertyName = property.Name;
                    worksheet.Cells[row, col].Value = propertyName;

                    double columnWidth = propertyName.Length * 1.5;
                    columnWidth = Math.Max(columnWidth, 10);
                    worksheet.Column(col).Width = columnWidth;

                    col++;
                }

                // Данные
                if (obj != null)
                {
                    row = 2;
                    col = 1;
                    foreach (var property in type.GetProperties())
                    {
                        object value = property.GetValue(obj);
                        worksheet.Cells[row, col].Value = value;
                        double columnWidth = value.ToString().Length * 1.5; // Коэффициент 1.2 можно настроить
                        worksheet.Cells[row, col].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        col++;
                    }
                }

                await package.SaveAsAsync(new FileInfo(filePath));
            }
        }

        public static T FromExcelAsync<T>(string filePath) where T : new()
        {
            T obj = default;
            try
            {
                using (var package = new ExcelPackage(new FileInfo(filePath)))
                {
                    var worksheet = package.Workbook.Worksheets[0];
                    if (worksheet == null || worksheet.Dimension == null) return default; //Обработка пустого файла или листа

                    var headers = new List<string>();
                    for (int i = 1; i <= worksheet.Dimension.End.Column; i++)
                    {
                        headers.Add(worksheet.Cells[1, i].Value?.ToString()?.Trim() ?? "");
                    }

                    //Обработка только первой строки данных
                    if (worksheet.Dimension.End.Row >= 2)
                    {
                        obj = new T();
                        for (int j = 1; j <= headers.Count; j++)
                        {
                            string header = headers[j - 1];
                            var property = typeof(T).GetProperty(header, BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase);
                            if (property != null)
                            {
                                var cellValue = worksheet.Cells[2, j].Value;
                                Console.WriteLine($"Header: {header}, PropertyType: {property.PropertyType}, CellValue: {cellValue}");
                                try
                                {
                                    object value = ConvertToType(cellValue, property.PropertyType);
                                    property.SetValue(obj, value);
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"Ошибка преобразования типа для свойства {header}: {ex.Message}");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"Property '{header}' not found.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при чтении Excel файла: {ex.Message}");
            }
            return obj;
        }


        private static object ConvertToType(object value, Type targetType)
        {
            if (value == null) return null;
            if (targetType == typeof(string)) return value.ToString();
            if (targetType == typeof(DateTime) && value is string dateString)
            {
                if (DateTime.TryParse(dateString, out DateTime date)) return date;
                return null; // Обработка ошибки парсинга даты.
            }
            if (targetType.IsValueType) return Convert.ChangeType(value, targetType);
            return value;
        }
    }

}
