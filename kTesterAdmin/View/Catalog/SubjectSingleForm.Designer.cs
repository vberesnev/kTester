namespace kTesterAdmin.View.Catalog
{
    partial class SubjectSingleForm
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
            this.subject_metroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.save_metroButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // subject_metroTextBox
            // 
            // 
            // 
            // 
            this.subject_metroTextBox.CustomButton.Image = null;
            this.subject_metroTextBox.CustomButton.Location = new System.Drawing.Point(286, 2);
            this.subject_metroTextBox.CustomButton.Name = "";
            this.subject_metroTextBox.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.subject_metroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.subject_metroTextBox.CustomButton.TabIndex = 1;
            this.subject_metroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.subject_metroTextBox.CustomButton.UseSelectable = true;
            this.subject_metroTextBox.CustomButton.Visible = false;
            this.subject_metroTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.subject_metroTextBox.Lines = new string[0];
            this.subject_metroTextBox.Location = new System.Drawing.Point(11, 87);
            this.subject_metroTextBox.MaxLength = 32767;
            this.subject_metroTextBox.Name = "subject_metroTextBox";
            this.subject_metroTextBox.PasswordChar = '\0';
            this.subject_metroTextBox.PromptText = "Предмет";
            this.subject_metroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.subject_metroTextBox.SelectedText = "";
            this.subject_metroTextBox.SelectionLength = 0;
            this.subject_metroTextBox.SelectionStart = 0;
            this.subject_metroTextBox.ShortcutsEnabled = true;
            this.subject_metroTextBox.Size = new System.Drawing.Size(312, 28);
            this.subject_metroTextBox.TabIndex = 0;
            this.subject_metroTextBox.UseSelectable = true;
            this.subject_metroTextBox.WaterMark = "Предмет";
            this.subject_metroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.subject_metroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            // SubjectSingleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 164);
            this.Controls.Add(this.save_metroButton);
            this.Controls.Add(this.subject_metroTextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "SubjectSingleForm";
            this.Resizable = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox subject_metroTextBox;
        private MetroFramework.Controls.MetroButton save_metroButton;
    }
}