using System.Windows.Forms.Integration;

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
            groupBoxCondition_DDE = new GroupBox();
            labelFormula_DDE = new Label();
            groupBoxInput_DDE = new GroupBox();
            buttonHelp_DDE = new Button();
            buttonCalculate_DDE = new Button();
            buttonSave_DDE = new Button();
            groupBoxOutput_DDE = new GroupBox();
            textBoxResult_DDE = new TextBox();
            cartesianChartResult_DDE = new LiveCharts.WinForms.CartesianChart();
            groupBoxCondition_DDE.SuspendLayout();
            groupBoxInput_DDE.SuspendLayout();
            groupBoxOutput_DDE.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCondition_DDE
            // 
            groupBoxCondition_DDE.Controls.Add(labelFormula_DDE);
            groupBoxCondition_DDE.Location = new Point(35, 23);
            groupBoxCondition_DDE.Margin = new Padding(4, 3, 4, 3);
            groupBoxCondition_DDE.Name = "groupBoxCondition_DDE";
            groupBoxCondition_DDE.Padding = new Padding(4, 3, 4, 3);
            groupBoxCondition_DDE.Size = new Size(863, 92);
            groupBoxCondition_DDE.TabIndex = 0;
            groupBoxCondition_DDE.TabStop = false;
            groupBoxCondition_DDE.Text = "Условие";
            // 
            // labelFormula_DDE
            // 
            labelFormula_DDE.AutoSize = true;
            labelFormula_DDE.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelFormula_DDE.Location = new Point(35, 42);
            labelFormula_DDE.Margin = new Padding(4, 0, 4, 0);
            labelFormula_DDE.Name = "labelFormula_DDE";
            labelFormula_DDE.Size = new Size(273, 20);
            labelFormula_DDE.TabIndex = 0;
            labelFormula_DDE.Text = "F(x) = (2*sin(x))/(3x+1.2) + cos(x) - 14x";
            // 
            // groupBoxInput_DDE
            // 
            groupBoxInput_DDE.Controls.Add(buttonHelp_DDE);
            groupBoxInput_DDE.Controls.Add(buttonCalculate_DDE);
            groupBoxInput_DDE.Controls.Add(buttonSave_DDE);
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
            buttonHelp_DDE.BackColor = Color.FromArgb(128, 128, 255);
            buttonHelp_DDE.Location = new Point(35, 22);
            buttonHelp_DDE.Margin = new Padding(4, 3, 4, 3);
            buttonHelp_DDE.Name = "buttonHelp_DDE";
            buttonHelp_DDE.Size = new Size(265, 78);
            buttonHelp_DDE.TabIndex = 0;
            buttonHelp_DDE.Text = "Справка";
            buttonHelp_DDE.UseVisualStyleBackColor = false;
            buttonHelp_DDE.Click += buttonHelp_DDE_Click;
            // 
            // buttonCalculate_DDE
            // 
            buttonCalculate_DDE.BackColor = SystemColors.Highlight;
            buttonCalculate_DDE.Location = new Point(308, 22);
            buttonCalculate_DDE.Margin = new Padding(4, 3, 4, 3);
            buttonCalculate_DDE.Name = "buttonCalculate_DDE";
            buttonCalculate_DDE.Size = new Size(256, 78);
            buttonCalculate_DDE.TabIndex = 1;
            buttonCalculate_DDE.Text = "Выполнить";
            buttonCalculate_DDE.UseVisualStyleBackColor = false;
            buttonCalculate_DDE.Click += buttonCalculate_DDE_Click;
            // 
            // buttonSave_DDE
            // 
            buttonSave_DDE.BackColor = SystemColors.Desktop;
            buttonSave_DDE.Location = new Point(572, 22);
            buttonSave_DDE.Margin = new Padding(4, 3, 4, 3);
            buttonSave_DDE.Name = "buttonSave_DDE";
            buttonSave_DDE.Size = new Size(267, 78);
            buttonSave_DDE.TabIndex = 2;
            buttonSave_DDE.Text = "Сохранить";
            buttonSave_DDE.UseVisualStyleBackColor = false;
            buttonSave_DDE.Click += buttonSave_DDE_Click;
            // 
            // groupBoxOutput_DDE
            // 
            groupBoxOutput_DDE.Controls.Add(textBoxResult_DDE);
            groupBoxOutput_DDE.Controls.Add(cartesianChartResult_DDE);
            groupBoxOutput_DDE.Location = new Point(35, 254);
            groupBoxOutput_DDE.Margin = new Padding(4, 3, 4, 3);
            groupBoxOutput_DDE.Name = "groupBoxOutput_DDE";
            groupBoxOutput_DDE.Padding = new Padding(4, 3, 4, 3);
            groupBoxOutput_DDE.Size = new Size(863, 231);
            groupBoxOutput_DDE.TabIndex = 2;
            groupBoxOutput_DDE.TabStop = false;
            groupBoxOutput_DDE.Text = "Вывод данных";
            // 
            // textBoxResult_DDE
            // 
            textBoxResult_DDE.BackColor = Color.IndianRed;
            textBoxResult_DDE.Location = new Point(35, 35);
            textBoxResult_DDE.Margin = new Padding(4, 3, 4, 3);
            textBoxResult_DDE.Multiline = true;
            textBoxResult_DDE.Name = "textBoxResult_DDE";
            textBoxResult_DDE.ReadOnly = true;
            textBoxResult_DDE.Size = new Size(349, 172);
            textBoxResult_DDE.TabIndex = 0;
            // 
            // cartesianChartResult_DDE
            // 
            cartesianChartResult_DDE.BackColor = Color.IndianRed;
            cartesianChartResult_DDE.Location = new Point(457, 35);
            cartesianChartResult_DDE.Margin = new Padding(4, 3, 4, 3);
            cartesianChartResult_DDE.Name = "cartesianChartResult_DDE";
            cartesianChartResult_DDE.Size = new Size(359, 173);
            cartesianChartResult_DDE.TabIndex = 1;
            cartesianChartResult_DDE.Text = "cartesianChart_DDE";
            cartesianChartResult_DDE.ChildChanged += cartesianChartResult_DDE_ChildChanged;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(933, 519);
            Controls.Add(groupBoxOutput_DDE);
            Controls.Add(groupBoxInput_DDE);
            Controls.Add(groupBoxCondition_DDE);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormMain";
            Text = "Спринт 6 | Task 4 | Вариант 5 | Дацкий Д. Е.";
            groupBoxCondition_DDE.ResumeLayout(false);
            groupBoxCondition_DDE.PerformLayout();
            groupBoxInput_DDE.ResumeLayout(false);
            groupBoxOutput_DDE.ResumeLayout(false);
            groupBoxOutput_DDE.PerformLayout();
            ResumeLayout(false);

        }

        private void cartesianChartResult_DDE_ChildChanged(object sender, ChildChangedEventArgs e)
        {
            throw new NotImplementedException();
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