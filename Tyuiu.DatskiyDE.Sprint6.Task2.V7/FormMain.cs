using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.DatskiyDE.Sprint6.Task2.V7.Lib;

namespace Tyuiu.DatskiyDE.Sprint6.Task2.V7
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
                int startValue = int.Parse(textBoxStart_DDE.Text);
                int stopValue = int.Parse(textBoxStop_DDE.Text);

                double[] values = ds.GetMassFunction(startValue, stopValue);

                dataGridViewResult_DDE.Rows.Clear();

                for (int i = 0; i < values.Length; i++)
                {
                    int x = startValue + i;
                    dataGridViewResult_DDE.Rows.Add(x, values[i]);
                }

                // Построение графика
                chartResult_DDE.Series[0].Points.Clear();
                for (int i = 0; i < values.Length; i++)
                {
                    int x = startValue + i;
                    chartResult_DDE.Series[0].Points.AddXY(x, values[i]);
                }

                // Настройка осей
                chartResult_DDE.ChartAreas[0].AxisX.Minimum = startValue - 1;
                chartResult_DDE.ChartAreas[0].AxisX.Maximum = stopValue + 1;
                chartResult_DDE.ChartAreas[0].AxisY.Minimum = -10;
                chartResult_DDE.ChartAreas[0].AxisY.Maximum = 20;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка ввода данных!");
            }
        }

        private void buttonHelp_DDE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Табулировать функцию F(x) = 3x + 2 - (2x - x)/(cos(x) + 1) на диапазоне [-5, 5] с шагом 1.");
        }
    }
}