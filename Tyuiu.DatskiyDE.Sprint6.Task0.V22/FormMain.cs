using System;
using System.Windows.Forms;
using Tyuiu.DatskiyDE.Sprint6.Task0.V22.Lib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tyuiu.DatskiyDE.Sprint6.Task0.V22
{
    public partial class FormMain_DDE : Form
    {
        public FormMain_DDE()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();

            try
            {
                int x = int.Parse(textBoxInput_DDE.Text); 
                double result = ds.Calculate(x);
                textBoxResult_DDE.Text = result.ToString("F3");
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