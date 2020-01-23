namespace kTesterAdmin.View.Catalog
{
    partial class FacultySingleForm
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
            this.faculty_metroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.save_metroButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // faculty_metroTextBox
            // 
            // 
            // 
            // 
            this.faculty_metroTextBox.CustomButton.Image = null;
            this.faculty_metroTextBox.CustomButton.Location = new System.Drawing.Point(286, 2);
            this.faculty_metroTextBox.CustomButton.Name = "";
            this.faculty_metroTextBox.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.faculty_metroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.faculty_metroTextBox.CustomButton.TabIndex = 1;
            this.faculty_metroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.faculty_metroTextBox.CustomButton.UseSelectable = true;
            this.faculty_metroTextBox.CustomButton.Visible = false;
            this.faculty_metroTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.faculty_metroTextBox.Lines = new string[0];
            this.faculty_metroTextBox.Location = new System.Drawing.Point(11, 87);
            this.faculty_metroTextBox.MaxLength = 32767;
            this.faculty_metroTextBox.Name = "faculty_metroTextBox";
            this.faculty_metroTextBox.PasswordChar = '\0';
            this.faculty_metroTextBox.WaterMark = "Факультет";
            this.faculty_metroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.faculty_metroTextBox.SelectedText = "";
            this.faculty_metroTextBox.SelectionLength = 0;
            this.faculty_metroTextBox.SelectionStart = 0;
            this.faculty_metroTextBox.ShortcutsEnabled = true;
            this.faculty_metroTextBox.Size = new System.Drawing.Size(312, 28);
            this.faculty_metroTextBox.TabIndex = 0;
            this.faculty_metroTextBox.UseSelectable = true;
            this.faculty_metroTextBox.WaterMark = "Факультет";
            this.faculty_metroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.faculty_metroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // save_metroButton
            // 
            this.save_metroButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save_metroButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.save_metroButton.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.save_metroButton.Location = new System.Drawing.Point(211, 132);
            this.save_metroButton.Name = "save_metroButton";
            this.save_metroButton.Size = new System.Drawing.Size(112, 23);
            this.save_metroButton.TabIndex = 1;
            this.save_metroButton.Text = "Сохранить";
            this.save_metroButton.UseSelectable = true;
            this.save_metroButton.Click += new System.EventHandler(this.save_metroButton_Click);
            // 
            // FacultySingleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 164);
            this.Controls.Add(this.save_metroButton);
            this.Controls.Add(this.faculty_metroTextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "FacultySingleForm";
            this.Resizable = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox faculty_metroTextBox;
        private MetroFramework.Controls.MetroButton save_metroButton;
    }
}