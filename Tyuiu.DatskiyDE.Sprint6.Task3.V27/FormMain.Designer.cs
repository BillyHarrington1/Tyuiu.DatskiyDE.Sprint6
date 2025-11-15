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
            labelMatrix_DDE = new Label();
            groupBoxInput_DDE = new GroupBox();
            buttonHelp_DDE = new Button();
            buttonCalculate_DDE = new Button();
            groupBoxOutput_DDE = new GroupBox();
            dataGridViewResult_DDE = new DataGridView();
            groupBoxCondition_DDE.SuspendLayout();
            groupBoxInput_DDE.SuspendLayout();
            groupBoxOutput_DDE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_DDE).BeginInit();
            SuspendLayout();
            // 
            // groupBoxCondition_DDE
            // 
            groupBoxCondition_DDE.Controls.Add(labelMatrix_DDE);
            groupBoxCondition_DDE.Location = new Point(35, 23);
            groupBoxCondition_DDE.Margin = new Padding(4, 3, 4, 3);
            groupBoxCondition_DDE.Name = "groupBoxCondition_DDE";
            groupBoxCondition_DDE.Padding = new Padding(4, 3, 4, 3);
            groupBoxCondition_DDE.Size = new Size(863, 92);
            groupBoxCondition_DDE.TabIndex = 0;
            groupBoxCondition_DDE.TabStop = false;
            groupBoxCondition_DDE.Text = "Условие";
            // 
            // labelMatrix_DDE
            // 
            labelMatrix_DDE.AutoSize = true;
            labelMatrix_DDE.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelMatrix_DDE.Location = new Point(35, 35);
            labelMatrix_DDE.Margin = new Padding(4, 0, 4, 0);
            labelMatrix_DDE.Name = "labelMatrix_DDE";
            labelMatrix_DDE.Size = new Size(482, 40);
            labelMatrix_DDE.TabIndex = 0;
            labelMatrix_DDE.Text = "Дан массив 5 на 5 элементов.\nВыполнить сортировку по возрастанию в четвёртом столбце.";
            // 
            // groupBoxInput_DDE
            // 
            groupBoxInput_DDE.Controls.Add(buttonHelp_DDE);
            groupBoxInput_DDE.Controls.Add(buttonCalculate_DDE);
            groupBoxInput_DDE.Location = new Point(35, 127);
            groupBoxInput_DDE.Margin = new Padding(4, 3, 4, 3);
            groupBoxInput_DDE.Name = "groupBoxInput_DDE";
            groupBoxInput_DDE.Padding = new Padding(4, 3, 4, 3);
            groupBoxInput_DDE.Size = new Size(863, 115);
            groupBoxInput_DDE.TabIndex = 1;
            groupBoxInput_DDE.TabStop = false;
            groupBoxInput_DDE.Text = "Ввод данных";
            // 
            // buttonHelp_DDE
            // 
            buttonHelp_DDE.Location = new Point(183, 33);
            buttonHelp_DDE.Margin = new Padding(4, 3, 4, 3);
            buttonHelp_DDE.Name = "buttonHelp_DDE";
            buttonHelp_DDE.Size = new Size(93, 27);
            buttonHelp_DDE.TabIndex = 0;
            buttonHelp_DDE.Text = "Справка";
            buttonHelp_DDE.UseVisualStyleBackColor = true;
            buttonHelp_DDE.Click += buttonHelp_DDE_Click;
            // 
            // buttonCalculate_DDE
            // 
            buttonCalculate_DDE.Location = new Point(183, 66);
            buttonCalculate_DDE.Margin = new Padding(4, 3, 4, 3);
            buttonCalculate_DDE.Name = "buttonCalculate_DDE";
            buttonCalculate_DDE.Size = new Size(93, 27);
            buttonCalculate_DDE.TabIndex = 1;
            buttonCalculate_DDE.Text = "Выполнить";
            buttonCalculate_DDE.UseVisualStyleBackColor = true;
            buttonCalculate_DDE.Click += buttonCalculate_DDE_Click;
            // 
            // groupBoxOutput_DDE
            // 
            groupBoxOutput_DDE.Controls.Add(dataGridViewResult_DDE);
            groupBoxOutput_DDE.Location = new Point(35, 254);
            groupBoxOutput_DDE.Margin = new Padding(4, 3, 4, 3);
            groupBoxOutput_DDE.Name = "groupBoxOutput_DDE";
            groupBoxOutput_DDE.Padding = new Padding(4, 3, 4, 3);
            groupBoxOutput_DDE.Size = new Size(863, 231);
            groupBoxOutput_DDE.TabIndex = 2;
            groupBoxOutput_DDE.TabStop = false;
            groupBoxOutput_DDE.Text = "Вывод данных";
            // 
            // dataGridViewResult_DDE
            // 
            dataGridViewResult_DDE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_DDE.Location = new Point(35, 35);
            dataGridViewResult_DDE.Margin = new Padding(4, 3, 4, 3);
            dataGridViewResult_DDE.Name = "dataGridViewResult_DDE";
            dataGridViewResult_DDE.Size = new Size(350, 173);
            dataGridViewResult_DDE.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(groupBoxOutput_DDE);
            Controls.Add(groupBoxInput_DDE);
            Controls.Add(groupBoxCondition_DDE);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 3 | Вариант 27 | Дацкий Д. Е.";
            groupBoxCondition_DDE.ResumeLayout(false);
            groupBoxCondition_DDE.PerformLayout();
            groupBoxInput_DDE.ResumeLayout(false);
            groupBoxOutput_DDE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_DDE).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_DDE;
        private System.Windows.Forms.Label labelMatrix_DDE;
        private System.Windows.Forms.GroupBox groupBoxInput_DDE;
        private System.Windows.Forms.Button buttonHelp_DDE;
        private System.Windows.Forms.Button buttonCalculate_DDE;
        private System.Windows.Forms.GroupBox groupBoxOutput_DDE;
        private System.Windows.Forms.DataGridView dataGridViewResult_DDE;
    }
}
