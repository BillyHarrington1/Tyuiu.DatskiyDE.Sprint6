namespace Tyuiu.DatskiyDE.Sprint6.Task0.V22
{
    partial class FormMain_DDE
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

        #region Код, автоматически созданный конструктором форм Windows

        private void InitializeComponent()
        {
            labelFormula_DDE = new Label();
            labelX_DDE = new Label();
            textBoxInput_DDE = new TextBox();
            labelResult_DDE = new Label();
            textBoxResult_DDE = new TextBox();
            buttonCalculatePush_DDE = new Button();
            groupBoxCondition_DDE = new GroupBox();
            groupBoxInput_DDE = new GroupBox();
            groupBoxOutput_DDE = new GroupBox();
            groupBoxCondition_DDE.SuspendLayout();
            groupBoxInput_DDE.SuspendLayout();
            groupBoxOutput_DDE.SuspendLayout();
            SuspendLayout();
            // 
            // labelFormula_DDE
            // 
            labelFormula_DDE.AutoSize = true;
            labelFormula_DDE.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelFormula_DDE.Location = new Point(7, 19);
            labelFormula_DDE.Margin = new Padding(4, 0, 4, 0);
            labelFormula_DDE.Name = "labelFormula_DDE";
            labelFormula_DDE.Size = new Size(147, 20);
            labelFormula_DDE.TabIndex = 1;
            labelFormula_DDE.Text = "F(x) = 0.7x³ + 1.52x²";
            labelFormula_DDE.Click += labelFormula_Click;
            // 
            // labelX_DDE
            // 
            labelX_DDE.AutoSize = true;
            labelX_DDE.Location = new Point(7, 24);
            labelX_DDE.Margin = new Padding(4, 0, 4, 0);
            labelX_DDE.Name = "labelX_DDE";
            labelX_DDE.Size = new Size(89, 15);
            labelX_DDE.TabIndex = 3;
            labelX_DDE.Text = "Переменная X:";
            // 
            // textBoxInput_DDE
            // 
            textBoxInput_DDE.Location = new Point(7, 42);
            textBoxInput_DDE.Margin = new Padding(4, 3, 4, 3);
            textBoxInput_DDE.Name = "textBoxInput_DDE";
            textBoxInput_DDE.Size = new Size(186, 23);
            textBoxInput_DDE.TabIndex = 4;
            // 
            // labelResult_DDE
            // 
            labelResult_DDE.AutoSize = true;
            labelResult_DDE.Location = new Point(7, 24);
            labelResult_DDE.Margin = new Padding(4, 0, 4, 0);
            labelResult_DDE.Name = "labelResult_DDE";
            labelResult_DDE.Size = new Size(63, 15);
            labelResult_DDE.TabIndex = 6;
            labelResult_DDE.Text = "Результат:";
            // 
            // textBoxResult_DDE
            // 
            textBoxResult_DDE.Location = new Point(7, 42);
            textBoxResult_DDE.Margin = new Padding(4, 3, 4, 3);
            textBoxResult_DDE.Name = "textBoxResult_DDE";
            textBoxResult_DDE.ReadOnly = true;
            textBoxResult_DDE.Size = new Size(186, 23);
            textBoxResult_DDE.TabIndex = 7;
            // 
            // buttonCalculatePush_DDE
            // 
            buttonCalculatePush_DDE.Location = new Point(244, 262);
            buttonCalculatePush_DDE.Margin = new Padding(4, 3, 4, 3);
            buttonCalculatePush_DDE.Name = "buttonCalculatePush_DDE";
            buttonCalculatePush_DDE.Size = new Size(117, 27);
            buttonCalculatePush_DDE.TabIndex = 8;
            buttonCalculatePush_DDE.Text = "Выполнить";
            buttonCalculatePush_DDE.UseVisualStyleBackColor = true;
            buttonCalculatePush_DDE.Click += buttonCalculate_Click;
            // 
            // groupBoxCondition_DDE
            // 
            groupBoxCondition_DDE.Controls.Add(labelFormula_DDE);
            groupBoxCondition_DDE.Location = new Point(12, 12);
            groupBoxCondition_DDE.Name = "groupBoxCondition_DDE";
            groupBoxCondition_DDE.Size = new Size(581, 191);
            groupBoxCondition_DDE.TabIndex = 9;
            groupBoxCondition_DDE.TabStop = false;
            groupBoxCondition_DDE.Text = "Условие";
            // 
            // groupBoxInput_DDE
            // 
            groupBoxInput_DDE.Controls.Add(labelX_DDE);
            groupBoxInput_DDE.Controls.Add(textBoxInput_DDE);
            groupBoxInput_DDE.Location = new Point(12, 220);
            groupBoxInput_DDE.Name = "groupBoxInput_DDE";
            groupBoxInput_DDE.Size = new Size(200, 100);
            groupBoxInput_DDE.TabIndex = 9;
            groupBoxInput_DDE.TabStop = false;
            groupBoxInput_DDE.Text = "Ввод данных";
            // 
            // groupBoxOutput_DDE
            // 
            groupBoxOutput_DDE.Controls.Add(textBoxResult_DDE);
            groupBoxOutput_DDE.Controls.Add(labelResult_DDE);
            groupBoxOutput_DDE.Location = new Point(393, 220);
            groupBoxOutput_DDE.Name = "groupBoxOutput_DDE";
            groupBoxOutput_DDE.RightToLeft = RightToLeft.No;
            groupBoxOutput_DDE.Size = new Size(200, 100);
            groupBoxOutput_DDE.TabIndex = 10;
            groupBoxOutput_DDE.TabStop = false;
            groupBoxOutput_DDE.Text = "Вывод данных";
            // 
            // FormMain_DDE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 335);
            Controls.Add(groupBoxOutput_DDE);
            Controls.Add(buttonCalculatePush_DDE);
            Controls.Add(groupBoxInput_DDE);
            Controls.Add(groupBoxCondition_DDE);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormMain_DDE";
            Text = "Спринт 6 | Таск 0 | Вариант 22 | Дацкий Д. Е. ";
            groupBoxCondition_DDE.ResumeLayout(false);
            groupBoxCondition_DDE.PerformLayout();
            groupBoxInput_DDE.ResumeLayout(false);
            groupBoxInput_DDE.PerformLayout();
            groupBoxOutput_DDE.ResumeLayout(false);
            groupBoxOutput_DDE.PerformLayout();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelFormula_DDE;
        private System.Windows.Forms.Label labelX_DDE;
        private System.Windows.Forms.TextBox textBoxInput_DDE;
        private System.Windows.Forms.Label labelResult_DDE;
        private System.Windows.Forms.TextBox textBoxResult_DDE;
        private System.Windows.Forms.Button buttonCalculatePush_DDE;
        private GroupBox groupBoxCondition_DDE;
        private GroupBox groupBoxInput_DDE;
        private GroupBox groupBoxOutput_DDE;
    }
}