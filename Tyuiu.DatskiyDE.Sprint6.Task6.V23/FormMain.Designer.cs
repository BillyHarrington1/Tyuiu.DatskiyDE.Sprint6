namespace Tyuiu.DatskiyDE.Sprint6.Task6.V23
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxCondition_DDE = new GroupBox();
            textBoxTask_DDE = new TextBox();
            groupBoxInput_DDE = new GroupBox();
            labelOutput_DDE = new Label();
            labelInput_DDE = new Label();
            textBoxIn_DDE = new TextBox();
            textBoxOut_DDE = new TextBox();
            buttonHelp_DDE = new Button();
            buttonExecute_DDE = new Button();
            buttonOpenFile_DDE = new Button();
            openFileDialogTask_DDE = new OpenFileDialog();
            groupBoxCondition_DDE.SuspendLayout();
            groupBoxInput_DDE.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCondition_DDE
            // 
            groupBoxCondition_DDE.BackColor = Color.Teal;
            groupBoxCondition_DDE.Controls.Add(textBoxTask_DDE);
            groupBoxCondition_DDE.Location = new Point(12, 12);
            groupBoxCondition_DDE.Name = "groupBoxCondition_DDE";
            groupBoxCondition_DDE.Size = new Size(760, 80);
            groupBoxCondition_DDE.TabIndex = 0;
            groupBoxCondition_DDE.TabStop = false;
            groupBoxCondition_DDE.Text = "Условие";
            // 
            // textBoxTask_DDE
            // 
            textBoxTask_DDE.BackColor = Color.Teal;
            textBoxTask_DDE.BorderStyle = BorderStyle.None;
            textBoxTask_DDE.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxTask_DDE.ForeColor = Color.FromArgb(255, 128, 0);
            textBoxTask_DDE.Location = new Point(6, 22);
            textBoxTask_DDE.Multiline = true;
            textBoxTask_DDE.Name = "textBoxTask_DDE";
            textBoxTask_DDE.ReadOnly = true;
            textBoxTask_DDE.Size = new Size(748, 52);
            textBoxTask_DDE.TabIndex = 0;
            textBoxTask_DDE.Text = resources.GetString("textBoxTask_DDE.Text");
            // 
            // groupBoxInput_DDE
            // 
            groupBoxInput_DDE.BackColor = Color.Teal;
            groupBoxInput_DDE.Controls.Add(labelOutput_DDE);
            groupBoxInput_DDE.Controls.Add(labelInput_DDE);
            groupBoxInput_DDE.Controls.Add(textBoxIn_DDE);
            groupBoxInput_DDE.Controls.Add(textBoxOut_DDE);
            groupBoxInput_DDE.Controls.Add(buttonHelp_DDE);
            groupBoxInput_DDE.Controls.Add(buttonExecute_DDE);
            groupBoxInput_DDE.Controls.Add(buttonOpenFile_DDE);
            groupBoxInput_DDE.Location = new Point(12, 98);
            groupBoxInput_DDE.Name = "groupBoxInput_DDE";
            groupBoxInput_DDE.Size = new Size(760, 308);
            groupBoxInput_DDE.TabIndex = 1;
            groupBoxInput_DDE.TabStop = false;
            groupBoxInput_DDE.Text = "Данные";
            // 
            // labelOutput_DDE
            // 
            labelOutput_DDE.AutoSize = true;
            labelOutput_DDE.Location = new Point(6, 163);
            labelOutput_DDE.Name = "labelOutput_DDE";
            labelOutput_DDE.Size = new Size(45, 15);
            labelOutput_DDE.TabIndex = 6;
            labelOutput_DDE.Text = "Вывод:";
            // 
            // labelInput_DDE
            // 
            labelInput_DDE.AutoSize = true;
            labelInput_DDE.Location = new Point(6, 23);
            labelInput_DDE.Name = "labelInput_DDE";
            labelInput_DDE.Size = new Size(36, 15);
            labelInput_DDE.TabIndex = 5;
            labelInput_DDE.Text = "Ввод:";
            // 
            // textBoxIn_DDE
            // 
            textBoxIn_DDE.BackColor = SystemColors.ActiveBorder;
            textBoxIn_DDE.Location = new Point(70, 20);
            textBoxIn_DDE.Multiline = true;
            textBoxIn_DDE.Name = "textBoxIn_DDE";
            textBoxIn_DDE.ReadOnly = true;
            textBoxIn_DDE.ScrollBars = ScrollBars.Vertical;
            textBoxIn_DDE.Size = new Size(578, 134);
            textBoxIn_DDE.TabIndex = 4;
            // 
            // textBoxOut_DDE
            // 
            textBoxOut_DDE.BackColor = SystemColors.ActiveBorder;
            textBoxOut_DDE.Location = new Point(70, 160);
            textBoxOut_DDE.Multiline = true;
            textBoxOut_DDE.Name = "textBoxOut_DDE";
            textBoxOut_DDE.ReadOnly = true;
            textBoxOut_DDE.ScrollBars = ScrollBars.Vertical;
            textBoxOut_DDE.Size = new Size(578, 134);
            textBoxOut_DDE.TabIndex = 3;
            // 
            // buttonHelp_DDE
            // 
            buttonHelp_DDE.Location = new Point(654, 22);
            buttonHelp_DDE.Name = "buttonHelp_DDE";
            buttonHelp_DDE.Size = new Size(100, 93);
            buttonHelp_DDE.TabIndex = 2;
            buttonHelp_DDE.Text = "?";
            buttonHelp_DDE.UseVisualStyleBackColor = true;
            buttonHelp_DDE.Click += buttonHelp_DDE_Click;
            buttonHelp_DDE.MouseEnter += buttonHelp_DDE_MouseEnter;
            buttonHelp_DDE.MouseLeave += buttonHelp_DDE_MouseLeave;
            // 
            // buttonExecute_DDE
            // 
            buttonExecute_DDE.Enabled = false;
            buttonExecute_DDE.Location = new Point(654, 121);
            buttonExecute_DDE.Name = "buttonExecute_DDE";
            buttonExecute_DDE.Size = new Size(100, 81);
            buttonExecute_DDE.TabIndex = 1;
            buttonExecute_DDE.Text = "Выполнить";
            buttonExecute_DDE.UseVisualStyleBackColor = true;
            buttonExecute_DDE.Click += buttonExecute_DDE_Click;
            buttonExecute_DDE.MouseEnter += buttonExecute_DDE_MouseEnter;
            buttonExecute_DDE.MouseLeave += buttonExecute_DDE_MouseLeave;
            // 
            // buttonOpenFile_DDE
            // 
            buttonOpenFile_DDE.Location = new Point(654, 208);
            buttonOpenFile_DDE.Name = "buttonOpenFile_DDE";
            buttonOpenFile_DDE.Size = new Size(100, 86);
            buttonOpenFile_DDE.TabIndex = 0;
            buttonOpenFile_DDE.Text = "Открыть файл";
            buttonOpenFile_DDE.UseVisualStyleBackColor = true;
            buttonOpenFile_DDE.Click += buttonOpenFile_DDE_Click;
            buttonOpenFile_DDE.MouseEnter += buttonOpenFile_DDE_MouseEnter;
            buttonOpenFile_DDE.MouseLeave += buttonOpenFile_DDE_MouseLeave;
            // 
            // openFileDialogTask_DDE
            // 
            openFileDialogTask_DDE.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            AutoSize = true;
            BackColor = Color.Teal;
            ClientSize = new Size(784, 416);
            Controls.Add(groupBoxInput_DDE);
            Controls.Add(groupBoxCondition_DDE);
            ForeColor = SystemColors.Desktop;
            MaximizeBox = false;
            MaximumSize = new Size(1000, 1000);
            MinimumSize = new Size(800, 100);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 6 | Вариант 23 | Дацкий Д. Е.";
            WindowState = FormWindowState.Minimized;
            Load += FormMain_Load;
            groupBoxCondition_DDE.ResumeLayout(false);
            groupBoxCondition_DDE.PerformLayout();
            groupBoxInput_DDE.ResumeLayout(false);
            groupBoxInput_DDE.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_DDE;
        private System.Windows.Forms.TextBox textBoxTask_DDE;
        private System.Windows.Forms.GroupBox groupBoxInput_DDE;
        private System.Windows.Forms.Button buttonHelp_DDE;
        private System.Windows.Forms.Button buttonExecute_DDE;
        private System.Windows.Forms.Button buttonOpenFile_DDE;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_DDE;
        private System.Windows.Forms.TextBox textBoxOut_DDE;
        private System.Windows.Forms.TextBox textBoxIn_DDE;
        private System.Windows.Forms.Label labelOutput_DDE;
        private System.Windows.Forms.Label labelInput_DDE;
    }
}