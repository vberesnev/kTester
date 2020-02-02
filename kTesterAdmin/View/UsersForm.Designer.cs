namespace kTesterAdmin.View
{
    partial class UsersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.delete_metroTile = new MetroFramework.Controls.MetroTile();
            this.edit_metroTile = new MetroFramework.Controls.MetroTile();
            this.add_metroTile = new MetroFramework.Controls.MetroTile();
            this.info_textBox = new System.Windows.Forms.TextBox();
            this.users_metroGrid = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.users_metroGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // delete_metroTile
            // 
            this.delete_metroTile.ActiveControl = null;
            this.delete_metroTile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delete_metroTile.Location = new System.Drawing.Point(466, 3);
            this.delete_metroTile.Name = "delete_metroTile";
            this.delete_metroTile.Size = new System.Drawing.Size(105, 100);
            this.delete_metroTile.Style = MetroFramework.MetroColorStyle.Red;
            this.delete_metroTile.TabIndex = 5;
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
            this.edit_metroTile.TabIndex = 6;
            this.edit_metroTile.Text = "Править";
            this.edit_metroTile.TileImage = global::kTesterAdmin.Properties.Resources.edit_white_mini;
            this.edit_metroTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.edit_metroTile.UseSelectable = true;
            this.edit_metroTile.UseTileImage = true;
            // 
            // add_metroTile
            // 
            this.add_metroTile.ActiveControl = null;
            this.add_metroTile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.add_metroTile.Location = new System.Drawing.Point(244, 3);
            this.add_metroTile.Name = "add_metroTile";
            this.add_metroTile.Size = new System.Drawing.Size(105, 100);
            this.add_metroTile.TabIndex = 7;
            this.add_metroTile.Text = "Добавить";
            this.add_metroTile.TileImage = ((System.Drawing.Image)(resources.GetObject("add_metroTile.TileImage")));
            this.add_metroTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.add_metroTile.UseSelectable = true;
            this.add_metroTile.UseTileImage = true;
            // 
            // info_textBox
            // 
            this.info_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.info_textBox.BackColor = System.Drawing.Color.White;
            this.info_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.info_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.info_textBox.Location = new System.Drawing.Point(27, 188);
            this.info_textBox.Multiline = true;
            this.info_textBox.Name = "info_textBox";
            this.info_textBox.ReadOnly = true;
            this.info_textBox.Size = new System.Drawing.Size(524, 347);
            this.info_textBox.TabIndex = 9;
            this.info_textBox.TabStop = false;
            this.info_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // users_metroGrid
            // 
            this.users_metroGrid.AllowUserToAddRows = false;
            this.users_metroGrid.AllowUserToDeleteRows = false;
            this.users_metroGrid.AllowUserToResizeRows = false;
            this.users_metroGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.users_metroGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.users_metroGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.users_metroGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.users_metroGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.users_metroGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.users_metroGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.users_metroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.users_metroGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.users_metroGrid.EnableHeadersVisualStyles = false;
            this.users_metroGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.users_metroGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.users_metroGrid.Location = new System.Drawing.Point(12, 122);
            this.users_metroGrid.MultiSelect = false;
            this.users_metroGrid.Name = "users_metroGrid";
            this.users_metroGrid.ReadOnly = true;
            this.users_metroGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.users_metroGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.users_metroGrid.RowHeadersVisible = false;
            this.users_metroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.users_metroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.users_metroGrid.Size = new System.Drawing.Size(559, 455);
            this.users_metroGrid.TabIndex = 8;
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.info_textBox);
            this.Controls.Add(this.users_metroGrid);
            this.Controls.Add(this.delete_metroTile);
            this.Controls.Add(this.edit_metroTile);
            this.Controls.Add(this.add_metroTile);
            this.Name = "UsersForm";
            this.Size = new System.Drawing.Size(584, 592);
            this.Load += new System.EventHandler(this.UsersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.users_metroGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MetroFramework.Controls.MetroTile delete_metroTile;
        public MetroFramework.Controls.MetroTile edit_metroTile;
        public MetroFramework.Controls.MetroTile add_metroTile;
        private System.Windows.Forms.TextBox info_textBox;
        private MetroFramework.Controls.MetroGrid users_metroGrid;
    }
}
