using System;
using System.Windows.Forms;
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка ввода данных!");
            }
        }

        private void buttonHelp_DDE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ИСПб-25-1 Дацкий Денис Евгеньевич");
        }
    }
}