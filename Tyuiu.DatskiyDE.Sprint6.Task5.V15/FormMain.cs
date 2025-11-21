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
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files|*.txt";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
                TextBoxPath_DDE.Text = filePath;
            }
        }

        private void ButtonRun_DDE_Click(object sender, EventArgs e)
        {
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Файл не найден!");
                return;
            }

            // Чтение всего файла
            var allData = ds.LoadFromFile_DDE(filePath);

            // Вывод в DataGridView
            DataGridViewData_DDE.Rows.Clear();
            for (int i = 0; i < allData.Length; i++)
                DataGridViewData_DDE.Rows.Add(i, allData[i]);

            // Получение значений 2..7
            var part = ds.GetRange_DDE(allData);

            // Построение графика
            Chart_DDE.Series.Clear();

            ChartValues<double> values = new ChartValues<double>(part);

            ColumnSeries series = new ColumnSeries
            {
                Title = "Values",
                Values = values
            };

            Chart_DDE.Series.Add(series);
            Chart_DDE.AxisX.Clear();
            Chart_DDE.AxisX.Add(new Axis
            {
                Labels = Enumerable.Range(2, part.Length).Select(i => i.ToString()).ToArray()
            });
        }

        private void ButtonHelp_DDE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вариант 15. Чтение данных из файла, вывод в таблицу и построение диаграммы.");
        }
    }
}
