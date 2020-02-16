namespace kTesterAdmin.View.Tests
{
    partial class TestsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestsForm));
            this.tests_metroPanel = new MetroFramework.Controls.MetroPanel();
            this.delete_metroTile = new MetroFramework.Controls.MetroTile();
            this.edit_metroTile = new MetroFramework.Controls.MetroTile();
            this.add_metroTile = new MetroFramework.Controls.MetroTile();
            this.open_metroTile = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // tests_metroPanel
            // 
            this.tests_metroPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tests_metroPanel.HorizontalScrollbarBarColor = true;
            this.tests_metroPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.tests_metroPanel.HorizontalScrollbarSize = 10;
            this.tests_metroPanel.Location = new System.Drawing.Point(4, 123);
            this.tests_metroPanel.Name = "tests_metroPanel";
            this.tests_metroPanel.Size = new System.Drawing.Size(577, 466);
            this.tests_metroPanel.TabIndex = 13;
            this.tests_metroPanel.VerticalScrollbarBarColor = true;
            this.tests_metroPanel.VerticalScrollbarHighlightOnWheel = false;
            this.tests_metroPanel.VerticalScrollbarSize = 10;
            // 
            // delete_metroTile
            // 
            this.delete_metroTile.ActiveControl = null;
            this.delete_metroTile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delete_metroTile.Location = new System.Drawing.Point(466, 3);
            this.delete_metroTile.Name = "delete_metroTile";
            this.delete_metroTile.Size = new System.Drawing.Size(105, 100);
            this.delete_metroTile.Style = MetroFramework.MetroColorStyle.Red;
            this.delete_metroTile.TabIndex = 20;
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
            this.edit_metroTile.TabIndex = 21;
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
            this.add_metroTile.TabIndex = 22;
            this.add_metroTile.Text = "Добавить";
            this.add_metroTile.TileImage = ((System.Drawing.Image)(resources.GetObject("add_metroTile.TileImage")));
            this.add_metroTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.add_metroTile.UseSelectable = true;
            this.add_metroTile.UseTileImage = true;
            this.add_metroTile.Click += new System.EventHandler(this.add_metroTile_Click);
            // 
            // open_metroTile
            // 
            this.open_metroTile.ActiveControl = null;
            this.open_metroTile.Location = new System.Drawing.Point(14, 3);
            this.open_metroTile.Name = "open_metroTile";
            this.open_metroTile.Size = new System.Drawing.Size(105, 100);
            this.open_metroTile.TabIndex = 23;
            this.open_metroTile.Text = "Открыть";
            this.open_metroTile.TileImage = ((System.Drawing.Image)(resources.GetObject("open_metroTile.TileImage")));
            this.open_metroTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.open_metroTile.UseSelectable = true;
            this.open_metroTile.UseTileImage = true;
            // 
            // TestsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.open_metroTile);
            this.Controls.Add(this.delete_metroTile);
            this.Controls.Add(this.edit_metroTile);
            this.Controls.Add(this.add_metroTile);
            this.Controls.Add(this.tests_metroPanel);
            this.Name = "TestsForm";
            this.Size = new System.Drawing.Size(584, 592);
            this.Load += new System.EventHandler(this.TestsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel tests_metroPanel;
        public MetroFramework.Controls.MetroTile delete_metroTile;
        public MetroFramework.Controls.MetroTile edit_metroTile;
        public MetroFramework.Controls.MetroTile add_metroTile;
        public MetroFramework.Controls.MetroTile open_metroTile;
    }
}
