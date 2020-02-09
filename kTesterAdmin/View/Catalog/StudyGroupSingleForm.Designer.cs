namespace kTesterAdmin.View.Catalog
{
    partial class StudyGroupSingleForm
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
            this.name_metroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.faculties_metroComboBox = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.quantity_metroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // save_metroButton
            // 
            this.save_metroButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save_metroButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.save_metroButton.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.save_metroButton.Location = new System.Drawing.Point(208, 204);
            this.save_metroButton.Name = "save_metroButton";
            this.save_metroButton.Size = new System.Drawing.Size(112, 23);
            this.save_metroButton.TabIndex = 3;
            this.save_metroButton.Text = "Сохранить";
            this.save_metroButton.UseSelectable = true;
            this.save_metroButton.Click += new System.EventHandler(this.save_metroButton_Click);
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
            this.name_metroTextBox.Location = new System.Drawing.Point(8, 73);
            this.name_metroTextBox.MaxLength = 32767;
            this.name_metroTextBox.Name = "name_metroTextBox";
            this.name_metroTextBox.PasswordChar = '\0';
            this.name_metroTextBox.PromptText = "Учебная группа";
            this.name_metroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.name_metroTextBox.SelectedText = "";
            this.name_metroTextBox.SelectionLength = 0;
            this.name_metroTextBox.SelectionStart = 0;
            this.name_metroTextBox.ShortcutsEnabled = true;
            this.name_metroTextBox.Size = new System.Drawing.Size(312, 28);
            this.name_metroTextBox.TabIndex = 2;
            this.name_metroTextBox.UseSelectable = true;
            this.name_metroTextBox.WaterMark = "Учебная группа";
            this.name_metroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.name_metroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // faculties_metroComboBox
            // 
            this.faculties_metroComboBox.BackColor = System.Drawing.Color.LightGray;
            this.faculties_metroComboBox.FormattingEnabled = true;
            this.faculties_metroComboBox.ItemHeight = 23;
            this.faculties_metroComboBox.Location = new System.Drawing.Point(76, 116);
            this.faculties_metroComboBox.Name = "faculties_metroComboBox";
            this.faculties_metroComboBox.Size = new System.Drawing.Size(244, 29);
            this.faculties_metroComboBox.Style = MetroFramework.MetroColorStyle.Silver;
            this.faculties_metroComboBox.TabIndex = 19;
            this.faculties_metroComboBox.Theme = MetroFramework.MetroThemeStyle.Light;
            this.faculties_metroComboBox.UseCustomBackColor = true;
            this.faculties_metroComboBox.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.ForeColor = System.Drawing.Color.Black;
            this.metroLabel1.Location = new System.Drawing.Point(4, 120);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(66, 19);
            this.metroLabel1.TabIndex = 18;
            this.metroLabel1.Text = "Факультет";
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.ForeColor = System.Drawing.Color.Black;
            this.metroLabel2.Location = new System.Drawing.Point(8, 166);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(189, 19);
            this.metroLabel2.TabIndex = 20;
            this.metroLabel2.Text = "Количество человек в группе";
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // quantity_metroTextBox
            // 
            // 
            // 
            // 
            this.quantity_metroTextBox.CustomButton.Image = null;
            this.quantity_metroTextBox.CustomButton.Location = new System.Drawing.Point(86, 2);
            this.quantity_metroTextBox.CustomButton.Name = "";
            this.quantity_metroTextBox.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.quantity_metroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.quantity_metroTextBox.CustomButton.TabIndex = 1;
            this.quantity_metroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.quantity_metroTextBox.CustomButton.UseSelectable = true;
            this.quantity_metroTextBox.CustomButton.Visible = false;
            this.quantity_metroTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.quantity_metroTextBox.Lines = new string[0];
            this.quantity_metroTextBox.Location = new System.Drawing.Point(208, 161);
            this.quantity_metroTextBox.MaxLength = 32767;
            this.quantity_metroTextBox.Name = "quantity_metroTextBox";
            this.quantity_metroTextBox.PasswordChar = '\0';
            this.quantity_metroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.quantity_metroTextBox.SelectedText = "";
            this.quantity_metroTextBox.SelectionLength = 0;
            this.quantity_metroTextBox.SelectionStart = 0;
            this.quantity_metroTextBox.ShortcutsEnabled = true;
            this.quantity_metroTextBox.Size = new System.Drawing.Size(112, 28);
            this.quantity_metroTextBox.TabIndex = 21;
            this.quantity_metroTextBox.UseSelectable = true;
            this.quantity_metroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.quantity_metroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // StudyGroupSingleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 241);
            this.Controls.Add(this.quantity_metroTextBox);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.faculties_metroComboBox);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.save_metroButton);
            this.Controls.Add(this.name_metroTextBox);
            this.Movable = false;
            this.Name = "StudyGroupSingleForm";
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "StudyGroupSingleForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton save_metroButton;
        private MetroFramework.Controls.MetroTextBox name_metroTextBox;
        private MetroFramework.Controls.MetroComboBox faculties_metroComboBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox quantity_metroTextBox;
    }
}