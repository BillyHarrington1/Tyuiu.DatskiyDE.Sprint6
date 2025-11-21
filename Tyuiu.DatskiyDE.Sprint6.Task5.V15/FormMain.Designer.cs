namespace Tyuiu.DatskiyDE.Sprint6.Task5.V15
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            PanelTop_DDE = new Panel();
            LabelTitle_DDE = new Label();
            ButtonRun_DDE = new Button();
            ButtonOpenFile_DDE = new Button();
            ButtonHelp_DDE = new Button();
            TextBoxPath_DDE = new TextBox();
            LabelPath_DDE = new Label();
            DataGridViewData_DDE = new DataGridView();
            ColIndex_DDE = new DataGridViewTextBoxColumn();
            ColValue_DDE = new DataGridViewTextBoxColumn();
            Chart_DDE = new LiveCharts.WinForms.CartesianChart();
            PanelTop_DDE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewData_DDE).BeginInit();
            SuspendLayout();
            // 
            // PanelTop_DDE
            // 
            PanelTop_DDE.BackColor = Color.DimGray;
            PanelTop_DDE.Controls.Add(LabelTitle_DDE);
            PanelTop_DDE.Controls.Add(ButtonRun_DDE);
            PanelTop_DDE.Controls.Add(ButtonOpenFile_DDE);
            PanelTop_DDE.Controls.Add(ButtonHelp_DDE);
            PanelTop_DDE.Controls.Add(TextBoxPath_DDE);
            PanelTop_DDE.Controls.Add(LabelPath_DDE);
            PanelTop_DDE.Dock = DockStyle.Top;
            PanelTop_DDE.Location = new Point(0, 0);
            PanelTop_DDE.Name = "PanelTop_DDE";
            PanelTop_DDE.Size = new Size(1200, 100);
            PanelTop_DDE.TabIndex = 0;
            // 
            // LabelTitle_DDE
            // 
            LabelTitle_DDE.AutoSize = true;
            LabelTitle_DDE.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LabelTitle_DDE.Location = new Point(20, 15);
            LabelTitle_DDE.Name = "LabelTitle_DDE";
            LabelTitle_DDE.Size = new Size(668, 19);
            LabelTitle_DDE.TabIndex = 0;
            LabelTitle_DDE.Text = "Прочитать данные из файла InPutFileTask5V15.txt. Вывести в таблицу и построить диаграмму.";
            // 
            // ButtonRun_DDE
            // 
            ButtonRun_DDE.BackColor = Color.PaleGreen;
            ButtonRun_DDE.Cursor = Cursors.Hand;
            ButtonRun_DDE.FlatStyle = FlatStyle.Popup;
            ButtonRun_DDE.Location = new Point(720, 20);
            ButtonRun_DDE.Name = "ButtonRun_DDE";
            ButtonRun_DDE.Size = new Size(120, 60);
            ButtonRun_DDE.TabIndex = 4;
            ButtonRun_DDE.Text = "Выполнить";
            ButtonRun_DDE.UseVisualStyleBackColor = false;
            ButtonRun_DDE.Click += ButtonRun_DDE_Click;
            // 
            // ButtonOpenFile_DDE
            // 
            ButtonOpenFile_DDE.BackColor = Color.LightSteelBlue;
            ButtonOpenFile_DDE.Cursor = Cursors.Hand;
            ButtonOpenFile_DDE.FlatStyle = FlatStyle.Popup;
            ButtonOpenFile_DDE.Location = new Point(580, 50);
            ButtonOpenFile_DDE.Name = "ButtonOpenFile_DDE";
            ButtonOpenFile_DDE.Size = new Size(120, 26);
            ButtonOpenFile_DDE.TabIndex = 3;
            ButtonOpenFile_DDE.Text = "Открыть файл";
            ButtonOpenFile_DDE.UseVisualStyleBackColor = false;
            ButtonOpenFile_DDE.Click += ButtonOpenFile_DDE_Click;
            // 
            // ButtonHelp_DDE
            // 
            ButtonHelp_DDE.BackColor = Color.LightBlue;
            ButtonHelp_DDE.Cursor = Cursors.Hand;
            ButtonHelp_DDE.FlatStyle = FlatStyle.Popup;
            ButtonHelp_DDE.Location = new Point(850, 20);
            ButtonHelp_DDE.Name = "ButtonHelp_DDE";
            ButtonHelp_DDE.Size = new Size(120, 60);
            ButtonHelp_DDE.TabIndex = 5;
            ButtonHelp_DDE.Text = "Справка";
            ButtonHelp_DDE.UseVisualStyleBackColor = false;
            ButtonHelp_DDE.Click += ButtonHelp_DDE_Click;
            // 
            // TextBoxPath_DDE
            // 
            TextBoxPath_DDE.BackColor = SystemColors.ControlLightLight;
            TextBoxPath_DDE.BorderStyle = BorderStyle.FixedSingle;
            TextBoxPath_DDE.Location = new Point(110, 52);
            TextBoxPath_DDE.Name = "TextBoxPath_DDE";
            TextBoxPath_DDE.Size = new Size(450, 23);
            TextBoxPath_DDE.TabIndex = 2;
            // 
            // LabelPath_DDE
            // 
            LabelPath_DDE.AutoSize = true;
            LabelPath_DDE.Location = new Point(20, 55);
            LabelPath_DDE.Name = "LabelPath_DDE";
            LabelPath_DDE.Size = new Size(83, 15);
            LabelPath_DDE.TabIndex = 1;
            LabelPath_DDE.Text = "Путь к файлу:";
            // 
            // DataGridViewData_DDE
            // 
            DataGridViewData_DDE.AllowUserToAddRows = false;
            DataGridViewData_DDE.AllowUserToDeleteRows = false;
            DataGridViewData_DDE.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewData_DDE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewData_DDE.Columns.AddRange(new DataGridViewColumn[] { ColIndex_DDE, ColValue_DDE });
            DataGridViewData_DDE.Location = new Point(20, 120);
            DataGridViewData_DDE.Name = "DataGridViewData_DDE";
            DataGridViewData_DDE.ReadOnly = true;
            DataGridViewData_DDE.RowHeadersVisible = false;
            DataGridViewData_DDE.Size = new Size(250, 560);
            DataGridViewData_DDE.TabIndex = 6;
            // 
            // ColIndex_DDE
            // 
            ColIndex_DDE.HeaderText = "Index";
            ColIndex_DDE.Name = "ColIndex_DDE";
            ColIndex_DDE.ReadOnly = true;
            // 
            // ColValue_DDE
            // 
            ColValue_DDE.HeaderText = "Value";
            ColValue_DDE.Name = "ColValue_DDE";
            ColValue_DDE.ReadOnly = true;
            // 
            // Chart_DDE
            // 
            Chart_DDE.BackColor = Color.DarkSeaGreen;
            Chart_DDE.Location = new Point(300, 120);
            Chart_DDE.Name = "Chart_DDE";
            Chart_DDE.Size = new Size(880, 560);
            Chart_DDE.TabIndex = 7;
            Chart_DDE.ChildChanged += Chart_DDE_ChildChanged;
            // 
            // FormMain_DDE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(1200, 700);
            Controls.Add(Chart_DDE);
            Controls.Add(DataGridViewData_DDE);
            Controls.Add(PanelTop_DDE);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormMain_DDE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 5 | Вариант 15 | Дацкий Д. Е.";
            PanelTop_DDE.ResumeLayout(false);
            PanelTop_DDE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewData_DDE).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTop_DDE;
        private System.Windows.Forms.Label LabelTitle_DDE;
        private System.Windows.Forms.Button ButtonOpenFile_DDE;
        private System.Windows.Forms.Button ButtonRun_DDE;
        private System.Windows.Forms.Button ButtonHelp_DDE;
        private System.Windows.Forms.TextBox TextBoxPath_DDE;
        private System.Windows.Forms.Label LabelPath_DDE;
        private System.Windows.Forms.DataGridView DataGridViewData_DDE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIndex_DDE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColValue_DDE;
        private LiveCharts.WinForms.CartesianChart Chart_DDE;
    }
}
