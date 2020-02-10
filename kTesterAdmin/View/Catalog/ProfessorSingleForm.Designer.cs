namespace kTesterAdmin.View.Catalog
{
    partial class ProfessorSingleForm
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
            this.name_metroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.save_metroButton = new MetroFramework.Controls.MetroButton();
            this.user_metroComboBox = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // name_metroTextBox
            // 
            // 
            // 
            // 
            this.name_metroTextBox.CustomButton.Image = null;
            this.name_metroTextBox.CustomButton.Location = new System.Drawing.Point(286, 2);
            this.name_metroTextBox.CustomButton.Name = "";
            this.name_metroTextBox.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.name_metroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.name_metroTextBox.CustomButton.TabIndex = 1;
            this.name_metroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.name_metroTextBox.CustomButton.UseSelectable = true;
            this.name_metroTextBox.CustomButton.Visible = false;
            this.name_metroTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.name_metroTextBox.Lines = new string[0];
            this.name_metroTextBox.Location = new System.Drawing.Point(11, 87);
            this.name_metroTextBox.MaxLength = 32767;
            this.name_metroTextBox.Name = "name_metroTextBox";
            this.name_metroTextBox.PasswordChar = '\0';
            this.name_metroTextBox.PromptText = "ФИО профессора";
            this.name_metroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.name_metroTextBox.SelectedText = "";
            this.name_metroTextBox.SelectionLength = 0;
            this.name_metroTextBox.SelectionStart = 0;
            this.name_metroTextBox.ShortcutsEnabled = true;
            this.name_metroTextBox.Size = new System.Drawing.Size(312, 28);
            this.name_metroTextBox.TabIndex = 0;
            this.name_metroTextBox.UseSelectable = true;
            this.name_metroTextBox.WaterMark = "ФИО профессора";
            this.name_metroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.name_metroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // save_metroButton
            // 
            this.save_metroButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save_metroButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.save_metroButton.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.save_metroButton.Location = new System.Drawing.Point(211, 175);
            this.save_metroButton.Name = "save_metroButton";
            this.save_metroButton.Size = new System.Drawing.Size(112, 23);
            this.save_metroButton.TabIndex = 1;
            this.save_metroButton.Text = "Сохранить";
            this.save_metroButton.UseSelectable = true;
            this.save_metroButton.Click += new System.EventHandler(this.save_metroButton_Click);
            // 
            // user_metroComboBox
            // 
            this.user_metroComboBox.FormattingEnabled = true;
            this.user_metroComboBox.ItemHeight = 23;
            this.user_metroComboBox.Location = new System.Drawing.Point(109, 133);
            this.user_metroComboBox.Name = "user_metroComboBox";
            this.user_metroComboBox.Size = new System.Drawing.Size(214, 29);
            this.user_metroComboBox.TabIndex = 2;
            this.user_metroComboBox.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.ForeColor = System.Drawing.Color.Black;
            this.metroLabel3.Location = new System.Drawing.Point(11, 137);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(92, 19);
            this.metroLabel3.TabIndex = 15;
            this.metroLabel3.Text = "Пользователь";
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // ProfessorSingleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 210);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.user_metroComboBox);
            this.Controls.Add(this.save_metroButton);
            this.Controls.Add(this.name_metroTextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "ProfessorSingleForm";
            this.Resizable = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox name_metroTextBox;
        private MetroFramework.Controls.MetroButton save_metroButton;
        private MetroFramework.Controls.MetroComboBox user_metroComboBox;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}