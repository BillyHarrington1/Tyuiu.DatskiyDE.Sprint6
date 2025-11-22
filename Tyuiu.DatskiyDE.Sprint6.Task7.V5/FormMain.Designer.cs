namespace Tyuiu.DatskiyDE.Sprint6.Task7.V5
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.ToolStrip toolStrip_DDE;
        private System.Windows.Forms.ToolStripButton buttonOpen_ToolStripButton_DDE;
        private System.Windows.Forms.ToolStripButton buttonRun_ToolStripButton_DDE;
        private System.Windows.Forms.ToolStripButton buttonSave_ToolStripButton_DDE;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator_DDE;
        private System.Windows.Forms.ToolStripButton buttonAbout_ToolStripButton_DDE;

        private System.Windows.Forms.SplitContainer splitContainer_DDE;
        private System.Windows.Forms.DataGridView DataGridViewInput_DDE;
        private System.Windows.Forms.DataGridView DataGridViewOutput_DDE;

        private System.Windows.Forms.TextBox TextBoxPath_DDE;
        private System.Windows.Forms.Label labelTask_DDE;

        private System.Windows.Forms.OpenFileDialog openFileDialog_DDE;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_DDE;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            toolStrip_DDE = new System.Windows.Forms.ToolStrip();
            buttonOpen_ToolStripButton_DDE = new System.Windows.Forms.ToolStripButton();
            buttonRun_ToolStripButton_DDE = new System.Windows.Forms.ToolStripButton();
            buttonSave_ToolStripButton_DDE = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator_DDE = new System.Windows.Forms.ToolStripSeparator();
            buttonAbout_ToolStripButton_DDE = new System.Windows.Forms.ToolStripButton();

            splitContainer_DDE = new System.Windows.Forms.SplitContainer();
            DataGridViewInput_DDE = new System.Windows.Forms.DataGridView();
            DataGridViewOutput_DDE = new System.Windows.Forms.DataGridView();

            TextBoxPath_DDE = new System.Windows.Forms.TextBox();
            labelTask_DDE = new System.Windows.Forms.Label();

            openFileDialog_DDE = new System.Windows.Forms.OpenFileDialog();
            saveFileDialog_DDE = new System.Windows.Forms.SaveFileDialog();

            SuspendLayout();

            //
            // toolStrip_DDE
            //
            toolStrip_DDE.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            toolStrip_DDE.Dock = System.Windows.Forms.DockStyle.Top;

            toolStrip_DDE.Items.Add(buttonOpen_ToolStripButton_DDE);
            toolStrip_DDE.Items.Add(buttonRun_ToolStripButton_DDE);
            toolStrip_DDE.Items.Add(buttonSave_ToolStripButton_DDE);
            toolStrip_DDE.Items.Add(new System.Windows.Forms.ToolStripSeparator());

            buttonAbout_ToolStripButton_DDE.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            toolStrip_DDE.Items.Add(buttonAbout_ToolStripButton_DDE);

            //
            // Buttons
            //
            buttonOpen_ToolStripButton_DDE.Text = "Открыть";
            buttonOpen_ToolStripButton_DDE.Click += ButtonOpenFile_DDE_Click;

            buttonRun_ToolStripButton_DDE.Text = "Выполнить";
            buttonRun_ToolStripButton_DDE.Click += ButtonRun_DDE_Click;

            buttonSave_ToolStripButton_DDE.Text = "Сохранить";
            buttonSave_ToolStripButton_DDE.Click += ButtonSave_DDE_Click;

            buttonAbout_ToolStripButton_DDE.Text = "?";
            buttonAbout_ToolStripButton_DDE.Click += ButtonAbout_DDE_Click;

            //
            // labelTask_DDE
            //
            labelTask_DDE.Text =
                "Дан файл InPutFileTask7V5.csv, содержащий матрицу целых чисел. " +
                "Загрузить файл через OpenFileDialog в dataGridViewInput. " +
                "В последнем столбце заменить значения < 2 на 2. " +
                "Результат вывести в dataGridViewOutput и сохранить в CSV.";

            labelTask_DDE.Location = new System.Drawing.Point(10, 40);
            labelTask_DDE.Size = new System.Drawing.Size(950, 40);

            //
            // TextBoxPath_DDE
            //
            TextBoxPath_DDE.Location = new System.Drawing.Point(10, 85);
            TextBoxPath_DDE.Width = 700;
            TextBoxPath_DDE.ReadOnly = true;

            //
            // splitContainer
            //
            splitContainer_DDE.Location = new System.Drawing.Point(10, 120);
            splitContainer_DDE.Size = new System.Drawing.Size(960, 500);

            splitContainer_DDE.Panel1.Controls.Add(DataGridViewInput_DDE);
            splitContainer_DDE.Panel2.Controls.Add(DataGridViewOutput_DDE);

            //
            // DataGridViews
            //
            DataGridViewInput_DDE.Dock = System.Windows.Forms.DockStyle.Fill;
            DataGridViewOutput_DDE.Dock = System.Windows.Forms.DockStyle.Fill;

            //
            // FormMain
            //
            ClientSize = new System.Drawing.Size(980, 640);
            Controls.Add(splitContainer_DDE);
            Controls.Add(TextBoxPath_DDE);
            Controls.Add(labelTask_DDE);
            Controls.Add(toolStrip_DDE);

            Text = "Спринт 6 | Таск 7 | Вариант 5 | Дацкий Д.Е.";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            ResumeLayout(false);
            PerformLayout();
        }
    }
}
