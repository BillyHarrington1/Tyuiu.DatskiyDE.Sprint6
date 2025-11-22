namespace Tyuiu.DatskiyDE.Sprint6.Task6.V23
{
    partial class FormAbout
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
            labelAbout_DDE = new Label();
            buttonOK_DDE = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelAbout_DDE
            // 
            labelAbout_DDE.AutoSize = true;
            labelAbout_DDE.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelAbout_DDE.Location = new Point(442, 461);
            labelAbout_DDE.Name = "labelAbout_DDE";
            labelAbout_DDE.Size = new Size(0, 17);
            labelAbout_DDE.TabIndex = 0;
            // 
            // buttonOK_DDE
            // 
            buttonOK_DDE.BackColor = Color.IndianRed;
            buttonOK_DDE.Cursor = Cursors.Hand;
            buttonOK_DDE.FlatStyle = FlatStyle.Flat;
            buttonOK_DDE.Location = new Point(12, 464);
            buttonOK_DDE.Name = "buttonOK_DDE";
            buttonOK_DDE.Size = new Size(760, 30);
            buttonOK_DDE.TabIndex = 1;
            buttonOK_DDE.Text = "OK";
            buttonOK_DDE.UseVisualStyleBackColor = false;
            buttonOK_DDE.Click += buttonOK_DDE_Click;
            buttonOK_DDE.MouseEnter += buttonOK_DDE_MouseEnter;
            buttonOK_DDE.MouseLeave += buttonOK_DDE_MouseLeave;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources._47c14f11524991cbf3e05f7937f6dd53;
            pictureBox1.Location = new Point(-3, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(788, 458);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(784, 501);
            Controls.Add(pictureBox1);
            Controls.Add(buttonOK_DDE);
            Controls.Add(labelAbout_DDE);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterParent;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAbout_DDE;
        private System.Windows.Forms.Button buttonOK_DDE;
        private PictureBox pictureBox1;
    }
}