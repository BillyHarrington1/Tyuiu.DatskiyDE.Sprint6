namespace Tyuiu.DatskiyDE.Sprint6.Task6.V23
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void buttonOK_DDE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOK_DDE_MouseEnter(object sender, EventArgs e)
        {
            buttonOK_DDE.BackColor = Color.LightGreen;
        }

        private void buttonOK_DDE_MouseLeave(object sender, EventArgs e)
        {
            buttonOK_DDE.BackColor = SystemColors.Control;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}