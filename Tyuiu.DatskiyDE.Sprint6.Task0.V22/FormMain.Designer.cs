namespace Tyuiu.DatskiyDE.Sprint6.Task0.V22
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

        #region Код, автоматически созданный конструктором форм Windows

        private void InitializeComponent()
        {
            labelCondition = new Label();
            labelFormula = new Label();
            labelInput = new Label();
            labelX = new Label();
            textBoxX = new TextBox();
            labelOutput = new Label();
            labelResult = new Label();
            textBoxResult = new TextBox();
            buttonCalculate = new Button();
            SuspendLayout();
            // 
            // labelCondition
            // 
            labelCondition.AutoSize = true;
            labelCondition.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelCondition.Location = new Point(35, 23);
            labelCondition.Margin = new Padding(4, 0, 4, 0);
            labelCondition.Name = "labelCondition";
            labelCondition.Size = new Size(74, 16);
            labelCondition.TabIndex = 0;
            labelCondition.Text = "Условие:";
            // 
            // labelFormula
            // 
            labelFormula.AutoSize = true;
            labelFormula.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelFormula.Location = new Point(440, 111);
            labelFormula.Margin = new Padding(4, 0, 4, 0);
            labelFormula.Name = "labelFormula";
            labelFormula.Size = new Size(147, 20);
            labelFormula.TabIndex = 1;
            labelFormula.Text = "F(x) = 0.7x³ + 1.52x²";
            labelFormula.Click += labelFormula_Click;
            // 
            // labelInput
            // 
            labelInput.AutoSize = true;
            labelInput.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelInput.Location = new Point(35, 115);
            labelInput.Margin = new Padding(4, 0, 4, 0);
            labelInput.Name = "labelInput";
            labelInput.Size = new Size(101, 16);
            labelInput.TabIndex = 2;
            labelInput.Text = "Ввод данных";
            // 
            // labelX
            // 
            labelX.AutoSize = true;
            labelX.Location = new Point(35, 162);
            labelX.Margin = new Padding(4, 0, 4, 0);
            labelX.Name = "labelX";
            labelX.Size = new Size(89, 15);
            labelX.TabIndex = 3;
            labelX.Text = "Переменная X:";
            // 
            // textBoxX
            // 
            textBoxX.Location = new Point(140, 158);
            textBoxX.Margin = new Padding(4, 3, 4, 3);
            textBoxX.Name = "textBoxX";
            textBoxX.Size = new Size(116, 23);
            textBoxX.TabIndex = 4;
            // 
            // labelOutput
            // 
            labelOutput.AutoSize = true;
            labelOutput.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelOutput.Location = new Point(35, 231);
            labelOutput.Margin = new Padding(4, 0, 4, 0);
            labelOutput.Name = "labelOutput";
            labelOutput.Size = new Size(111, 16);
            labelOutput.TabIndex = 5;
            labelOutput.Text = "Вывод данных";
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(35, 277);
            labelResult.Margin = new Padding(4, 0, 4, 0);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(63, 15);
            labelResult.TabIndex = 6;
            labelResult.Text = "Результат:";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(140, 273);
            textBoxResult.Margin = new Padding(4, 3, 4, 3);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(116, 23);
            textBoxResult.TabIndex = 7;
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(140, 323);
            buttonCalculate.Margin = new Padding(4, 3, 4, 3);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(117, 27);
            buttonCalculate.TabIndex = 8;
            buttonCalculate.Text = "Выполнить";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(buttonCalculate);
            Controls.Add(textBoxResult);
            Controls.Add(labelResult);
            Controls.Add(labelOutput);
            Controls.Add(textBoxX);
            Controls.Add(labelX);
            Controls.Add(labelInput);
            Controls.Add(labelFormula);
            Controls.Add(labelCondition);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormMain";
            Text = "Спринт #6 | Выполнил: Дацкий Д. Е. | ИСПб-25-1";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCondition;
        private System.Windows.Forms.Label labelFormula;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonCalculate;
    }
}