namespace Tyuiu.DatskiyDE.Sprint6.Task4.V5
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
            this.buttonHelp_DDE = new System.Windows.Forms.Button();
            this.buttonCalculate_DDE = new System.Windows.Forms.Button();
            this.buttonSave_DDE = new System.Windows.Forms.Button();
            this.groupBoxOutput_DDE = new System.Windows.Forms.GroupBox();
            this.textBoxResult_DDE = new System.Windows.Forms.TextBox();
            this.cartesianChartResult_DDE = new LiveCharts.WinForms.CartesianChart();
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
            this.labelFormula_DDE.Text = "F(x) = (2*sin(x))/(3x+1.2) + cos(x) - 14x";
            // 
            // groupBoxInput_DDE
            // 
            this.groupBoxInput_DDE.Controls.Add(this.buttonHelp_DDE);
            this.groupBoxInput_DDE.Controls.Add(this.buttonCalculate_DDE);
            this.groupBoxInput_DDE.Controls.Add(this.buttonSave_DDE);
            this.groupBoxInput_DDE.Location = new System.Drawing.Point(30, 110);
            this.groupBoxInput_DDE.Name = "groupBoxInput_DDE";
            this.groupBoxInput_DDE.Size = new System.Drawing.Size(740, 100);
            this.groupBoxInput_DDE.TabIndex = 1;
            this.groupBoxInput_DDE.TabStop = false;
            this.groupBoxInput_DDE.Text = "Ввод данных";
            // 
            // buttonHelp_DDE
            // 
            this.buttonHelp_DDE.Location = new System.Drawing.Point(220, 27);
            this.buttonHelp_DDE.Name = "buttonHelp_DDE";
            this.buttonHelp_DDE.Size = new System.Drawing.Size(80, 23);
            this.buttonHelp_DDE.TabIndex = 0;
            this.buttonHelp_DDE.Text = "Справка";
            this.buttonHelp_DDE.UseVisualStyleBackColor = true;
            this.buttonHelp_DDE.Click += new System.EventHandler(this.buttonHelp_DDE_Click);
            // 
            // buttonCalculate_DDE
            // 
            this.buttonCalculate_DDE.Location = new System.Drawing.Point(320, 27);
            this.buttonCalculate_DDE.Name = "buttonCalculate_DDE";
            this.buttonCalculate_DDE.Size = new System.Drawing.Size(80, 23);
            this.buttonCalculate_DDE.TabIndex = 1;
            this.buttonCalculate_DDE.Text = "Выполнить";
            this.buttonCalculate_DDE.UseVisualStyleBackColor = true;
            this.buttonCalculate_DDE.Click += new System.EventHandler(this.buttonCalculate_DDE_Click);
            // 
            // buttonSave_DDE
            // 
            this.buttonSave_DDE.Location = new System.Drawing.Point(420, 27);
            this.buttonSave_DDE.Name = "buttonSave_DDE";
            this.buttonSave_DDE.Size = new System.Drawing.Size(80, 23);
            this.buttonSave_DDE.TabIndex = 2;
            this.buttonSave_DDE.Text = "Сохранить";
            this.buttonSave_DDE.UseVisualStyleBackColor = true;
            this.buttonSave_DDE.Click += new System.EventHandler(this.buttonSave_DDE_Click);
            // 
            // groupBoxOutput_DDE
            // 
            this.groupBoxOutput_DDE.Controls.Add(this.textBoxResult_DDE);
            this.groupBoxOutput_DDE.Controls.Add(this.cartesianChartResult_DDE);
            this.groupBoxOutput_DDE.Location = new System.Drawing.Point(30, 220);
            this.groupBoxOutput_DDE.Name = "groupBoxOutput_DDE";
            this.groupBoxOutput_DDE.Size = new System.Drawing.Size(740, 200);
            this.groupBoxOutput_DDE.TabIndex = 2;
            this.groupBoxOutput_DDE.TabStop = false;
            this.groupBoxOutput_DDE.Text = "Вывод данных";
            // 
            // textBoxResult_DDE
            // 
            this.textBoxResult_DDE.Location = new System.Drawing.Point(30, 30);
            this.textBoxResult_DDE.Multiline = true;
            this.textBoxResult_DDE.Name = "textBoxResult_DDE";
            this.textBoxResult_DDE.ReadOnly = true;
            this.textBoxResult_DDE.Size = new System.Drawing.Size(300, 150);
            this.textBoxResult_DDE.TabIndex = 0;
            // 
            // cartesianChartResult_DDE
            // 
            this.cartesianChartResult_DDE.Location = new System.Drawing.Point(350, 30);
            this.cartesianChartResult_DDE.Name = "cartesianChartResult_DDE";
            this.cartesianChartResult_DDE.Size = new System.Drawing.Size(350, 150);
            this.cartesianChartResult_DDE.TabIndex = 1;
            this.cartesianChartResult_DDE.Text = "cartesianChart1";
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
            this.Text = "Спринт 6 | Task 4 | Вариант 5 | Дацкий Д. Е.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_DDE;
        private System.Windows.Forms.Label labelFormula_DDE;
        private System.Windows.Forms.GroupBox groupBoxInput_DDE;
        private System.Windows.Forms.Button buttonHelp_DDE;
        private System.Windows.Forms.Button buttonCalculate_DDE;
        private System.Windows.Forms.Button buttonSave_DDE;
        private System.Windows.Forms.GroupBox groupBoxOutput_DDE;
        private System.Windows.Forms.TextBox textBoxResult_DDE;
        private LiveCharts.WinForms.CartesianChart cartesianChartResult_DDE;
    }
}