using Tyuiu.DatskiyDE.Sprint6.Task3.V27.Lib;
namespace Tyuiu.DatskiyDE.Sprint6.Task3.V27
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
       
            int[,] matrix = {
                {9, 13, -14, 23, 1},
                {15, -17, 21, 25, 23},
                {-4, 29, -20, -10, 14},
                {27, 33, 12, 33, -12},
                {18, -9, -5, 6, 3}
            };

            int[,] sortedMatrix = ds.Calculate(matrix);

            dataGridViewResult_DDE.Rows.Clear();
            dataGridViewResult_DDE.Columns.Clear();

       
            for (int j = 0; j < 5; j++)
            {
                dataGridViewResult_DDE.Columns.Add($"Col{j}", $"Колонка {j + 1}");
            }

        
            for (int i = 0; i < 5; i++)
            {
                int[] row = new int[5];
                for (int j = 0; j < 5; j++)
                {
                    row[j] = sortedMatrix[i, j];
                }
                dataGridViewResult_DDE.Rows.Add(row);
            }
        }

        private void buttonHelp_DDE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Отсортировать матрицу 5x5 по возрастанию в 4-м столбце.");
        }
    }
}