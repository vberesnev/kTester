namespace kTesterAdmin.View
{
    partial class UserChangePassForm
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
            this.password_metroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.confirmPass_metroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.save_metroButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // password_metroTextBox
            // 
            // 
            // 
            // 
            this.password_metroTextBox.CustomButton.Image = null;
            this.password_metroTextBox.CustomButton.Location = new System.Drawing.Point(318, 2);
            this.password_metroTextBox.CustomButton.Name = "";
            this.password_metroTextBox.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.password_metroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.password_metroTextBox.CustomButton.TabIndex = 1;
            this.password_metroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.password_metroTextBox.CustomButton.UseSelectable = true;
            this.password_metroTextBox.CustomButton.Visible = false;
            this.password_metroTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.password_metroTextBox.Lines = new string[0];
            this.password_metroTextBox.Location = new System.Drawing.Point(9, 78);
            this.password_metroTextBox.MaxLength = 32767;
            this.password_metroTextBox.Name = "password_metroTextBox";
            this.password_metroTextBox.PasswordChar = '*';
            this.password_metroTextBox.PromptText = "Пароль";
            this.password_metroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.password_metroTextBox.SelectedText = "";
            this.password_metroTextBox.SelectionLength = 0;
            this.password_metroTextBox.SelectionStart = 0;
            this.password_metroTextBox.ShortcutsEnabled = true;
            this.password_metroTextBox.Size = new System.Drawing.Size(344, 28);
            this.password_metroTextBox.TabIndex = 5;
            this.password_metroTextBox.UseSelectable = true;
            this.password_metroTextBox.WaterMark = "Пароль";
            this.password_metroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.password_metroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // confirmPass_metroTextBox
            // 
            // 
            // 
            // 
            this.confirmPass_metroTextBox.CustomButton.Image = null;
            this.confirmPass_metroTextBox.CustomButton.Location = new System.Drawing.Point(318, 2);
            this.confirmPass_metroTextBox.CustomButton.Name = "";
            this.confirmPass_metroTextBox.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.confirmPass_metroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.confirmPass_metroTextBox.CustomButton.TabIndex = 1;
            this.confirmPass_metroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.confirmPass_metroTextBox.CustomButton.UseSelectable = true;
            this.confirmPass_metroTextBox.CustomButton.Visible = false;
            this.confirmPass_metroTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.confirmPass_metroTextBox.Lines = new string[0];
            this.confirmPass_metroTextBox.Location = new System.Drawing.Point(9, 121);
            this.confirmPass_metroTextBox.MaxLength = 32767;
            this.confirmPass_metroTextBox.Name = "confirmPass_metroTextBox";
            this.confirmPass_metroTextBox.PasswordChar = '*';
            this.confirmPass_metroTextBox.PromptText = "Подтвердить пароль";
            this.confirmPass_metroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.confirmPass_metroTextBox.SelectedText = "";
            this.confirmPass_metroTextBox.SelectionLength = 0;
            this.confirmPass_metroTextBox.SelectionStart = 0;
            this.confirmPass_metroTextBox.ShortcutsEnabled = true;
            this.confirmPass_metroTextBox.Size = new System.Drawing.Size(344, 28);
            this.confirmPass_metroTextBox.TabIndex = 6;
            this.confirmPass_metroTextBox.UseSelectable = true;
            this.confirmPass_metroTextBox.WaterMark = "Подтвердить пароль";
            this.confirmPass_metroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.confirmPass_metroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // save_metroButton
            // 
            this.save_metroButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save_metroButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.save_metroButton.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.save_metroButton.Location = new System.Drawing.Point(241, 174);
            this.save_metroButton.Name = "save_metroButton";
            this.save_metroButton.Size = new System.Drawing.Size(112, 28);
            this.save_metroButton.TabIndex = 7;
            this.save_metroButton.Text = "Сохранить";
            this.save_metroButton.UseSelectable = true;
            this.save_metroButton.Click += new System.EventHandler(this.save_metroButton_Click);
            // 
            // UserChangePassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 216);
            this.Controls.Add(this.save_metroButton);
            this.Controls.Add(this.confirmPass_metroTextBox);
            this.Controls.Add(this.password_metroTextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "UserChangePassForm";
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox password_metroTextBox;
        private MetroFramework.Controls.MetroTextBox confirmPass_metroTextBox;
        private MetroFramework.Controls.MetroButton save_metroButton;
    }
}