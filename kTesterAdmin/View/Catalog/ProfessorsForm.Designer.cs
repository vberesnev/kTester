using System.Drawing;

namespace kTesterAdmin.View.Catalog
{
    partial class ProfessorsForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfessorsForm));
            this.professors_metroGrid = new MetroFramework.Controls.MetroGrid();
            this.info_textBox = new System.Windows.Forms.TextBox();
            this.delete_metroTile = new MetroFramework.Controls.MetroTile();
            this.edit_metroTile = new MetroFramework.Controls.MetroTile();
            this.add_metroTile = new MetroFramework.Controls.MetroTile();
            this.filter_metroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.facultyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.professors_metroGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // professors_metroGrid
            // 
            this.professors_metroGrid.AllowUserToAddRows = false;
            this.professors_metroGrid.AllowUserToDeleteRows = false;
            this.professors_metroGrid.AllowUserToResizeRows = false;
            this.professors_metroGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.professors_metroGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.professors_metroGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.professors_metroGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.professors_metroGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.professors_metroGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.professors_metroGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.professors_metroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.professors_metroGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.professors_metroGrid.EnableHeadersVisualStyles = false;
            this.professors_metroGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.professors_metroGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.professors_metroGrid.Location = new System.Drawing.Point(12, 165);
            this.professors_metroGrid.MultiSelect = false;
            this.professors_metroGrid.Name = "professors_metroGrid";
            this.professors_metroGrid.ReadOnly = true;
            this.professors_metroGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.professors_metroGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.professors_metroGrid.RowHeadersVisible = false;
            this.professors_metroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.professors_metroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.professors_metroGrid.Size = new System.Drawing.Size(559, 409);
            this.professors_metroGrid.TabIndex = 5;
            // 
            // info_textBox
            // 
            this.info_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.info_textBox.BackColor = System.Drawing.Color.White;
            this.info_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.info_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.info_textBox.Location = new System.Drawing.Point(27, 250);
            this.info_textBox.Multiline = true;
            this.info_textBox.Name = "info_textBox";
            this.info_textBox.ReadOnly = true;
            this.info_textBox.Size = new System.Drawing.Size(524, 282);
            this.info_textBox.TabIndex = 7;
            this.info_textBox.TabStop = false;
            this.info_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // delete_metroTile
            // 
            this.delete_metroTile.ActiveControl = null;
            this.delete_metroTile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delete_metroTile.Location = new System.Drawing.Point(466, 3);
            this.delete_metroTile.Name = "delete_metroTile";
            this.delete_metroTile.Size = new System.Drawing.Size(105, 100);
            this.delete_metroTile.Style = MetroFramework.MetroColorStyle.Red;
            this.delete_metroTile.TabIndex = 4;
            this.delete_metroTile.Text = "Удалить";
            this.delete_metroTile.TileImage = global::kTesterAdmin.Properties.Resources.delete_white_mini;
            this.delete_metroTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.delete_metroTile.UseSelectable = true;
            this.delete_metroTile.UseTileImage = true;
            this.delete_metroTile.Click += new System.EventHandler(this.delete_metroTile_Click);
            // 
            // edit_metroTile
            // 
            this.edit_metroTile.ActiveControl = null;
            this.edit_metroTile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.edit_metroTile.Location = new System.Drawing.Point(355, 3);
            this.edit_metroTile.Name = "edit_metroTile";
            this.edit_metroTile.Size = new System.Drawing.Size(105, 100);
            this.edit_metroTile.TabIndex = 4;
            this.edit_metroTile.Text = "Править";
            this.edit_metroTile.TileImage = global::kTesterAdmin.Properties.Resources.edit_white_mini;
            this.edit_metroTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.edit_metroTile.UseSelectable = true;
            this.edit_metroTile.UseTileImage = true;
            this.edit_metroTile.Click += new System.EventHandler(this.edit_metroTile_Click);
            // 
            // add_metroTile
            // 
            this.add_metroTile.ActiveControl = null;
            this.add_metroTile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.add_metroTile.Location = new System.Drawing.Point(244, 3);
            this.add_metroTile.Name = "add_metroTile";
            this.add_metroTile.Size = new System.Drawing.Size(105, 100);
            this.add_metroTile.TabIndex = 4;
            this.add_metroTile.Text = "Добавить";
            this.add_metroTile.TileImage = ((System.Drawing.Image)(resources.GetObject("add_metroTile.TileImage")));
            this.add_metroTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.add_metroTile.UseSelectable = true;
            this.add_metroTile.UseTileImage = true;
            this.add_metroTile.Click += new System.EventHandler(this.add_metroTile_Click);
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
            this.filter_metroTextBox.Location = new System.Drawing.Point(66, 125);
            this.filter_metroTextBox.MaxLength = 32767;
            this.filter_metroTextBox.Name = "filter_metroTextBox";
            this.filter_metroTextBox.PasswordChar = '\0';
            this.filter_metroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.filter_metroTextBox.SelectedText = "";
            this.filter_metroTextBox.SelectionLength = 0;
            this.filter_metroTextBox.SelectionStart = 0;
            this.filter_metroTextBox.ShortcutsEnabled = true;
            this.filter_metroTextBox.Size = new System.Drawing.Size(505, 23);
            this.filter_metroTextBox.TabIndex = 15;
            this.filter_metroTextBox.UseSelectable = true;
            this.filter_metroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.filter_metroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.filter_metroTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.filter_metroTextBox_KeyUp);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.ForeColor = System.Drawing.Color.Black;
            this.metroLabel3.Location = new System.Drawing.Point(8, 125);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(52, 19);
            this.metroLabel3.TabIndex = 14;
            this.metroLabel3.Text = "Фильтр";
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // facultyBindingSource
            // 
            this.facultyBindingSource.DataSource = typeof(kTesterLib.Meta.Faculty);
            // 
            // ProfessorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.filter_metroTextBox);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.info_textBox);
            this.Controls.Add(this.professors_metroGrid);
            this.Controls.Add(this.delete_metroTile);
            this.Controls.Add(this.edit_metroTile);
            this.Controls.Add(this.add_metroTile);
            this.Name = "ProfessorsForm";
            this.Size = new System.Drawing.Size(584, 592);
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.professors_metroGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MetroFramework.Controls.MetroTile add_metroTile;
        public MetroFramework.Controls.MetroTile edit_metroTile;
        public MetroFramework.Controls.MetroTile delete_metroTile;
        private MetroFramework.Controls.MetroGrid professors_metroGrid;
        private System.Windows.Forms.BindingSource facultyBindingSource;
        private System.Windows.Forms.TextBox info_textBox;
        private MetroFramework.Controls.MetroTextBox filter_metroTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}
