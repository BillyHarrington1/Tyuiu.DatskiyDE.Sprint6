namespace Tyuiu.DatskiyDE.Sprint6.Task7.V5
{
    partial class MainAbout
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.PictureBox pictureBox_DDE;
        private System.Windows.Forms.Label labelName_DDE;
        private System.Windows.Forms.Label labelGroup_DDE;
        private System.Windows.Forms.Button ButtonOK_DDE;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainAbout));
            pictureBox_DDE = new PictureBox();
            labelName_DDE = new Label();
            labelGroup_DDE = new Label();
            ButtonOK_DDE = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox_DDE).BeginInit();
            SuspendLayout();
            // 
            // pictureBox_DDE
            // 
            pictureBox_DDE.BorderStyle = BorderStyle.Fixed3D;
            pictureBox_DDE.Image = (Image)resources.GetObject("pictureBox_DDE.Image");
            pictureBox_DDE.Location = new Point(10, 10);
            pictureBox_DDE.Name = "pictureBox_DDE";
            pictureBox_DDE.Size = new Size(140, 160);
            pictureBox_DDE.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_DDE.TabIndex = 0;
            pictureBox_DDE.TabStop = false;
            // 
            // labelName_DDE
            // 
            labelName_DDE.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelName_DDE.AutoSize = true;
            labelName_DDE.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelName_DDE.Location = new Point(156, 9);
            labelName_DDE.Name = "labelName_DDE";
            labelName_DDE.Size = new Size(214, 21);
            labelName_DDE.TabIndex = 1;
            labelName_DDE.Text = "Разработчик: Дацкий Д.Е.";
            // 
            // labelGroup_DDE
            // 
            labelGroup_DDE.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelGroup_DDE.AutoSize = true;
            labelGroup_DDE.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelGroup_DDE.Location = new Point(156, 45);
            labelGroup_DDE.Name = "labelGroup_DDE";
            labelGroup_DDE.Size = new Size(276, 75);
            labelGroup_DDE.TabIndex = 2;
            labelGroup_DDE.Text = "Группа: ИСПб-25-1\r\nПрограмма разработана в рамках изучения С#\r\n@ТИУ 2025. @ВШЦТ 2025\r\nВнутренний ник: Tyuiu.DatskiyDE.Sprint6.Task7\r\n\r\n";
            // 
            // ButtonOK_DDE
            // 
            ButtonOK_DDE.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ButtonOK_DDE.AutoSize = true;
            ButtonOK_DDE.BackColor = Color.SeaGreen;
            ButtonOK_DDE.Cursor = Cursors.Hand;
            ButtonOK_DDE.FlatStyle = FlatStyle.Flat;
            ButtonOK_DDE.Location = new Point(156, 132);
            ButtonOK_DDE.Name = "ButtonOK_DDE";
            ButtonOK_DDE.Size = new Size(332, 30);
            ButtonOK_DDE.TabIndex = 3;
            ButtonOK_DDE.Text = "ОК";
            ButtonOK_DDE.UseVisualStyleBackColor = false;
            ButtonOK_DDE.Click += ButtonOK_DDE_Click;
            // 
            // MainAbout
            // 
            AutoScroll = true;
            AutoSize = true;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(500, 174);
            Controls.Add(pictureBox_DDE);
            Controls.Add(labelName_DDE);
            Controls.Add(labelGroup_DDE);
            Controls.Add(ButtonOK_DDE);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "MainAbout";
            StartPosition = FormStartPosition.CenterParent;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBox_DDE).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
