using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using System;
using System.IO;
using System.Windows.Forms;
using Tyuiu.DatskiyDE.Sprint6.Task4.V5.Lib;

namespace Tyuiu.DatskiyDE.Sprint6.Task4.V5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonCalculate_DDE_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();

            try
            {
                int startValue = -5;
                int stopValue = 5;

                double[] values = ds.GetMassFunction(startValue, stopValue);

                string table = "+-----+--------+\n";
                table += "|  X  |  f(x)  |\n";
                table += "+-----+--------+\n";

                for (int i = 0; i < values.Length; i++)
                {
                    int x = startValue + i;
                    table += $"| {x,3} | {values[i],6:F2} |\n";
                }

                table += "+-----+--------+";

                textBoxResult_DDE.Text = table;

                // Построение графика с LiveCharts
                var series = new LineSeries
                {
                    Values = new ChartValues<double>(),
                    PointGeometrySize = 0,
                    StrokeThickness = 2,             
                };

                for (int i = 0; i < values.Length; i++)
                {
                    int x = startValue + i;
                    series.Values.Add(values[i]);
                }

                cartesianChartResult_DDE.Series.Clear();
                cartesianChartResult_DDE.Series.Add(series);

                // Настройка осей
                cartesianChartResult_DDE.AxisX.Clear();
                cartesianChartResult_DDE.AxisY.Clear();

                cartesianChartResult_DDE.AxisX.Add(new Axis { Title = "X", MinValue = -6, MaxValue = 6 });
                cartesianChartResult_DDE.AxisY.Add(new Axis { Title = "f(x)", MinValue = -100, MaxValue = 100 });

                // Обновляем график
                cartesianChartResult_DDE.Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при вычислении!");
            }
        }

        private void buttonSave_DDE_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double[] values = ds.GetMassFunction(startValue, stopValue);

            // Сохраняем в файл
            string tempPath = Path.GetTempPath();
            string fileName = "OutPutFileTask4V5.txt";
            string filePath = Path.Combine(tempPath, fileName);

            string content = "";

            for (int i = 0; i < values.Length; i++)
            {
                int x = startValue + i;
                content += $"{x};{values[i]:F2}\n";
            }

            File.WriteAllText(filePath, content);

            MessageBox.Show($"Файл сохранён по пути: {filePath}");
        }

        private void buttonHelp_DDE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Табулировать функцию F(x) = (2*sin(x))/(3x+1.2) + cos(x) - 14x\nна диапазоне [-5, 5] с шагом 1.");
        }
    }
}