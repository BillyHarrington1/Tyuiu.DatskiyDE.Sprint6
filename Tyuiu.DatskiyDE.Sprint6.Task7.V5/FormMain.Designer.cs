namespace Tyuiu.DatskiyDE.Sprint6.Task7.V5
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator_DDE;

        private System.Windows.Forms.SplitContainer splitContainer_DDE;
        private System.Windows.Forms.DataGridView DataGridViewInput_DDE;
        private System.Windows.Forms.DataGridView DataGridViewOutput_DDE;
        private System.Windows.Forms.Label labelTask_DDE;

        private System.Windows.Forms.OpenFileDialog openFileDialog_DDE;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_DDE;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            toolStripSeparator_DDE = new ToolStripSeparator();
            splitContainer_DDE = new SplitContainer();
            DataGridViewInput_DDE = new DataGridView();
            DataGridViewOutput_DDE = new DataGridView();
            labelTask_DDE = new Label();
            openFileDialog_DDE = new OpenFileDialog();
            saveFileDialog_DDE = new SaveFileDialog();
            buttonRun_ToolStripButton_DDE = new ToolStripButton();
            buttonSave_ToolStripButton_DDE = new ToolStripButton();
            buttonAbout_ToolStripButton_DDE = new ToolStripButton();
            buttonOpen_ToolStripButton_DDE = new ToolStripButton();
            toolStrip_DDE = new ToolStrip();
            TextBoxPath_DDE = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer_DDE).BeginInit();
            splitContainer_DDE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewInput_DDE).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewOutput_DDE).BeginInit();
            toolStrip_DDE.SuspendLayout();
            SuspendLayout();
            // 
            // toolStripSeparator_DDE
            // 
            toolStripSeparator_DDE.Name = "toolStripSeparator_DDE";
            toolStripSeparator_DDE.Size = new Size(6, 6);
            // 
            // splitContainer_DDE
            // 
            splitContainer_DDE.Location = new Point(5, 2000);
            splitContainer_DDE.Name = "splitContainer_DDE";
            // 
            // splitContainer_DDE.Panel1
            // 
            splitContainer_DDE.Panel1.AccessibleRole = AccessibleRole.None;
            splitContainer_DDE.Panel1.AutoScroll = true;
            splitContainer_DDE.Size = new Size(960, 500);
            splitContainer_DDE.SplitterDistance = 320;
            splitContainer_DDE.TabIndex = 0;
            // 
            // DataGridViewInput_DDE
            // 
            DataGridViewInput_DDE.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DataGridViewInput_DDE.BackgroundColor = Color.RosyBrown;
            DataGridViewInput_DDE.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            DataGridViewInput_DDE.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            DataGridViewInput_DDE.Location = new Point(12, 176);
            DataGridViewInput_DDE.Name = "DataGridViewInput_DDE";
            DataGridViewInput_DDE.Size = new Size(343, 423);
            DataGridViewInput_DDE.TabIndex = 0;
            // 
            // DataGridViewOutput_DDE
            // 
            DataGridViewOutput_DDE.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DataGridViewOutput_DDE.BackgroundColor = Color.RosyBrown;
            DataGridViewOutput_DDE.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            DataGridViewOutput_DDE.Location = new Point(361, 176);
            DataGridViewOutput_DDE.Name = "DataGridViewOutput_DDE";
            DataGridViewOutput_DDE.Size = new Size(352, 423);
            DataGridViewOutput_DDE.TabIndex = 0;
            // 
            // labelTask_DDE
            // 
            labelTask_DDE.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelTask_DDE.ForeColor = Color.Yellow;
            labelTask_DDE.Location = new Point(0, 77);
            labelTask_DDE.Name = "labelTask_DDE";
            labelTask_DDE.Size = new Size(725, 96);
            labelTask_DDE.TabIndex = 2;
            labelTask_DDE.Text = resources.GetString("labelTask_DDE.Text");
            // 
            // buttonRun_ToolStripButton_DDE
            // 
            buttonRun_ToolStripButton_DDE.DisplayStyle = ToolStripItemDisplayStyle.Image;
            buttonRun_ToolStripButton_DDE.Image = (Image)resources.GetObject("buttonRun_ToolStripButton_DDE.Image");
            buttonRun_ToolStripButton_DDE.Name = "buttonRun_ToolStripButton_DDE";
            buttonRun_ToolStripButton_DDE.Size = new Size(76, 76);
            buttonRun_ToolStripButton_DDE.Text = "Выполнить";
            buttonRun_ToolStripButton_DDE.Click += ButtonRun_DDE_Click;
            // 
            // buttonSave_ToolStripButton_DDE
            // 
            buttonSave_ToolStripButton_DDE.BackgroundImageLayout = ImageLayout.None;
            buttonSave_ToolStripButton_DDE.DisplayStyle = ToolStripItemDisplayStyle.Image;
            buttonSave_ToolStripButton_DDE.Image = Properties.Resources.icons8_сохранить_80;
            buttonSave_ToolStripButton_DDE.Name = "buttonSave_ToolStripButton_DDE";
            buttonSave_ToolStripButton_DDE.Size = new Size(76, 76);
            buttonSave_ToolStripButton_DDE.Text = "Сохранить";
            buttonSave_ToolStripButton_DDE.Click += ButtonSave_DDE_Click;
            // 
            // buttonAbout_ToolStripButton_DDE
            // 
            buttonAbout_ToolStripButton_DDE.Alignment = ToolStripItemAlignment.Right;
            buttonAbout_ToolStripButton_DDE.DisplayStyle = ToolStripItemDisplayStyle.Image;
            buttonAbout_ToolStripButton_DDE.Image = (Image)resources.GetObject("buttonAbout_ToolStripButton_DDE.Image");
            buttonAbout_ToolStripButton_DDE.Name = "buttonAbout_ToolStripButton_DDE";
            buttonAbout_ToolStripButton_DDE.Size = new Size(76, 76);
            buttonAbout_ToolStripButton_DDE.Text = "?";
            buttonAbout_ToolStripButton_DDE.Click += ButtonAbout_DDE_Click;
            // 
            // buttonOpen_ToolStripButton_DDE
            // 
            buttonOpen_ToolStripButton_DDE.DisplayStyle = ToolStripItemDisplayStyle.Image;
            buttonOpen_ToolStripButton_DDE.Image = Properties.Resources.icons8_открыть_папку_100;
            buttonOpen_ToolStripButton_DDE.Name = "buttonOpen_ToolStripButton_DDE";
            buttonOpen_ToolStripButton_DDE.Size = new Size(76, 76);
            buttonOpen_ToolStripButton_DDE.Text = "Открыть";
            buttonOpen_ToolStripButton_DDE.Click += ButtonOpenFile_DDE_Click;
            // 
            // toolStrip_DDE
            // 
            toolStrip_DDE.BackColor = Color.IndianRed;
            toolStrip_DDE.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip_DDE.ImageScalingSize = new Size(72, 72);
            toolStrip_DDE.Items.AddRange(new ToolStripItem[] { buttonRun_ToolStripButton_DDE, buttonSave_ToolStripButton_DDE, buttonAbout_ToolStripButton_DDE, buttonOpen_ToolStripButton_DDE });
            toolStrip_DDE.Location = new Point(0, 0);
            toolStrip_DDE.Name = "toolStrip_DDE";
            toolStrip_DDE.RenderMode = ToolStripRenderMode.System;
            toolStrip_DDE.RightToLeft = RightToLeft.No;
            toolStrip_DDE.Size = new Size(725, 79);
            toolStrip_DDE.TabIndex = 3;
            // 
            // TextBoxPath_DDE
            // 
            TextBoxPath_DDE.BackColor = SystemColors.ActiveBorder;
            TextBoxPath_DDE.BorderStyle = BorderStyle.FixedSingle;
            TextBoxPath_DDE.Location = new Point(10, 605);
            TextBoxPath_DDE.Name = "TextBoxPath_DDE";
            TextBoxPath_DDE.ReadOnly = true;
            TextBoxPath_DDE.Size = new Size(703, 23);
            TextBoxPath_DDE.TabIndex = 1;
            // 
            // FormMain
            // 
            BackColor = Color.IndianRed;
            ClientSize = new Size(725, 640);
            Controls.Add(DataGridViewOutput_DDE);
            Controls.Add(DataGridViewInput_DDE);
            Controls.Add(splitContainer_DDE);
            Controls.Add(TextBoxPath_DDE);
            Controls.Add(labelTask_DDE);
            Controls.Add(toolStrip_DDE);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 7 | Вариант 5 | Дацкий Д.Е.";
            ((System.ComponentModel.ISupportInitialize)splitContainer_DDE).EndInit();
            splitContainer_DDE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridViewInput_DDE).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewOutput_DDE).EndInit();
            toolStrip_DDE.ResumeLayout(false);
            toolStrip_DDE.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        private ToolStripButton buttonRun_ToolStripButton_DDE;
        private ToolStripButton buttonSave_ToolStripButton_DDE;
        private ToolStripButton buttonAbout_ToolStripButton_DDE;
        private ToolStripButton buttonOpen_ToolStripButton_DDE;
        private ToolStrip toolStrip_DDE;
        private TextBox TextBoxPath_DDE;
    }
}
