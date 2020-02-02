namespace kTesterAdmin.View
{
    partial class LogsForm
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.logs_metroGrid = new MetroFramework.Controls.MetroGrid();
            this.info_textBox = new System.Windows.Forms.TextBox();
            this.metroDateTime = new MetroFramework.Controls.MetroDateTime();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.search_metroPanel = new MetroFramework.Controls.MetroPanel();
            this.searchText_metroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.users_metroComboBox = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.search_metroRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.filter_metroTextBox = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.logs_metroGrid)).BeginInit();
            this.search_metroPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // logs_metroGrid
            // 
            this.logs_metroGrid.AllowUserToAddRows = false;
            this.logs_metroGrid.AllowUserToDeleteRows = false;
            this.logs_metroGrid.AllowUserToResizeRows = false;
            this.logs_metroGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logs_metroGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.logs_metroGrid.BackgroundColor = System.Drawing.Color.White;
            this.logs_metroGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logs_metroGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.logs_metroGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.logs_metroGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.logs_metroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.logs_metroGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.logs_metroGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.logs_metroGrid.EnableHeadersVisualStyles = false;
            this.logs_metroGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.logs_metroGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.logs_metroGrid.Location = new System.Drawing.Point(13, 169);
            this.logs_metroGrid.MultiSelect = false;
            this.logs_metroGrid.Name = "logs_metroGrid";
            this.logs_metroGrid.ReadOnly = true;
            this.logs_metroGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.logs_metroGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.logs_metroGrid.RowHeadersVisible = false;
            this.logs_metroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.logs_metroGrid.RowTemplate.Height = 14;
            this.logs_metroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.logs_metroGrid.Size = new System.Drawing.Size(559, 410);
            this.logs_metroGrid.TabIndex = 6;
            // 
            // info_textBox
            // 
            this.info_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.info_textBox.BackColor = System.Drawing.Color.White;
            this.info_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.info_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.info_textBox.Location = new System.Drawing.Point(27, 185);
            this.info_textBox.Multiline = true;
            this.info_textBox.Name = "info_textBox";
            this.info_textBox.ReadOnly = true;
            this.info_textBox.Size = new System.Drawing.Size(524, 347);
            this.info_textBox.TabIndex = 8;
            this.info_textBox.TabStop = false;
            this.info_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metroDateTime
            // 
            this.metroDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroDateTime.Location = new System.Drawing.Point(369, 14);
            this.metroDateTime.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime.Name = "metroDateTime";
            this.metroDateTime.Size = new System.Drawing.Size(200, 29);
            this.metroDateTime.TabIndex = 9;
            this.metroDateTime.ValueChanged += new System.EventHandler(this.metroDateTime_ValueChanged);
            // 
            // metroButton1
            // 
            this.metroButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton1.Location = new System.Drawing.Point(491, 41);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 10;
            this.metroButton1.Text = "Искать";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // search_metroPanel
            // 
            this.search_metroPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.search_metroPanel.Controls.Add(this.searchText_metroTextBox);
            this.search_metroPanel.Controls.Add(this.users_metroComboBox);
            this.search_metroPanel.Controls.Add(this.metroButton1);
            this.search_metroPanel.Controls.Add(this.metroLabel2);
            this.search_metroPanel.Controls.Add(this.metroLabel1);
            this.search_metroPanel.Enabled = false;
            this.search_metroPanel.HorizontalScrollbarBarColor = true;
            this.search_metroPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.search_metroPanel.HorizontalScrollbarSize = 10;
            this.search_metroPanel.Location = new System.Drawing.Point(3, 49);
            this.search_metroPanel.Name = "search_metroPanel";
            this.search_metroPanel.Size = new System.Drawing.Size(569, 73);
            this.search_metroPanel.TabIndex = 11;
            this.search_metroPanel.VerticalScrollbarBarColor = true;
            this.search_metroPanel.VerticalScrollbarHighlightOnWheel = false;
            this.search_metroPanel.VerticalScrollbarSize = 10;
            // 
            // searchText_metroTextBox
            // 
            this.searchText_metroTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchText_metroTextBox.BackColor = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            this.searchText_metroTextBox.CustomButton.Image = null;
            this.searchText_metroTextBox.CustomButton.Location = new System.Drawing.Point(198, 1);
            this.searchText_metroTextBox.CustomButton.Name = "";
            this.searchText_metroTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.searchText_metroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.searchText_metroTextBox.CustomButton.TabIndex = 1;
            this.searchText_metroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.searchText_metroTextBox.CustomButton.UseSelectable = true;
            this.searchText_metroTextBox.CustomButton.Visible = false;
            this.searchText_metroTextBox.Lines = new string[0];
            this.searchText_metroTextBox.Location = new System.Drawing.Point(346, 12);
            this.searchText_metroTextBox.MaxLength = 32767;
            this.searchText_metroTextBox.Name = "searchText_metroTextBox";
            this.searchText_metroTextBox.PasswordChar = '\0';
            this.searchText_metroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchText_metroTextBox.SelectedText = "";
            this.searchText_metroTextBox.SelectionLength = 0;
            this.searchText_metroTextBox.SelectionStart = 0;
            this.searchText_metroTextBox.ShortcutsEnabled = true;
            this.searchText_metroTextBox.Size = new System.Drawing.Size(220, 23);
            this.searchText_metroTextBox.TabIndex = 5;
            this.searchText_metroTextBox.UseCustomBackColor = true;
            this.searchText_metroTextBox.UseSelectable = true;
            this.searchText_metroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchText_metroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // users_metroComboBox
            // 
            this.users_metroComboBox.BackColor = System.Drawing.Color.LightGray;
            this.users_metroComboBox.FormattingEnabled = true;
            this.users_metroComboBox.ItemHeight = 23;
            this.users_metroComboBox.Location = new System.Drawing.Point(98, 8);
            this.users_metroComboBox.Name = "users_metroComboBox";
            this.users_metroComboBox.Size = new System.Drawing.Size(183, 29);
            this.users_metroComboBox.TabIndex = 4;
            this.users_metroComboBox.UseCustomBackColor = true;
            this.users_metroComboBox.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.White;
            this.metroLabel2.ForeColor = System.Drawing.Color.LightGray;
            this.metroLabel2.Location = new System.Drawing.Point(300, 12);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(40, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Текст";
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.ForeColor = System.Drawing.Color.LightGray;
            this.metroLabel1.Location = new System.Drawing.Point(3, 12);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(92, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Пользователь";
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // search_metroRadioButton
            // 
            this.search_metroRadioButton.AutoCheck = false;
            this.search_metroRadioButton.AutoSize = true;
            this.search_metroRadioButton.Location = new System.Drawing.Point(13, 28);
            this.search_metroRadioButton.Name = "search_metroRadioButton";
            this.search_metroRadioButton.Size = new System.Drawing.Size(58, 15);
            this.search_metroRadioButton.TabIndex = 12;
            this.search_metroRadioButton.Text = "Поиск";
            this.search_metroRadioButton.UseSelectable = true;
            this.search_metroRadioButton.CheckedChanged += new System.EventHandler(this.search_metroRadioButton_CheckedChanged);
            this.search_metroRadioButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.search_metroRadioButton_MouseClick);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.ForeColor = System.Drawing.Color.Black;
            this.metroLabel3.Location = new System.Drawing.Point(6, 134);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(52, 19);
            this.metroLabel3.TabIndex = 11;
            this.metroLabel3.Text = "Фильтр";
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // filter_metroTextBox
            // 
            this.filter_metroTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.filter_metroTextBox.CustomButton.Image = null;
            this.filter_metroTextBox.CustomButton.Location = new System.Drawing.Point(483, 1);
            this.filter_metroTextBox.CustomButton.Name = "";
            this.filter_metroTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.filter_metroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.filter_metroTextBox.CustomButton.TabIndex = 1;
            this.filter_metroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.filter_metroTextBox.CustomButton.UseSelectable = true;
            this.filter_metroTextBox.CustomButton.Visible = false;
            this.filter_metroTextBox.Lines = new string[0];
            this.filter_metroTextBox.Location = new System.Drawing.Point(64, 134);
            this.filter_metroTextBox.MaxLength = 32767;
            this.filter_metroTextBox.Name = "filter_metroTextBox";
            this.filter_metroTextBox.PasswordChar = '\0';
            this.filter_metroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.filter_metroTextBox.SelectedText = "";
            this.filter_metroTextBox.SelectionLength = 0;
            this.filter_metroTextBox.SelectionStart = 0;
            this.filter_metroTextBox.ShortcutsEnabled = true;
            this.filter_metroTextBox.Size = new System.Drawing.Size(505, 23);
            this.filter_metroTextBox.TabIndex = 13;
            this.filter_metroTextBox.UseSelectable = true;
            this.filter_metroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.filter_metroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.filter_metroTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.filter_metroTextBox_KeyUp);
            // 
            // LogsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.filter_metroTextBox);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.search_metroRadioButton);
            this.Controls.Add(this.search_metroPanel);
            this.Controls.Add(this.metroDateTime);
            this.Controls.Add(this.info_textBox);
            this.Controls.Add(this.logs_metroGrid);
            this.Name = "LogsForm";
            this.Size = new System.Drawing.Size(584, 592);
            this.Load += new System.EventHandler(this.LogsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logs_metroGrid)).EndInit();
            this.search_metroPanel.ResumeLayout(false);
            this.search_metroPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid logs_metroGrid;
        private System.Windows.Forms.TextBox info_textBox;
        private MetroFramework.Controls.MetroDateTime metroDateTime;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroPanel search_metroPanel;
        private MetroFramework.Controls.MetroTextBox searchText_metroTextBox;
        private MetroFramework.Controls.MetroComboBox users_metroComboBox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroRadioButton search_metroRadioButton;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox filter_metroTextBox;
    }
}
