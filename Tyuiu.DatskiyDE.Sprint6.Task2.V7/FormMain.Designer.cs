namespace Tyuiu.DatskiyDE.Sprint6.Task2.V7
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
            labelFormula_DDE = new Label();
            groupBoxInput_DDE = new GroupBox();
            labelStart_DDE = new Label();
            textBoxStart_DDE = new TextBox();
            labelStop_DDE = new Label();
            textBoxStop_DDE = new TextBox();
            buttonHelp_DDE = new Button();
            buttonCalculate_DDE = new Button();
            groupBoxOutput_DDE = new GroupBox();
            dataGridViewResult_DDE = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            groupBoxCondition_DDE.SuspendLayout();
            groupBoxInput_DDE.SuspendLayout();
            groupBoxOutput_DDE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_DDE).BeginInit();
            SuspendLayout();
            // 
            // groupBoxCondition_DDE
            // 
            groupBoxCondition_DDE.Controls.Add(labelFormula_DDE);
            groupBoxCondition_DDE.Location = new Point(35, 23);
            groupBoxCondition_DDE.Margin = new Padding(4, 3, 4, 3);
            groupBoxCondition_DDE.Name = "groupBoxCondition_DDE";
            groupBoxCondition_DDE.Padding = new Padding(4, 3, 4, 3);
            groupBoxCondition_DDE.Size = new Size(409, 92);
            groupBoxCondition_DDE.TabIndex = 0;
            groupBoxCondition_DDE.TabStop = false;
            groupBoxCondition_DDE.Text = "Условие";
            // 
            // labelFormula_DDE
            // 
            labelFormula_DDE.AutoSize = true;
            labelFormula_DDE.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelFormula_DDE.Location = new Point(35, 35);
            labelFormula_DDE.Margin = new Padding(4, 0, 4, 0);
            labelFormula_DDE.Name = "labelFormula_DDE";
            labelFormula_DDE.Size = new Size(236, 20);
            labelFormula_DDE.TabIndex = 0;
            labelFormula_DDE.Text = "F(x) = 3x + 2 - (2x - x)/(cos(x) + 1)";
            // 
            // groupBoxInput_DDE
            // 
            groupBoxInput_DDE.Controls.Add(labelStart_DDE);
            groupBoxInput_DDE.Controls.Add(textBoxStart_DDE);
            groupBoxInput_DDE.Controls.Add(labelStop_DDE);
            groupBoxInput_DDE.Controls.Add(textBoxStop_DDE);
            groupBoxInput_DDE.Controls.Add(buttonHelp_DDE);
            groupBoxInput_DDE.Controls.Add(buttonCalculate_DDE);
            groupBoxInput_DDE.Location = new Point(35, 127);
            groupBoxInput_DDE.Margin = new Padding(4, 3, 4, 3);
            groupBoxInput_DDE.Name = "groupBoxInput_DDE";
            groupBoxInput_DDE.Padding = new Padding(4, 3, 4, 3);
            groupBoxInput_DDE.Size = new Size(409, 115);
            groupBoxInput_DDE.TabIndex = 1;
            groupBoxInput_DDE.TabStop = false;
            groupBoxInput_DDE.Text = "Ввод данных";
            // 
            // labelStart_DDE
            // 
            labelStart_DDE.AutoSize = true;
            labelStart_DDE.Location = new Point(35, 35);
            labelStart_DDE.Margin = new Padding(4, 0, 4, 0);
            labelStart_DDE.Name = "labelStart_DDE";
            labelStart_DDE.Size = new Size(72, 15);
            labelStart_DDE.TabIndex = 0;
            labelStart_DDE.Text = "Старт шага:";
            // 
            // textBoxStart_DDE
            // 
            textBoxStart_DDE.Location = new Point(117, 31);
            textBoxStart_DDE.Margin = new Padding(4, 3, 4, 3);
            textBoxStart_DDE.Name = "textBoxStart_DDE";
            textBoxStart_DDE.Size = new Size(116, 23);
            textBoxStart_DDE.TabIndex = 1;
            // 
            // labelStop_DDE
            // 
            labelStop_DDE.AutoSize = true;
            labelStop_DDE.Location = new Point(35, 69);
            labelStop_DDE.Margin = new Padding(4, 0, 4, 0);
            labelStop_DDE.Name = "labelStop_DDE";
            labelStop_DDE.Size = new Size(75, 15);
            labelStop_DDE.TabIndex = 2;
            labelStop_DDE.Text = "Конец шага:";
            // 
            // textBoxStop_DDE
            // 
            textBoxStop_DDE.Location = new Point(117, 66);
            textBoxStop_DDE.Margin = new Padding(4, 3, 4, 3);
            textBoxStop_DDE.Name = "textBoxStop_DDE";
            textBoxStop_DDE.Size = new Size(116, 23);
            textBoxStop_DDE.TabIndex = 3;
            // 
            // buttonHelp_DDE
            // 
            buttonHelp_DDE.Location = new Point(257, 31);
            buttonHelp_DDE.Margin = new Padding(4, 3, 4, 3);
            buttonHelp_DDE.Name = "buttonHelp_DDE";
            buttonHelp_DDE.Size = new Size(93, 27);
            buttonHelp_DDE.TabIndex = 4;
            buttonHelp_DDE.Text = "Справка";
            buttonHelp_DDE.UseVisualStyleBackColor = true;
            buttonHelp_DDE.Click += buttonHelp_DDE_Click;
            // 
            // buttonCalculate_DDE
            // 
            buttonCalculate_DDE.Location = new Point(257, 66);
            buttonCalculate_DDE.Margin = new Padding(4, 3, 4, 3);
            buttonCalculate_DDE.Name = "buttonCalculate_DDE";
            buttonCalculate_DDE.Size = new Size(93, 27);
            buttonCalculate_DDE.TabIndex = 5;
            buttonCalculate_DDE.Text = "Выполнить";
            buttonCalculate_DDE.UseVisualStyleBackColor = true;
            buttonCalculate_DDE.Click += buttonCalculate_DDE_Click;
            // 
            // groupBoxOutput_DDE
            // 
            groupBoxOutput_DDE.Controls.Add(dataGridViewResult_DDE);
            groupBoxOutput_DDE.Location = new Point(465, 23);
            groupBoxOutput_DDE.Margin = new Padding(4, 3, 4, 3);
            groupBoxOutput_DDE.Name = "groupBoxOutput_DDE";
            groupBoxOutput_DDE.Padding = new Padding(4, 3, 4, 3);
            groupBoxOutput_DDE.Size = new Size(437, 219);
            groupBoxOutput_DDE.TabIndex = 2;
            groupBoxOutput_DDE.TabStop = false;
            groupBoxOutput_DDE.Text = "Вывод данных";
            // 
            // dataGridViewResult_DDE
            // 
            dataGridViewResult_DDE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_DDE.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2 });
            dataGridViewResult_DDE.Location = new Point(143, 35);
            dataGridViewResult_DDE.Margin = new Padding(4, 3, 4, 3);
            dataGridViewResult_DDE.Name = "dataGridViewResult_DDE";
            dataGridViewResult_DDE.Size = new Size(172, 173);
            dataGridViewResult_DDE.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "X";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "F(X)";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 80;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 328);
            Controls.Add(groupBoxOutput_DDE);
            Controls.Add(groupBoxInput_DDE);
            Controls.Add(groupBoxCondition_DDE);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 2 | Вариант 7 | Дацкий Д. Е.";
            groupBoxCondition_DDE.ResumeLayout(false);
            groupBoxCondition_DDE.PerformLayout();
            groupBoxInput_DDE.ResumeLayout(false);
            groupBoxInput_DDE.PerformLayout();
            groupBoxOutput_DDE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_DDE).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_DDE;
        private System.Windows.Forms.Label labelFormula_DDE;
        private System.Windows.Forms.GroupBox groupBoxInput_DDE;
        private System.Windows.Forms.Label labelStart_DDE;
        private System.Windows.Forms.TextBox textBoxStart_DDE;
        private System.Windows.Forms.Label labelStop_DDE;
        private System.Windows.Forms.TextBox textBoxStop_DDE;
        private System.Windows.Forms.Button buttonHelp_DDE;
        private System.Windows.Forms.Button buttonCalculate_DDE;
        private System.Windows.Forms.GroupBox groupBoxOutput_DDE;
        private System.Windows.Forms.DataGridView dataGridViewResult_DDE;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}