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

            this.groupBoxCondition_DDE = new System.Windows.Forms.GroupBox();
            this.labelFormula_DDE = new System.Windows.Forms.Label();
            this.groupBoxInput_DDE = new System.Windows.Forms.GroupBox();
            this.labelStart_DDE = new System.Windows.Forms.Label();
            this.textBoxStart_DDE = new System.Windows.Forms.TextBox();
            this.labelStop_DDE = new System.Windows.Forms.Label();
            this.textBoxStop_DDE = new System.Windows.Forms.TextBox();
            this.buttonHelp_DDE = new System.Windows.Forms.Button();
            this.buttonCalculate_DDE = new System.Windows.Forms.Button();
            this.groupBoxOutput_DDE = new System.Windows.Forms.GroupBox();
            this.dataGridViewResult_DDE = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SuspendLayout();
            // 
            // groupBoxCondition_DDE
            // 
            this.groupBoxCondition_DDE.Controls.Add(this.labelFormula_DDE);
            this.groupBoxCondition_DDE.Location = new System.Drawing.Point(30, 20);
            this.groupBoxCondition_DDE.Name = "groupBoxCondition_DDE";
            this.groupBoxCondition_DDE.Size = new System.Drawing.Size(740, 80);
            this.groupBoxCondition_DDE.TabIndex = 0;
            this.groupBoxCondition_DDE.TabStop = false;
            this.groupBoxCondition_DDE.Text = "Условие";
            // 
            // labelFormula_DDE
            // 
            this.labelFormula_DDE.AutoSize = true;
            this.labelFormula_DDE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFormula_DDE.Location = new System.Drawing.Point(30, 30);
            this.labelFormula_DDE.Name = "labelFormula_DDE";
            this.labelFormula_DDE.Size = new System.Drawing.Size(300, 20);
            this.labelFormula_DDE.TabIndex = 0;
            this.labelFormula_DDE.Text = "F(x) = 3x + 2 - (2x - x)/(cos(x) + 1)";
            // 
            // groupBoxInput_DDE
            // 
            this.groupBoxInput_DDE.Controls.Add(this.labelStart_DDE);
            this.groupBoxInput_DDE.Controls.Add(this.textBoxStart_DDE);
            this.groupBoxInput_DDE.Controls.Add(this.labelStop_DDE);
            this.groupBoxInput_DDE.Controls.Add(this.textBoxStop_DDE);
            this.groupBoxInput_DDE.Controls.Add(this.buttonHelp_DDE);
            this.groupBoxInput_DDE.Controls.Add(this.buttonCalculate_DDE);
            this.groupBoxInput_DDE.Location = new System.Drawing.Point(30, 110);
            this.groupBoxInput_DDE.Name = "groupBoxInput_DDE";
            this.groupBoxInput_DDE.Size = new System.Drawing.Size(740, 100);
            this.groupBoxInput_DDE.TabIndex = 1;
            this.groupBoxInput_DDE.TabStop = false;
            this.groupBoxInput_DDE.Text = "Ввод данных";
            // 
            // labelStart_DDE
            // 
            this.labelStart_DDE.AutoSize = true;
            this.labelStart_DDE.Location = new System.Drawing.Point(30, 30);
            this.labelStart_DDE.Name = "labelStart_DDE";
            this.labelStart_DDE.Size = new System.Drawing.Size(65, 13);
            this.labelStart_DDE.TabIndex = 0;
            this.labelStart_DDE.Text = "Старт шага:";
            // 
            // textBoxStart_DDE
            // 
            this.textBoxStart_DDE.Location = new System.Drawing.Point(100, 27);
            this.textBoxStart_DDE.Name = "textBoxStart_DDE";
            this.textBoxStart_DDE.Size = new System.Drawing.Size(100, 20);
            this.textBoxStart_DDE.TabIndex = 1;
            // 
            // labelStop_DDE
            // 
            this.labelStop_DDE.AutoSize = true;
            this.labelStop_DDE.Location = new System.Drawing.Point(30, 60);
            this.labelStop_DDE.Name = "labelStop_DDE";
            this.labelStop_DDE.Size = new System.Drawing.Size(65, 13);
            this.labelStop_DDE.TabIndex = 2;
            this.labelStop_DDE.Text = "Конец шага:";
            // 
            // textBoxStop_DDE
            // 
            this.textBoxStop_DDE.Location = new System.Drawing.Point(100, 57);
            this.textBoxStop_DDE.Name = "textBoxStop_DDE";
            this.textBoxStop_DDE.Size = new System.Drawing.Size(100, 20);
            this.textBoxStop_DDE.TabIndex = 3;
            // 
            // buttonHelp_DDE
            // 
            this.buttonHelp_DDE.Location = new System.Drawing.Point(220, 27);
            this.buttonHelp_DDE.Name = "buttonHelp_DDE";
            this.buttonHelp_DDE.Size = new System.Drawing.Size(80, 23);
            this.buttonHelp_DDE.TabIndex = 4;
            this.buttonHelp_DDE.Text = "Справка";
            this.buttonHelp_DDE.UseVisualStyleBackColor = true;
            this.buttonHelp_DDE.Click += new System.EventHandler(this.buttonHelp_DDE_Click);
            // 
            // buttonCalculate_DDE
            // 
            this.buttonCalculate_DDE.Location = new System.Drawing.Point(220, 57);
            this.buttonCalculate_DDE.Name = "buttonCalculate_DDE";
            this.buttonCalculate_DDE.Size = new System.Drawing.Size(80, 23);
            this.buttonCalculate_DDE.TabIndex = 5;
            this.buttonCalculate_DDE.Text = "Выполнить";
            this.buttonCalculate_DDE.UseVisualStyleBackColor = true;
            this.buttonCalculate_DDE.Click += new System.EventHandler(this.buttonCalculate_DDE_Click);
            // 
            // groupBoxOutput_DDE
            // 
            this.groupBoxOutput_DDE.Controls.Add(this.dataGridViewResult_DDE);
            this.groupBoxOutput_DDE.Location = new System.Drawing.Point(30, 220);
            this.groupBoxOutput_DDE.Name = "groupBoxOutput_DDE";
            this.groupBoxOutput_DDE.Size = new System.Drawing.Size(740, 200);
            this.groupBoxOutput_DDE.TabIndex = 2;
            this.groupBoxOutput_DDE.TabStop = false;
            this.groupBoxOutput_DDE.Text = "Вывод данных";
            // 
            // dataGridViewResult_DDE
            // 
            this.dataGridViewResult_DDE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_DDE.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridViewResult_DDE.Location = new System.Drawing.Point(30, 30);
            this.dataGridViewResult_DDE.Name = "dataGridViewResult_DDE";
            this.dataGridViewResult_DDE.Size = new System.Drawing.Size(300, 150);
            this.dataGridViewResult_DDE.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "X";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "F(X)";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 80;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxOutput_DDE);
            this.Controls.Add(this.groupBoxInput_DDE);
            this.Controls.Add(this.groupBoxCondition_DDE);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 2 | Вариант 7 | Дацкий Д. Е.";
            this.ResumeLayout(false);
            this.PerformLayout();

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