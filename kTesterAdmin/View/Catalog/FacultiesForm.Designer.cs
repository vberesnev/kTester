using System.Drawing;

namespace kTesterAdmin.View.Catalog
{
    partial class FacultiesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacultiesForm));
            this.faculties_metroGrid = new MetroFramework.Controls.MetroGrid();
            this.info_textBox = new System.Windows.Forms.TextBox();
            this.delete_metroTile = new MetroFramework.Controls.MetroTile();
            this.edit_metroTile = new MetroFramework.Controls.MetroTile();
            this.add_metroTile = new MetroFramework.Controls.MetroTile();
            this.facultyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.faculties_metroGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // faculties_metroGrid
            // 
            this.faculties_metroGrid.AllowUserToAddRows = false;
            this.faculties_metroGrid.AllowUserToDeleteRows = false;
            this.faculties_metroGrid.AllowUserToResizeRows = false;
            this.faculties_metroGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.faculties_metroGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.faculties_metroGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.faculties_metroGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.faculties_metroGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.faculties_metroGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.faculties_metroGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.faculties_metroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.faculties_metroGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.faculties_metroGrid.EnableHeadersVisualStyles = false;
            this.faculties_metroGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.faculties_metroGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.faculties_metroGrid.Location = new System.Drawing.Point(12, 119);
            this.faculties_metroGrid.MultiSelect = false;
            this.faculties_metroGrid.Name = "faculties_metroGrid";
            this.faculties_metroGrid.ReadOnly = true;
            this.faculties_metroGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.faculties_metroGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.faculties_metroGrid.RowHeadersVisible = false;
            this.faculties_metroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.faculties_metroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.faculties_metroGrid.Size = new System.Drawing.Size(559, 455);
            this.faculties_metroGrid.TabIndex = 5;
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
            // facultyBindingSource
            // 
            this.facultyBindingSource.DataSource = typeof(kTesterLib.Meta.Faculty);
            // 
            // FacultyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.info_textBox);
            this.Controls.Add(this.faculties_metroGrid);
            this.Controls.Add(this.delete_metroTile);
            this.Controls.Add(this.edit_metroTile);
            this.Controls.Add(this.add_metroTile);
            this.Name = "FacultyForm";
            this.Size = new System.Drawing.Size(584, 592);
            this.Load += new System.EventHandler(this.FacultyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.faculties_metroGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MetroFramework.Controls.MetroTile add_metroTile;
        public MetroFramework.Controls.MetroTile edit_metroTile;
        public MetroFramework.Controls.MetroTile delete_metroTile;
        private MetroFramework.Controls.MetroGrid faculties_metroGrid;
        private System.Windows.Forms.BindingSource facultyBindingSource;
        private System.Windows.Forms.TextBox info_textBox;
    }
}
