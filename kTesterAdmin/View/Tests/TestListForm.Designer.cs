namespace kTesterAdmin.View.Tests
{
    partial class TestListForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.filter_metroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.info_textBox = new System.Windows.Forms.TextBox();
            this.tests_metroGrid = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.tests_metroGrid)).BeginInit();
            this.SuspendLayout();
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
            this.filter_metroTextBox.Location = new System.Drawing.Point(65, 12);
            this.filter_metroTextBox.MaxLength = 32767;
            this.filter_metroTextBox.Name = "filter_metroTextBox";
            this.filter_metroTextBox.PasswordChar = '\0';
            this.filter_metroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.filter_metroTextBox.SelectedText = "";
            this.filter_metroTextBox.SelectionLength = 0;
            this.filter_metroTextBox.SelectionStart = 0;
            this.filter_metroTextBox.ShortcutsEnabled = true;
            this.filter_metroTextBox.Size = new System.Drawing.Size(505, 23);
            this.filter_metroTextBox.TabIndex = 25;
            this.filter_metroTextBox.UseSelectable = true;
            this.filter_metroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.filter_metroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.ForeColor = System.Drawing.Color.Black;
            this.metroLabel3.Location = new System.Drawing.Point(7, 12);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(52, 19);
            this.metroLabel3.TabIndex = 24;
            this.metroLabel3.Text = "Фильтр";
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // info_textBox
            // 
            this.info_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.info_textBox.BackColor = System.Drawing.Color.White;
            this.info_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.info_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.info_textBox.Location = new System.Drawing.Point(26, 87);
            this.info_textBox.Multiline = true;
            this.info_textBox.Name = "info_textBox";
            this.info_textBox.ReadOnly = true;
            this.info_textBox.Size = new System.Drawing.Size(524, 347);
            this.info_textBox.TabIndex = 23;
            this.info_textBox.TabStop = false;
            this.info_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tests_metroGrid
            // 
            this.tests_metroGrid.AllowUserToAddRows = false;
            this.tests_metroGrid.AllowUserToDeleteRows = false;
            this.tests_metroGrid.AllowUserToResizeRows = false;
            this.tests_metroGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tests_metroGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tests_metroGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tests_metroGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tests_metroGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tests_metroGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tests_metroGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tests_metroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tests_metroGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.tests_metroGrid.EnableHeadersVisualStyles = false;
            this.tests_metroGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tests_metroGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tests_metroGrid.Location = new System.Drawing.Point(11, 45);
            this.tests_metroGrid.MultiSelect = false;
            this.tests_metroGrid.Name = "tests_metroGrid";
            this.tests_metroGrid.ReadOnly = true;
            this.tests_metroGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tests_metroGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tests_metroGrid.RowHeadersVisible = false;
            this.tests_metroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tests_metroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tests_metroGrid.Size = new System.Drawing.Size(559, 409);
            this.tests_metroGrid.TabIndex = 22;
            // 
            // TestListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.filter_metroTextBox);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.info_textBox);
            this.Controls.Add(this.tests_metroGrid);
            this.Name = "TestListForm";
            this.Size = new System.Drawing.Size(577, 466);
            this.Load += new System.EventHandler(this.TestListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tests_metroGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox filter_metroTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        public System.Windows.Forms.TextBox info_textBox;
        public MetroFramework.Controls.MetroGrid tests_metroGrid;
    }
}
