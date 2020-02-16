namespace kTesterAdmin.View.Menu
{
    partial class AdminMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMenu));
            this.tests_metroTile = new MetroFramework.Controls.MetroTile();
            this.catalogs_metroTile = new MetroFramework.Controls.MetroTile();
            this.logs_metroTile = new MetroFramework.Controls.MetroTile();
            this.users_metroTile = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // tests_metroTile
            // 
            this.tests_metroTile.ActiveControl = null;
            this.tests_metroTile.Location = new System.Drawing.Point(3, 3);
            this.tests_metroTile.Name = "tests_metroTile";
            this.tests_metroTile.Size = new System.Drawing.Size(105, 100);
            this.tests_metroTile.TabIndex = 3;
            this.tests_metroTile.Text = "Тесты";
            this.tests_metroTile.TileImage = global::kTesterAdmin.Properties.Resources.test_white_mini;
            this.tests_metroTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tests_metroTile.UseSelectable = true;
            this.tests_metroTile.UseTileImage = true;
            // 
            // catalogs_metroTile
            // 
            this.catalogs_metroTile.ActiveControl = null;
            this.catalogs_metroTile.Location = new System.Drawing.Point(3, 109);
            this.catalogs_metroTile.Name = "catalogs_metroTile";
            this.catalogs_metroTile.Size = new System.Drawing.Size(105, 100);
            this.catalogs_metroTile.TabIndex = 1;
            this.catalogs_metroTile.Text = "Справочники";
            this.catalogs_metroTile.TileImage = global::kTesterAdmin.Properties.Resources.book_white_mini;
            this.catalogs_metroTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.catalogs_metroTile.UseSelectable = true;
            this.catalogs_metroTile.UseTileImage = true;
            // 
            // logs_metroTile
            // 
            this.logs_metroTile.ActiveControl = null;
            this.logs_metroTile.Location = new System.Drawing.Point(3, 321);
            this.logs_metroTile.Name = "logs_metroTile";
            this.logs_metroTile.Size = new System.Drawing.Size(105, 100);
            this.logs_metroTile.TabIndex = 2;
            this.logs_metroTile.Text = "Логи";
            this.logs_metroTile.TileImage = ((System.Drawing.Image)(resources.GetObject("logs_metroTile.TileImage")));
            this.logs_metroTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.logs_metroTile.UseSelectable = true;
            this.logs_metroTile.UseTileImage = true;
            // 
            // users_metroTile
            // 
            this.users_metroTile.ActiveControl = null;
            this.users_metroTile.Location = new System.Drawing.Point(3, 215);
            this.users_metroTile.Name = "users_metroTile";
            this.users_metroTile.Size = new System.Drawing.Size(105, 100);
            this.users_metroTile.TabIndex = 4;
            this.users_metroTile.Text = "Пользователи";
            this.users_metroTile.TileImage = global::kTesterAdmin.Properties.Resources.user_white_mini;
            this.users_metroTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.users_metroTile.UseSelectable = true;
            this.users_metroTile.UseTileImage = true;
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.catalogs_metroTile);
            this.Controls.Add(this.logs_metroTile);
            this.Controls.Add(this.tests_metroTile);
            this.Controls.Add(this.users_metroTile);
            this.Name = "AdminMenu";
            this.Size = new System.Drawing.Size(110, 425);
            this.ResumeLayout(false);

        }

        #endregion

        public MetroFramework.Controls.MetroTile catalogs_metroTile;
        public MetroFramework.Controls.MetroTile logs_metroTile;
        public MetroFramework.Controls.MetroTile tests_metroTile;
        public MetroFramework.Controls.MetroTile users_metroTile;
    }
}
