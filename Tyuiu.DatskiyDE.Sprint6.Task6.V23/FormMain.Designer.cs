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
            this.groupBoxCondition_DDE = new System.Windows.Forms.GroupBox();
            this.textBoxTask_DDE = new System.Windows.Forms.TextBox();
            this.groupBoxInput_DDE = new System.Windows.Forms.GroupBox();
            this.buttonHelp_DDE = new System.Windows.Forms.Button();
            this.buttonExecute_DDE = new System.Windows.Forms.Button();
            this.buttonOpenFile_DDE = new System.Windows.Forms.Button();
            this.openFileDialogTask_DDE = new System.Windows.Forms.OpenFileDialog();
            this.groupBoxOutput_DDE = new System.Windows.Forms.GroupBox();
            this.textBoxOut_DDE = new System.Windows.Forms.TextBox();
            this.textBoxIn_DDE = new System.Windows.Forms.TextBox();
            this.labelInput_DDE = new System.Windows.Forms.Label();
            this.labelOutput_DDE = new System.Windows.Forms.Label();
            this.groupBoxCondition_DDE.SuspendLayout();
            this.groupBoxInput_DDE.SuspendLayout();
            this.groupBoxOutput_DDE.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCondition_DDE
            // 
            this.groupBoxCondition_DDE.Controls.Add(this.textBoxTask_DDE);
            this.groupBoxCondition_DDE.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCondition_DDE.Name = "groupBoxCondition_DDE";
            this.groupBoxCondition_DDE.Size = new System.Drawing.Size(760, 80);
            this.groupBoxCondition_DDE.TabIndex = 0;
            this.groupBoxCondition_DDE.TabStop = false;
            this.groupBoxCondition_DDE.Text = "Условие";
            // 
            // textBoxTask_DDE
            // 
            this.textBoxTask_DDE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_DDE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            this.textBoxTask_DDE.Location = new System.Drawing.Point(6, 22);
            this.textBoxTask_DDE.Multiline = true;
            this.textBoxTask_DDE.Name = "textBoxTask_DDE";
            this.textBoxTask_DDE.ReadOnly = true;
            this.textBoxTask_DDE.Size = new System.Drawing.Size(748, 52);
            this.textBoxTask_DDE.TabIndex = 0;
            this.textBoxTask_DDE.Text = "Дан файл InPutFileTask6V23.txt который может находится в любом месте на диске. Загрузить файл в textBoxIn через openFileDialog. Вывести слова в которых встречается s в результирующем строку и вывести ее в textBoxOut.";   
            // 
            // groupBoxInput_DDE
            // 
            this.groupBoxInput_DDE.Controls.Add(this.labelOutput_DDE);
            this.groupBoxInput_DDE.Controls.Add(this.labelInput_DDE);
            this.groupBoxInput_DDE.Controls.Add(this.textBoxIn_DDE);
            this.groupBoxInput_DDE.Controls.Add(this.textBoxOut_DDE);
            this.groupBoxInput_DDE.Controls.Add(this.buttonHelp_DDE);
            this.groupBoxInput_DDE.Controls.Add(this.buttonExecute_DDE);
            this.groupBoxInput_DDE.Controls.Add(this.buttonOpenFile_DDE);
            this.groupBoxInput_DDE.Location = new System.Drawing.Point(12, 98);
            this.groupBoxInput_DDE.Name = "groupBoxInput_DDE";
            this.groupBoxInput_DDE.Size = new System.Drawing.Size(760, 300);
            this.groupBoxInput_DDE.TabIndex = 1;
            this.groupBoxInput_DDE.TabStop = false;
            this.groupBoxInput_DDE.Text = "Ввод данных";
            // 
            // buttonHelp_DDE
            // 
            this.buttonHelp_DDE.Location = new System.Drawing.Point(654, 22);
            this.buttonHelp_DDE.Name = "buttonHelp_DDE";
            this.buttonHelp_DDE.Size = new System.Drawing.Size(100, 40);
            this.buttonHelp_DDE.TabIndex = 2;
            this.buttonHelp_DDE.Text = "?";
            this.buttonHelp_DDE.UseVisualStyleBackColor = true;
            this.buttonHelp_DDE.Click += new System.EventHandler(this.buttonHelp_DDE_Click);
            this.buttonHelp_DDE.MouseEnter += new System.EventHandler(this.buttonHelp_DDE_MouseEnter);
            this.buttonHelp_DDE.MouseLeave += new System.EventHandler(this.buttonHelp_DDE_MouseLeave);
            // 
            // buttonExecute_DDE
            // 
            this.buttonExecute_DDE.Enabled = false;
            this.buttonExecute_DDE.Location = new System.Drawing.Point(654, 68);
            this.buttonExecute_DDE.Name = "buttonExecute_DDE";
            this.buttonExecute_DDE.Size = new System.Drawing.Size(100, 40);
            this.buttonExecute_DDE.TabIndex = 1;
            this.buttonExecute_DDE.Text = "Выполнить";
            this.buttonExecute_DDE.UseVisualStyleBackColor = true;
            this.buttonExecute_DDE.Click += new System.EventHandler(this.buttonExecute_DDE_Click);
            this.buttonExecute_DDE.MouseEnter += new System.EventHandler(this.buttonExecute_DDE_MouseEnter);
            this.buttonExecute_DDE.MouseLeave += new System.EventHandler(this.buttonExecute_DDE_MouseLeave);
            // 
            // buttonOpenFile_DDE
            // 
            this.buttonOpenFile_DDE.Location = new System.Drawing.Point(654, 114);
            this.buttonOpenFile_DDE.Name = "buttonOpenFile_DDE";
            this.buttonOpenFile_DDE.Size = new System.Drawing.Size(100, 40);
            this.buttonOpenFile_DDE.TabIndex = 0;
            this.buttonOpenFile_DDE.Text = "Открыть файл";
            this.buttonOpenFile_DDE.UseVisualStyleBackColor = true;
            this.buttonOpenFile_DDE.Click += new System.EventHandler(this.buttonOpenFile_DDE_Click);
            this.buttonOpenFile_DDE.MouseEnter += new System.EventHandler(this.buttonOpenFile_DDE_MouseEnter);
            this.buttonOpenFile_DDE.MouseLeave += new System.EventHandler(this.buttonOpenFile_DDE_MouseLeave);
            // 
            // openFileDialogTask_DDE
            // 
            this.openFileDialogTask_DDE.FileName = "openFileDialog1";
            // 
            // groupBoxOutput_DDE
            // 
            this.groupBoxOutput_DDE.Location = new System.Drawing.Point(12, 404);
            this.groupBoxOutput_DDE.Name = "groupBoxOutput_DDE";
            this.groupBoxOutput_DDE.Size = new System.Drawing.Size(760, 50);
            this.groupBoxOutput_DDE.TabIndex = 2;
            this.groupBoxOutput_DDE.TabStop = false;
            this.groupBoxOutput_DDE.Text = "Вывод данных";
            // 
            // textBoxOut_DDE
            // 
            this.textBoxOut_DDE.Location = new System.Drawing.Point(70, 160);
            this.textBoxOut_DDE.Multiline = true;
            this.textBoxOut_DDE.Name = "textBoxOut_DDE";
            this.textBoxOut_DDE.ReadOnly = true;
            this.textBoxOut_DDE.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOut_DDE.Size = new System.Drawing.Size(578, 134);
            this.textBoxOut_DDE.TabIndex = 3;
            // 
            // textBoxIn_DDE
            // 
            this.textBoxIn_DDE.Location = new System.Drawing.Point(70, 20);
            this.textBoxIn_DDE.Multiline = true;
            this.textBoxIn_DDE.Name = "textBoxIn_DDE";
            this.textBoxIn_DDE.ReadOnly = true;
            this.textBoxIn_DDE.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxIn_DDE.Size = new System.Drawing.Size(578, 134);
            this.textBoxIn_DDE.TabIndex = 4;
            // 
            // labelInput_DDE
            // 
            this.labelInput_DDE.AutoSize = true;
            this.labelInput_DDE.Location = new System.Drawing.Point(6, 23);
            this.labelInput_DDE.Name = "labelInput_DDE";
            this.labelInput_DDE.Size = new Size(40, 15);
            this.labelInput_DDE.TabIndex = 5;
            this.labelInput_DDE.Text = "Ввод:";
            // 
            // labelOutput_DDE
            // 
            this.labelOutput_DDE.AutoSize = true;
            this.labelOutput_DDE.Location = new System.Drawing.Point(6, 163);
            this.labelOutput_DDE.Name = "labelOutput_DDE";
            this.labelOutput_DDE.Size = new Size(48, 15);
            this.labelOutput_DDE.TabIndex = 6;
            this.labelOutput_DDE.Text = "Вывод:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 466);
            this.Controls.Add(this.groupBoxOutput_DDE);
            this.Controls.Add(this.groupBoxInput_DDE);
            this.Controls.Add(this.groupBoxCondition_DDE);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 505);
            this.MinimumSize = new System.Drawing.Size(800, 505);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 23 | Дацкий Д. Е.";
            this.groupBoxCondition_DDE.ResumeLayout(false);
            this.groupBoxCondition_DDE.PerformLayout();
            this.groupBoxInput_DDE.ResumeLayout(false);
            this.groupBoxInput_DDE.PerformLayout();
            this.groupBoxOutput_DDE.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_DDE;
        private System.Windows.Forms.TextBox textBoxTask_DDE;
        private System.Windows.Forms.GroupBox groupBoxInput_DDE;
        private System.Windows.Forms.Button buttonHelp_DDE;
        private System.Windows.Forms.Button buttonExecute_DDE;
        private System.Windows.Forms.Button buttonOpenFile_DDE;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_DDE;
        private System.Windows.Forms.GroupBox groupBoxOutput_DDE;
        private System.Windows.Forms.TextBox textBoxOut_DDE;
        private System.Windows.Forms.TextBox textBoxIn_DDE;
        private System.Windows.Forms.Label labelOutput_DDE;
        private System.Windows.Forms.Label labelInput_DDE;
    }
}