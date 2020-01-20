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
            this.menu_metroPanel = new MetroFramework.Controls.MetroPanel();
            this.content_metroPanel = new MetroFramework.Controls.MetroPanel();
            this.SuspendLayout();
            // 
            // menu_metroPanel
            // 
            this.menu_metroPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.menu_metroPanel.HorizontalScrollbarBarColor = true;
            this.menu_metroPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.menu_metroPanel.HorizontalScrollbarSize = 10;
            this.menu_metroPanel.Location = new System.Drawing.Point(7, 54);
            this.menu_metroPanel.Name = "menu_metroPanel";
            this.menu_metroPanel.Size = new System.Drawing.Size(125, 648);
            this.menu_metroPanel.TabIndex = 1;
            this.menu_metroPanel.VerticalScrollbarBarColor = true;
            this.menu_metroPanel.VerticalScrollbarHighlightOnWheel = false;
            this.menu_metroPanel.VerticalScrollbarSize = 10;
            // 
            // content_metroPanel
            // 
            this.content_metroPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.content_metroPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.content_metroPanel.HorizontalScrollbarBarColor = true;
            this.content_metroPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.content_metroPanel.HorizontalScrollbarSize = 10;
            this.content_metroPanel.Location = new System.Drawing.Point(139, 54);
            this.content_metroPanel.Name = "content_metroPanel";
            this.content_metroPanel.Size = new System.Drawing.Size(654, 648);
            this.content_metroPanel.TabIndex = 2;
            this.content_metroPanel.VerticalScrollbarBarColor = true;
            this.content_metroPanel.VerticalScrollbarHighlightOnWheel = false;
            this.content_metroPanel.VerticalScrollbarSize = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 713);
            this.Controls.Add(this.content_metroPanel);
            this.Controls.Add(this.menu_metroPanel);
            this.Name = "MainForm";
            this.Text = "kTester";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroPanel menu_metroPanel;
        private MetroFramework.Controls.MetroPanel content_metroPanel;
    }
}