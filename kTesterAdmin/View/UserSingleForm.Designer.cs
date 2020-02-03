namespace kTesterAdmin.View
{
    partial class UserSingleForm
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
            this.save_metroButton = new MetroFramework.Controls.MetroButton();
            this.login_metroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.password_metroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.changePassword_metroButton = new MetroFramework.Controls.MetroButton();
            this.userRights_metroComboBox = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // save_metroButton
            // 
            this.save_metroButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save_metroButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.save_metroButton.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.save_metroButton.Location = new System.Drawing.Point(242, 200);
            this.save_metroButton.Name = "save_metroButton";
            this.save_metroButton.Size = new System.Drawing.Size(112, 28);
            this.save_metroButton.TabIndex = 3;
            this.save_metroButton.Text = "Сохранить";
            this.save_metroButton.UseSelectable = true;
            this.save_metroButton.Click += new System.EventHandler(this.save_metroButton_Click);
            // 
            // login_metroTextBox
            // 
            // 
            // 
            // 
            this.login_metroTextBox.CustomButton.Image = null;
            this.login_metroTextBox.CustomButton.Location = new System.Drawing.Point(286, 2);
            this.login_metroTextBox.CustomButton.Name = "";
            this.login_metroTextBox.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.login_metroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.login_metroTextBox.CustomButton.TabIndex = 1;
            this.login_metroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.login_metroTextBox.CustomButton.UseSelectable = true;
            this.login_metroTextBox.CustomButton.Visible = false;
            this.login_metroTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.login_metroTextBox.Lines = new string[0];
            this.login_metroTextBox.Location = new System.Drawing.Point(10, 77);
            this.login_metroTextBox.MaxLength = 32767;
            this.login_metroTextBox.Name = "login_metroTextBox";
            this.login_metroTextBox.PasswordChar = '\0';
            this.login_metroTextBox.PromptText = "Логин";
            this.login_metroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.login_metroTextBox.SelectedText = "";
            this.login_metroTextBox.SelectionLength = 0;
            this.login_metroTextBox.SelectionStart = 0;
            this.login_metroTextBox.ShortcutsEnabled = true;
            this.login_metroTextBox.Size = new System.Drawing.Size(344, 28);
            this.login_metroTextBox.TabIndex = 2;
            this.login_metroTextBox.UseSelectable = true;
            this.login_metroTextBox.WaterMark = "Логин";
            this.login_metroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.login_metroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // password_metroTextBox
            // 
            // 
            // 
            // 
            this.password_metroTextBox.CustomButton.Image = null;
            this.password_metroTextBox.CustomButton.Location = new System.Drawing.Point(286, 2);
            this.password_metroTextBox.CustomButton.Name = "";
            this.password_metroTextBox.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.password_metroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.password_metroTextBox.CustomButton.TabIndex = 1;
            this.password_metroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.password_metroTextBox.CustomButton.UseSelectable = true;
            this.password_metroTextBox.CustomButton.Visible = false;
            this.password_metroTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.password_metroTextBox.Lines = new string[0];
            this.password_metroTextBox.Location = new System.Drawing.Point(10, 113);
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
            this.password_metroTextBox.TabIndex = 4;
            this.password_metroTextBox.UseSelectable = true;
            this.password_metroTextBox.WaterMark = "Пароль";
            this.password_metroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.password_metroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // changePassword_metroButton
            // 
            this.changePassword_metroButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changePassword_metroButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.changePassword_metroButton.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.changePassword_metroButton.Location = new System.Drawing.Point(10, 113);
            this.changePassword_metroButton.Name = "changePassword_metroButton";
            this.changePassword_metroButton.Size = new System.Drawing.Size(112, 28);
            this.changePassword_metroButton.TabIndex = 5;
            this.changePassword_metroButton.Text = "Сменить пароль";
            this.changePassword_metroButton.UseSelectable = true;
            this.changePassword_metroButton.Click += new System.EventHandler(this.changePassword_metroButton_Click);
            // 
            // userRights_metroComboBox
            // 
            this.userRights_metroComboBox.FormattingEnabled = true;
            this.userRights_metroComboBox.ItemHeight = 23;
            this.userRights_metroComboBox.Location = new System.Drawing.Point(10, 149);
            this.userRights_metroComboBox.Name = "userRights_metroComboBox";
            this.userRights_metroComboBox.Size = new System.Drawing.Size(344, 29);
            this.userRights_metroComboBox.TabIndex = 6;
            this.userRights_metroComboBox.UseSelectable = true;
            // 
            // UserSingleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 242);
            this.Controls.Add(this.userRights_metroComboBox);
            this.Controls.Add(this.changePassword_metroButton);
            this.Controls.Add(this.password_metroTextBox);
            this.Controls.Add(this.save_metroButton);
            this.Controls.Add(this.login_metroTextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "UserSingleForm";
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UserSingleForm";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton save_metroButton;
        private MetroFramework.Controls.MetroTextBox login_metroTextBox;
        private MetroFramework.Controls.MetroTextBox password_metroTextBox;
        private MetroFramework.Controls.MetroButton changePassword_metroButton;
        private MetroFramework.Controls.MetroComboBox userRights_metroComboBox;
    }
}