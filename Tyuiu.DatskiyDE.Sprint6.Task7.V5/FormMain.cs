using Tyuiu.DatskiyDE.Sprint6.Task7.V5.Lib;
namespace Tyuiu.DatskiyDE.Sprint6.Task7.V5
{
    public partial class FormMain : Form
    {
        private int[,]? _inputMatrix;
        private int[,]? _outputMatrix;

        private readonly DataService _dataService = new DataService();

        public FormMain()
        {
            InitializeComponent();
        }

        private void ButtonOpenFile_DDE_Click(object sender, EventArgs e)
        {
            if (openFileDialog_DDE.ShowDialog() != DialogResult.OK)
                return;

            string path = openFileDialog_DDE.FileName;
            TextBoxPath_DDE.Text = path;

            try
            {
                _inputMatrix = _dataService.GetMatrix(path);

                FillDataGrid(DataGridViewInput_DDE, _inputMatrix);
                DataGridViewOutput_DDE.Rows.Clear();
                DataGridViewOutput_DDE.Columns.Clear();
                _outputMatrix = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при чтении файла: " + ex.Message);
            }
        }

        private void ButtonRun_DDE_Click(object sender, EventArgs e)
        {
            if (_inputMatrix == null)
            {
                MessageBox.Show("Сначала откройте файл.");
                return;
            }

            _outputMatrix = _dataService.ProcessMatrix(_inputMatrix);

            FillDataGrid(DataGridViewOutput_DDE, _outputMatrix);
        }

        private void ButtonSave_DDE_Click(object sender, EventArgs e)
        {
            if (_outputMatrix == null)
            {
                MessageBox.Show("Нет данных для сохранения.");
                return;
            }

            if (saveFileDialog_DDE.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                _dataService.SaveToFile(saveFileDialog_DDE.FileName, _outputMatrix);
                MessageBox.Show("Сохранено!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении: " + ex.Message);
            }
        }

        private void ButtonAbout_DDE_Click(object sender, EventArgs e)
        {
            using (MainAbout about = new MainAbout())
            {
                about.ShowDialog();
            }
        }

        private void FillDataGrid(DataGridView dgv, int[,] matrix)
        {
            dgv.Columns.Clear();
            dgv.Rows.Clear();

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int c = 0; c < cols; c++)
            {
                dgv.Columns.Add("col" + c, "C" + c);
                dgv.Columns[c].Width = 40;
            }

            dgv.Rows.Add(rows);

            for (int r = 0; r < rows; r++)
                for (int c = 0; c < cols; c++)
                    dgv[c, r].Value = matrix[r, c];
        }
    }
}
