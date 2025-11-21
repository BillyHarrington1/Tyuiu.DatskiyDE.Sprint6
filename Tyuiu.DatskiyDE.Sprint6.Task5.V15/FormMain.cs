using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Tyuiu.DatskiyDE.Sprint6.Task5.V15.Lib;

namespace Tyuiu.DatskiyDE.Sprint6.Task5.V15
{
    public partial class FormMain_DDE : Form
    {
        DataService ds = new DataService();
        string filePath = "";

        public FormMain_DDE()
        {
            InitializeComponent();
        }

        private void ButtonOpenFile_DDE_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Text files|*.txt";
                ofd.InitialDirectory = @"C:\DataSprint5\";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    filePath = ofd.FileName;
                    TextBoxPath_DDE.Text = filePath;
                    ButtonRun_DDE.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при открытии файла: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonRun_DDE_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    MessageBox.Show("Файл не найден!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Чтение всего файла
                double[] allData = ds.LoadFromDataFile(filePath);

                // Вывод в DataGridView (все данные)
                DataGridViewData_DDE.Rows.Clear();
                for (int i = 0; i < allData.Length; i++)
                {
                    DataGridViewData_DDE.Rows.Add(i + 1, Math.Round(allData[i], 3));
                }

                // Получение значений от 2 до 7 (индексы 1-6, так как массив с 0)
                double[] part = new double[6];
                for (int i = 1; i <= 6; i++) // индексы 1-6 соответствуют значениям 2-7
                {
                    if (i < allData.Length)
                    {
                        part[i - 1] = Math.Round(allData[i], 3);
                    }
                }

                // Построение графика
                Chart_DDE.Series.Clear();

                SeriesCollection series = new SeriesCollection();
                ChartValues<double> values = new ChartValues<double>(part);

                ColumnSeries columnSeries = new ColumnSeries
                {
                    Title = "Значения",
                    Values = values,
                    Fill = System.Windows.Media.Brushes.LightBlue
                };

                series.Add(columnSeries);
                Chart_DDE.Series = series;

                // Настройка осей
                Chart_DDE.AxisX.Clear();
                Chart_DDE.AxisX.Add(new Axis
                {
                    Title = "X",
                    Labels = new[] { "2", "3", "4", "5", "6", "7" }
                });

                Chart_DDE.AxisY.Clear();
                Chart_DDE.AxisY.Add(new Axis
                {
                    Title = "Y",
                    LabelFormatter = value => value.ToString("F2")
                });

                Chart_DDE.LegendLocation = LegendLocation.Top;

                // Обновление информации
                TextBoxPath_DDE.Text = $"Файл загружен. Значений: {allData.Length}. Диаграмма построена для x=2..7";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при выполнении: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonHelp_DDE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ИСПб-25-1 Дацкий Д.Е.");
        }

        // Добавляем обработчики для эффектов наведения
        private void ButtonOpenFile_DDE_MouseEnter(object sender, EventArgs e)
        {
            ButtonOpenFile_DDE.BackColor = Color.SteelBlue;
            ButtonOpenFile_DDE.ForeColor = Color.White;
        }

        private void ButtonOpenFile_DDE_MouseLeave(object sender, EventArgs e)
        {
            ButtonOpenFile_DDE.BackColor = Color.LightSteelBlue;
            ButtonOpenFile_DDE.ForeColor = Color.Black;
        }

        private void ButtonRun_DDE_MouseEnter(object sender, EventArgs e)
        {
            ButtonRun_DDE.BackColor = Color.LimeGreen;
            ButtonRun_DDE.ForeColor = Color.White;
        }

        private void ButtonRun_DDE_MouseLeave(object sender, EventArgs e)
        {
            ButtonRun_DDE.BackColor = Color.PaleGreen;
            ButtonRun_DDE.ForeColor = Color.Black;
        }

        private void ButtonHelp_DDE_MouseEnter(object sender, EventArgs e)
        {
            ButtonHelp_DDE.BackColor = Color.RoyalBlue;
            ButtonHelp_DDE.ForeColor = Color.White;
        }

        private void ButtonHelp_DDE_MouseLeave(object sender, EventArgs e)
        {
            ButtonHelp_DDE.BackColor = Color.LightBlue;
            ButtonHelp_DDE.ForeColor = Color.Black;
        }

        // Обработчик для Chart (может понадобиться)
        private void Chart_DDE_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {
            // Пустой обработчик, может быть полезен для дополнительной настройки
        }
    }
}