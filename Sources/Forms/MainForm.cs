using FurnitureCalc.Sources.Models;
using FurnitureCalc.Sources.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace FurnitureCalc
{
    public partial class MainForm : Form
    {
        private const string FILE_PATH_HISTORY = "history.json";

        private CalcData _currentData;
        private List<CalcData> _historyContainer;
        public MainForm()
        {
            InitializeComponent();
            LoadHistory();
        }

        private async void LoadHistory()
        {
            _historyContainer = new List<CalcData>();
            string path = StorageService.GetFilePath(FILE_PATH_HISTORY);
            string json = await StorageService.ReadFileAsync(path);
            if (!string.IsNullOrEmpty(json))
            {
                _historyContainer = JsonConvert.DeserializeObject<List<CalcData>>(json);

                for (int i = 0; i < _historyContainer.Count; i++)
                {
                    var data = _historyContainer[i];
                    AddDataToDataGridView(data);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            Calculate();

        }

        private void Calculate()
        {
            string name = nameInput.Text;
            double width, height, length, fasteners, thickness;
            


            // Валидация ввода
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Пожалуйста, введите имя мебели.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Прерываем выполнение, если имя не введено
            }

            if (!double.TryParse(widthInput.Value.ToString(), out width) || width <= 0)
            {
                MessageBox.Show("Пожалуйста, введите корректное значение ширины (больше 0).", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(heightInput.Value.ToString(), out height) || height <= 0)
            {
                MessageBox.Show("Пожалуйста, введите корректное значение высоты (больше 0).", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(lengthInput.Value.ToString(), out length) || length <= 0)
            {
                MessageBox.Show("Пожалуйста, введите корректное значение длины (больше 0).", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(inputFasteners.Value.ToString(), out fasteners) || fasteners < 0)
            {
                MessageBox.Show("Пожалуйста, введите корректное значение количества крепежей (больше или равно 0).", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(thicknessInput.Value.ToString(), out thickness) || thickness <= 0)
            {
                MessageBox.Show("Пожалуйста, введите корректное значение толщины (больше 0).", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dropdownTypes.SelectedIndex == -1)
            {
                MessageBox.Show("Пожалуйста, выберите тип мебели.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int index = dropdownTypes.SelectedIndex;
            _currentData = CalculatorService.Calculate(index, name, length, width, height, thickness, fasteners);
            widthFurnuteLabel.Text = $"Ширина (см): {_currentData.Width}";
            heightFurnuteLabel.Text = $"Высота (см): {_currentData.Height}";
            thicknessFurnuteLabel.Text = $"Толщина {_currentData.NameTargetOfThickness}: {_currentData.Thickness} см";
            typeFurnuteLabel.Text = $"Тип: {dropdownTypes.Items[index].ToString()}";
            fastenersFurnuteLabel.Text = $"Шурупы (в единицах): {_currentData.Fasteners}";
            lengthFurnuteLabel.Text = $"Длина (см): {_currentData.Length} см";
            nameFurnuteLabel.Text = $"Название: {_currentData.NameFurniture}";
            paintFurnuteLabel.Text = $"Количество краски: {_currentData.PaintCount} л";
            woodCountFurnuteLabel.Text = $"Объем древесины: {_currentData.WoodCount} см³";
            if (_historyContainer.Any(x => x.NameFurniture == _currentData.NameFurniture))
            {
                MessageBox.Show($"Мебель с именем {_currentData.NameFurniture} уже есть в журнале, поэтому не будет записана в журнал истории.", "Найдено совпадение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            AddDataToDataGridView(_currentData);
            _historyContainer.Add(_currentData);

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_currentData is null)
            {
                MessageBox.Show("Нужно сначала провести расчет во Вкладке Расчет.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                await ExcelConvertService.ToExcelAsync(_currentData, $"{_currentData.NameFurniture}.xlsx");
            }
        }

        private void LoadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xlsx;*.xlsm;*.xltx;*.xltm";
            openFileDialog.Title = "Выберите файл Excel";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                try
                {
                    _currentData = ExcelConvertService.FromExcelAsync<CalcData>(filePath);
                    nameInput.Text = _currentData.NameFurniture;
                    widthInput.Value = (decimal)_currentData.Width;
                    heightInput.Value = (decimal)_currentData.Height;
                    dropdownTypes.SelectedIndex = _currentData.Type;
                    inputFasteners.Value = (decimal)_currentData.Fasteners;
                    lengthInput.Value = (decimal)_currentData.Length;
                    thicknessInput.Value = (decimal)_currentData.Thickness;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при обработке файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AddDataToDataGridView(object data)
        {
            // Проверка на null
            if (data == null) return;

            // Получение объекта DataGridView
            var dataGridView = historyGrid;

            // Добавление новой строки
            dataGridView.Rows.Add();
            int rowIndex = dataGridView.Rows.Count - 1;

            // Заполнение ячеек новыми данными
            data.GetType().GetProperties().ToList().ForEach(property =>
            {
                string propertyName = property.Name;
                object propertyValue = property.GetValue(data);

                if (dataGridView.Columns.Contains(propertyName))
                {
                    dataGridView.Rows[rowIndex].Cells[propertyName].Value = propertyValue;
                }
            });

        }

        private async Task SaveHistoryCalcs ()
        {
            string path = StorageService.GetFilePath(FILE_PATH_HISTORY);
            string json = JsonConvert.SerializeObject(_historyContainer, Formatting.Indented);
            await StorageService.WriteFileAsync(path, json);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Application.ApplicationExit += Application_ApplicationExit;
        }

        private async void Application_ApplicationExit(object sender, EventArgs e)
        {
            await SaveHistoryCalcs();
        }

    }
}
