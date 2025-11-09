using System;
using System.Windows.Forms;
using Tyuiu.DatskiyDE.Sprint6.Task0.V22.Lib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tyuiu.DatskiyDE.Sprint6.Task0.V22
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();

            try
            {
                int x = int.Parse(textBoxX.Text); 
                double result = ds.Calculate(x);
                textBoxResult.Text = result.ToString("F3");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка ввода данных!");
            }
        }

        private void labelFormula_Click(object sender, EventArgs e)
        {

        }
    }
}