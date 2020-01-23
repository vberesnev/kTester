namespace kTesterAdmin
{
    partial class AuthForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.auth_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.header_panel = new System.Windows.Forms.Panel();
            this.settings_button = new System.Windows.Forms.Button();
            this.close_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.login_textBox = new System.Windows.Forms.TextBox();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.header_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // auth_button
            // 
            this.auth_button.BackColor = System.Drawing.Color.Blue;
            this.auth_button.FlatAppearance.BorderSize = 0;
            this.auth_button.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.auth_button.ForeColor = System.Drawing.Color.White;
            this.auth_button.Location = new System.Drawing.Point(89, 234);
            this.auth_button.Name = "auth_button";
            this.auth_button.Size = new System.Drawing.Size(112, 40);
            this.auth_button.TabIndex = 0;
            this.auth_button.Text = "Войти";
            this.auth_button.UseVisualStyleBackColor = false;
            this.auth_button.Click += new System.EventHandler(this.auth_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "kTester Admin";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEvent);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMoveEvent);
            // 
            // header_panel
            // 
            this.header_panel.BackColor = System.Drawing.Color.Blue;
            this.header_panel.Controls.Add(this.settings_button);
            this.header_panel.Controls.Add(this.label1);
            this.header_panel.Controls.Add(this.close_button);
            this.header_panel.Location = new System.Drawing.Point(0, -1);
            this.header_panel.Name = "header_panel";
            this.header_panel.Size = new System.Drawing.Size(288, 47);
            this.header_panel.TabIndex = 3;
            this.header_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEvent);
            this.header_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMoveEvent);
            // 
            // settings_button
            // 
            this.settings_button.BackColor = System.Drawing.Color.Transparent;

            this.settings_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.settings_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settings_button.FlatAppearance.BorderSize = 0;
            this.settings_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.settings_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.settings_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settings_button.Location = new System.Drawing.Point(209, 6);
            this.settings_button.Name = "settings_button";
            this.settings_button.Size = new System.Drawing.Size(35, 34);
            this.settings_button.TabIndex = 3;
            this.settings_button.UseVisualStyleBackColor = false;
            this.settings_button.Click += new System.EventHandler(this.settings_button_Click);
            // 
            // close_button
            // 
            this.close_button.BackColor = System.Drawing.Color.Transparent;
            this.close_button.BackgroundImage = global::kTesterAdmin.Properties.Resources.exit;
            this.close_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.close_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_button.FlatAppearance.BorderSize = 0;
            this.close_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.close_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.close_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_button.Location = new System.Drawing.Point(250, 6);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(35, 34);
            this.close_button.TabIndex = 2;
            this.close_button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.close_button.UseVisualStyleBackColor = false;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "ЛОГИН";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "ПАРОЛЬ";
            // 
            // login_textBox
            // 
            this.login_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_textBox.Location = new System.Drawing.Point(13, 117);
            this.login_textBox.Name = "login_textBox";
            this.login_textBox.Size = new System.Drawing.Size(261, 26);
            this.login_textBox.TabIndex = 6;
            // 
            // password_textBox
            // 
            this.password_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password_textBox.Location = new System.Drawing.Point(12, 175);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.PasswordChar = '*';
            this.password_textBox.Size = new System.Drawing.Size(261, 26);
            this.password_textBox.TabIndex = 7;
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 286);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.login_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.header_panel);
            this.Controls.Add(this.auth_button);

            this.Name = "AuthForm";

            this.Text = "Войти";
            this.header_panel.ResumeLayout(false);
            this.header_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button auth_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.Panel header_panel;
        private System.Windows.Forms.Button settings_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox login_textBox;
        private System.Windows.Forms.TextBox password_textBox;
    }
}

