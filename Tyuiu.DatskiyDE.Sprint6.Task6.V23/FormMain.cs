using Tyuiu.DatskiyDE.Sprint6.Task6.V23.Lib;
namespace Tyuiu.DatskiyDE.Sprint6.Task6.V23
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string filePath = "";

        private void buttonOpenFile_DDE_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialogTask_DDE.Filter = "Text files|*.txt";
                openFileDialogTask_DDE.FileName = "InPutFileTask6V23.txt";

                if (openFileDialogTask_DDE.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialogTask_DDE.FileName;
                    textBoxIn_DDE.Text = File.ReadAllText(filePath);
                    buttonExecute_DDE.Enabled = true;
                    textBoxOut_DDE.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при открытии файла: " + ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonExecute_DDE_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(filePath))
                {
                    MessageBox.Show("Сначала откройте файл", "Предупреждение",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string result = ds.CollectTextFromFile(filePath);
                textBoxOut_DDE.Text = result;

                if (string.IsNullOrEmpty(result))
                {
                    textBoxOut_DDE.Text = "Слова с буквой 's' не найдены";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при выполнении: " + ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_DDE_Click(object sender, EventArgs e) //Открытие другого окна 
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog(); //просто Snow позволит открыть окно бесконечное кол-во раз. 
        }

        private void buttonOpenFile_DDE_MouseEnter(object sender, EventArgs e)
        {
            buttonOpenFile_DDE.BackColor = Color.LightBlue;
        }

        private void buttonOpenFile_DDE_MouseLeave(object sender, EventArgs e)
        {
            buttonOpenFile_DDE.BackColor = SystemColors.Control;
        }

        private void buttonExecute_DDE_MouseEnter(object sender, EventArgs e)
        {
            buttonExecute_DDE.BackColor = Color.LightGreen;
        }

        private void buttonExecute_DDE_MouseLeave(object sender, EventArgs e)
        {
            buttonExecute_DDE.BackColor = SystemColors.Control;
        }

        private void buttonHelp_DDE_MouseEnter(object sender, EventArgs e)
        {
            buttonHelp_DDE.BackColor = Color.LightYellow;
        }

        private void buttonHelp_DDE_MouseLeave(object sender, EventArgs e)
        {
            buttonHelp_DDE.BackColor = SystemColors.Control;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}