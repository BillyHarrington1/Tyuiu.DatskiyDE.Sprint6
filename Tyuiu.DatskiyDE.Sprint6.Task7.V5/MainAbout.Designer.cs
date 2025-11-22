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
            pictureBox_DDE = new System.Windows.Forms.PictureBox();
            labelName_DDE = new System.Windows.Forms.Label();
            labelGroup_DDE = new System.Windows.Forms.Label();
            ButtonOK_DDE = new System.Windows.Forms.Button();

            SuspendLayout();
            //
            // pictureBox_DDE
            //
            pictureBox_DDE.Location = new System.Drawing.Point(10, 10);
            pictureBox_DDE.Size = new System.Drawing.Size(140, 160);
            pictureBox_DDE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox_DDE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            //
            // labelName_DDE
            //
            labelName_DDE.Text = "Разработчик: Дацкий Д.Е.";
            labelName_DDE.Location = new System.Drawing.Point(170, 20);
            labelName_DDE.Size = new System.Drawing.Size(300, 25);
            //
            // labelGroup_DDE
            //
            labelGroup_DDE.Text = "Группа: ХХХХ-XX-X";
            labelGroup_DDE.Location = new System.Drawing.Point(170, 50);
            labelGroup_DDE.Size = new System.Drawing.Size(250, 25);
            //
            // ButtonOK_DDE
            //
            ButtonOK_DDE.Text = "ОК";
            ButtonOK_DDE.Location = new System.Drawing.Point(380, 140);
            ButtonOK_DDE.Size = new System.Drawing.Size(100, 30);
            ButtonOK_DDE.Click += ButtonOK_DDE_Click;
            //
            // MainAbout
            //
            ClientSize = new System.Drawing.Size(500, 190);
            Controls.Add(pictureBox_DDE);
            Controls.Add(labelName_DDE);
            Controls.Add(labelGroup_DDE);
            Controls.Add(ButtonOK_DDE);

            Text = "О программе";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;

            ResumeLayout(false);
        }
    }
}
