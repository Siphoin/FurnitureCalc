using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureCalc.Sources.Services
{
    public static class StorageService
    {
        public static async Task<string> ReadFileAsync(string fileName)
        {
            string filePath = GetFilePath(fileName);
            return await ReadFileInternalAsync(filePath);
        }

        public static async Task<bool> WriteFileAsync(string fileName, string content)
        {
            string filePath = GetFilePath(fileName);
            return await WriteFileInternalAsync(filePath, content);
        }

        public static string GetFilePath (string fileName)
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
        }

        private static async Task<string> ReadFileInternalAsync(string filePath)
        {
            try
            {
                using (var streamReader = new StreamReader(filePath))
                {
                    return await streamReader.ReadToEndAsync();
                }
            }
            catch (FileNotFoundException)
            {
                Debug.WriteLine($"Файл не найден: {filePath}");
                return null;
            }
            catch (IOException ex)
            {
                Debug.WriteLine($"Ошибка чтения файла: {ex.Message}");
                return null;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Произошла ошибка: {ex.Message}");
                return null;
            }
        }

        private static async Task<bool> WriteFileInternalAsync(string filePath, string content)
        {
            try
            {
                using (var streamWriter = new StreamWriter(filePath, false))
                {
                    await streamWriter.WriteAsync(content);
                    return true;
                }
            }
            catch (IOException ex)
            {
                Debug.WriteLine($"Ошибка чтения файла: {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Произошла ошибка: {ex.Message}");
                return false;
            }
        }
    }
}
