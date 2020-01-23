namespace kTesterAdmin.View.Menu
{
    partial class CatalogMenu
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
            this.facults_metroTile = new MetroFramework.Controls.MetroTile();
            this.back_metroTile = new MetroFramework.Controls.MetroTile();
            this.subjects_metroTile = new MetroFramework.Controls.MetroTile();
            this.professors_metroTile = new MetroFramework.Controls.MetroTile();
            this.stusyGroups_metroTile = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // facults_metroTile
            // 
            this.facults_metroTile.ActiveControl = null;
            this.facults_metroTile.Location = new System.Drawing.Point(3, 3);
            this.facults_metroTile.Name = "facults_metroTile";
            this.facults_metroTile.Size = new System.Drawing.Size(105, 100);
            this.facults_metroTile.TabIndex = 4;
            this.facults_metroTile.Text = "Факультеты";
            this.facults_metroTile.TileImage = global::kTesterAdmin.Properties.Resources.faculty_white_mini;
            this.facults_metroTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.facults_metroTile.UseSelectable = true;
            this.facults_metroTile.UseTileImage = true;
            // 
            // back_metroTile
            // 
            this.back_metroTile.ActiveControl = null;
            this.back_metroTile.Location = new System.Drawing.Point(3, 427);
            this.back_metroTile.Name = "back_metroTile";
            this.back_metroTile.Size = new System.Drawing.Size(105, 100);
            this.back_metroTile.Style = MetroFramework.MetroColorStyle.Orange;
            this.back_metroTile.TabIndex = 4;
            this.back_metroTile.Text = "Назад";
            this.back_metroTile.TileImage = global::kTesterAdmin.Properties.Resources.back_white_mini;
            this.back_metroTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.back_metroTile.UseSelectable = true;
            this.back_metroTile.UseTileImage = true;
            // 
            // subjects_metroTile
            // 
            this.subjects_metroTile.ActiveControl = null;
            this.subjects_metroTile.Location = new System.Drawing.Point(3, 321);
            this.subjects_metroTile.Name = "subjects_metroTile";
            this.subjects_metroTile.Size = new System.Drawing.Size(105, 100);
            this.subjects_metroTile.TabIndex = 4;
            this.subjects_metroTile.Text = "Предметы";
            this.subjects_metroTile.TileImage = global::kTesterAdmin.Properties.Resources.subject_white_mini;
            this.subjects_metroTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.subjects_metroTile.UseSelectable = true;
            this.subjects_metroTile.UseTileImage = true;
            // 
            // professors_metroTile
            // 
            this.professors_metroTile.ActiveControl = null;
            this.professors_metroTile.Location = new System.Drawing.Point(3, 215);
            this.professors_metroTile.Name = "professors_metroTile";
            this.professors_metroTile.Size = new System.Drawing.Size(105, 100);
            this.professors_metroTile.TabIndex = 4;
            this.professors_metroTile.Text = "Преподаватели";
            this.professors_metroTile.TileImage = global::kTesterAdmin.Properties.Resources.professors_white_mini;
            this.professors_metroTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.professors_metroTile.UseSelectable = true;
            this.professors_metroTile.UseTileImage = true;
            // 
            // stusyGroups_metroTile
            // 
            this.stusyGroups_metroTile.ActiveControl = null;
            this.stusyGroups_metroTile.Location = new System.Drawing.Point(3, 109);
            this.stusyGroups_metroTile.Name = "stusyGroups_metroTile";
            this.stusyGroups_metroTile.Size = new System.Drawing.Size(105, 100);
            this.stusyGroups_metroTile.TabIndex = 4;
            this.stusyGroups_metroTile.Text = "Группы";
            this.stusyGroups_metroTile.TileImage = global::kTesterAdmin.Properties.Resources.groups_white_mini;
            this.stusyGroups_metroTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.stusyGroups_metroTile.UseSelectable = true;
            this.stusyGroups_metroTile.UseTileImage = true;
            // 
            // CatalogMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.back_metroTile);
            this.Controls.Add(this.subjects_metroTile);
            this.Controls.Add(this.professors_metroTile);
            this.Controls.Add(this.stusyGroups_metroTile);
            this.Controls.Add(this.facults_metroTile);
            this.Name = "CatalogMenu";
            this.Size = new System.Drawing.Size(110, 531);
            this.ResumeLayout(false);

        }

        #endregion

        public MetroFramework.Controls.MetroTile facults_metroTile;
        public MetroFramework.Controls.MetroTile stusyGroups_metroTile;
        public MetroFramework.Controls.MetroTile professors_metroTile;
        public MetroFramework.Controls.MetroTile subjects_metroTile;
        public MetroFramework.Controls.MetroTile back_metroTile;
    }
}
