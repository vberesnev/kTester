using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using kTesterAdmin.Controller;
using kTesterAdmin.View;

namespace kTesterAdmin
{
    public partial class AuthForm : Form
    {
        private AuthController authController;
        
        public AuthForm()
        {
            InitializeComponent();
        }

        private async void auth_button_Click(object sender, EventArgs e)
        {
            authController = new AuthController();
            if (!string.IsNullOrWhiteSpace(login_textBox.Text) && !string.IsNullOrWhiteSpace(password_textBox.Text))
            {
                Tuple<bool, string> result = await authController.AuthAsync(login_textBox.Text, password_textBox.Text);
                if (result.Item1)
                {
                    MainForm mainForm = new MainForm(authController);
                    this.Hide();
                    mainForm.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show(result.Item2);
                }
            }
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите выйти?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void settings_button_Click(object sender, EventArgs e)
        {
            login_textBox.Clear();
            password_textBox.Clear();
            SettingsForm SF = new SettingsForm();
            SF.Owner = this;
            this.Hide();
            SF.ShowDialog();
            this.Show();
        }

        #region ДВИЖЕНИЕ ФОРМЫ МЫШКОЙ
        
        //Координаты мышки для движения формы
        private int x = 0;
        private int y = 0;

        private void MouseDownEvent(object sender, MouseEventArgs e)
        {
            x = e.X; y = e.Y;
        }

        private void MouseMoveEvent(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.Location = new System.Drawing.Point(this.Location.X + (e.X - x), this.Location.Y + (e.Y - y));

            }
        }

        #endregion
    }
}
