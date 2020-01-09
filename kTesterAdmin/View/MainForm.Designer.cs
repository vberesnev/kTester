namespace kTesterAdmin.View
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.catalog_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faculty_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studyGroups_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.professors_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subjects_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.users_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logs_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.catalog_ToolStripMenuItem,
            this.users_ToolStripMenuItem,
            this.logs_ToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // catalog_ToolStripMenuItem
            // 
            this.catalog_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.faculty_ToolStripMenuItem,
            this.studyGroups_ToolStripMenuItem,
            this.professors_ToolStripMenuItem,
            this.subjects_ToolStripMenuItem});
            this.catalog_ToolStripMenuItem.Name = "catalog_ToolStripMenuItem";
            this.catalog_ToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.catalog_ToolStripMenuItem.Text = "Справочники";
            // 
            // faculty_ToolStripMenuItem
            // 
            this.faculty_ToolStripMenuItem.Name = "faculty_ToolStripMenuItem";
            this.faculty_ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.faculty_ToolStripMenuItem.Text = "Факультеты";
            this.faculty_ToolStripMenuItem.Click += new System.EventHandler(this.facultyToolStripMenuItem_Click);
            // 
            // studyGroups_ToolStripMenuItem
            // 
            this.studyGroups_ToolStripMenuItem.Name = "studyGroups_ToolStripMenuItem";
            this.studyGroups_ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.studyGroups_ToolStripMenuItem.Text = "Группы";
            // 
            // professors_ToolStripMenuItem
            // 
            this.professors_ToolStripMenuItem.Name = "professors_ToolStripMenuItem";
            this.professors_ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.professors_ToolStripMenuItem.Text = "Преподаватели";
            // 
            // subjects_ToolStripMenuItem
            // 
            this.subjects_ToolStripMenuItem.Name = "subjects_ToolStripMenuItem";
            this.subjects_ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.subjects_ToolStripMenuItem.Text = "Предменты";
            // 
            // users_ToolStripMenuItem
            // 
            this.users_ToolStripMenuItem.Name = "users_ToolStripMenuItem";
            this.users_ToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.users_ToolStripMenuItem.Text = "Пользователи";
            // 
            // logs_ToolStripMenuItem
            // 
            this.logs_ToolStripMenuItem.Name = "logs_ToolStripMenuItem";
            this.logs_ToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.logs_ToolStripMenuItem.Text = "Логи";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "kTester";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem catalog_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faculty_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studyGroups_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem professors_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subjects_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem users_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logs_ToolStripMenuItem;
    }
}