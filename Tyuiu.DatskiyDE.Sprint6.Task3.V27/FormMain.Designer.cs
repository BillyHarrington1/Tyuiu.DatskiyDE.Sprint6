namespace Tyuiu.DatskiyDE.Sprint6.Task3.V27
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxCondition_DDE = new GroupBox();
            textBoxTask_DDE = new TextBox();
            groupBoxInput_DDE = new GroupBox();
            buttonHelp_DDE = new Button();
            buttonCalculate_DDE = new Button();
            groupBoxOutput_DDE = new GroupBox();
            textBoxResult_DDE = new TextBox();
            dataGridViewResult_DDE = new DataGridView();
            groupBoxCondition_DDE.SuspendLayout();
            groupBoxInput_DDE.SuspendLayout();
            groupBoxOutput_DDE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_DDE).BeginInit();
            SuspendLayout();
            // 
            // groupBoxCondition_DDE
            // 
            groupBoxCondition_DDE.BackColor = SystemColors.ActiveCaption;
            groupBoxCondition_DDE.Controls.Add(textBoxTask_DDE);
            groupBoxCondition_DDE.Location = new Point(12, 12);
            groupBoxCondition_DDE.Name = "groupBoxCondition_DDE";
            groupBoxCondition_DDE.Size = new Size(510, 102);
            groupBoxCondition_DDE.TabIndex = 0;
            groupBoxCondition_DDE.TabStop = false;
            groupBoxCondition_DDE.Text = "Условие";
            // 
            // textBoxTask_DDE
            // 
            textBoxTask_DDE.BackColor = SystemColors.ActiveCaption;
            textBoxTask_DDE.BorderStyle = BorderStyle.None;
            textBoxTask_DDE.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxTask_DDE.Location = new Point(6, 22);
            textBoxTask_DDE.Multiline = true;
            textBoxTask_DDE.Name = "textBoxTask_DDE";
            textBoxTask_DDE.ReadOnly = true;
            textBoxTask_DDE.Size = new Size(498, 52);
            textBoxTask_DDE.TabIndex = 0;
            textBoxTask_DDE.Text = "Дан массив 5 на 5 элементов. Выполнить сортировку по возрастанию в четвертом столбце.";
            // 
            // groupBoxInput_DDE
            // 
            groupBoxInput_DDE.BackColor = SystemColors.ActiveCaption;
            groupBoxInput_DDE.Controls.Add(buttonHelp_DDE);
            groupBoxInput_DDE.Controls.Add(buttonCalculate_DDE);
            groupBoxInput_DDE.Location = new Point(12, 98);
            groupBoxInput_DDE.Name = "groupBoxInput_DDE";
            groupBoxInput_DDE.Size = new Size(510, 92);
            groupBoxInput_DDE.TabIndex = 1;
            groupBoxInput_DDE.TabStop = false;
            groupBoxInput_DDE.Text = "-..-";
            // 
            // buttonHelp_DDE
            // 
            buttonHelp_DDE.BackColor = SystemColors.ButtonHighlight;
            buttonHelp_DDE.Location = new Point(6, 16);
            buttonHelp_DDE.Name = "buttonHelp_DDE";
            buttonHelp_DDE.Size = new Size(249, 64);
            buttonHelp_DDE.TabIndex = 1;
            buttonHelp_DDE.Text = "Справка";
            buttonHelp_DDE.UseVisualStyleBackColor = false;
            buttonHelp_DDE.Click += buttonHelp_DDE_Click;
            buttonHelp_DDE.MouseEnter += buttonHelp_DDE_MouseEnter;
            buttonHelp_DDE.MouseLeave += buttonHelp_DDE_MouseLeave;
            // 
            // buttonCalculate_DDE
            // 
            buttonCalculate_DDE.BackColor = SystemColors.Control;
            buttonCalculate_DDE.Location = new Point(261, 16);
            buttonCalculate_DDE.Name = "buttonCalculate_DDE";
            buttonCalculate_DDE.Size = new Size(243, 64);
            buttonCalculate_DDE.TabIndex = 0;
            buttonCalculate_DDE.Text = "Выполнить";
            buttonCalculate_DDE.UseVisualStyleBackColor = false;
            buttonCalculate_DDE.Click += buttonCalculate_DDE_Click;
            buttonCalculate_DDE.MouseEnter += buttonCalculate_DDE_MouseEnter;
            buttonCalculate_DDE.MouseLeave += buttonCalculate_DDE_MouseLeave;
            // 
            // groupBoxOutput_DDE
            // 
            groupBoxOutput_DDE.BackColor = SystemColors.ActiveCaption;
            groupBoxOutput_DDE.Controls.Add(textBoxResult_DDE);
            groupBoxOutput_DDE.Controls.Add(dataGridViewResult_DDE);
            groupBoxOutput_DDE.Location = new Point(12, 184);
            groupBoxOutput_DDE.Name = "groupBoxOutput_DDE";
            groupBoxOutput_DDE.Size = new Size(510, 250);
            groupBoxOutput_DDE.TabIndex = 2;
            groupBoxOutput_DDE.TabStop = false;
            groupBoxOutput_DDE.Text = "Вывод данных";
            // 
            // textBoxResult_DDE
            // 
            textBoxResult_DDE.BackColor = SystemColors.ActiveCaption;
            textBoxResult_DDE.BorderStyle = BorderStyle.FixedSingle;
            textBoxResult_DDE.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult_DDE.Location = new Point(6, 221);
            textBoxResult_DDE.Name = "textBoxResult_DDE";
            textBoxResult_DDE.ReadOnly = true;
            textBoxResult_DDE.Size = new Size(498, 23);
            textBoxResult_DDE.TabIndex = 1;
            textBoxResult_DDE.TextAlign = HorizontalAlignment.Center;
            // 
            // dataGridViewResult_DDE
            // 
            dataGridViewResult_DDE.AllowUserToAddRows = false;
            dataGridViewResult_DDE.AllowUserToDeleteRows = false;
            dataGridViewResult_DDE.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewResult_DDE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_DDE.ColumnHeadersVisible = false;
            dataGridViewResult_DDE.Location = new Point(6, 22);
            dataGridViewResult_DDE.Name = "dataGridViewResult_DDE";
            dataGridViewResult_DDE.ReadOnly = true;
            dataGridViewResult_DDE.RowHeadersVisible = false;
            dataGridViewResult_DDE.Size = new Size(498, 180);
            dataGridViewResult_DDE.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(534, 446);
            Controls.Add(groupBoxOutput_DDE);
            Controls.Add(groupBoxInput_DDE);
            Controls.Add(groupBoxCondition_DDE);
            MaximizeBox = false;
            MaximumSize = new Size(550, 485);
            MinimumSize = new Size(550, 485);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 3 | Вариант 27 | Дацкий Д. Е.";
            Load += FormMain_Load;
            groupBoxCondition_DDE.ResumeLayout(false);
            groupBoxCondition_DDE.PerformLayout();
            groupBoxInput_DDE.ResumeLayout(false);
            groupBoxOutput_DDE.ResumeLayout(false);
            groupBoxOutput_DDE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_DDE).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_DDE;
        private TextBox textBoxTask_DDE;
        private GroupBox groupBoxInput_DDE;
        private Button buttonHelp_DDE;
        private Button buttonCalculate_DDE;
        private GroupBox groupBoxOutput_DDE;
        private DataGridView dataGridViewResult_DDE;
        private TextBox textBoxResult_DDE;
    }
}
