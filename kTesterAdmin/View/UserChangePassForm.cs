using kTesterAdmin.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kTesterAdmin.View
{
    public partial class UserChangePassForm : MetroFramework.Forms.MetroForm
    {
        private UserController userController;
        public UserChangePassForm(Controller.UserController userController)
        {
            InitializeComponent();

            this.userController = userController;
            this.Text = $"{userController.CurrentItem.Login} - смена пароля";
        }

        private void save_metroButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(password_metroTextBox.Text) || string.IsNullOrWhiteSpace(confirmPass_metroTextBox.Text))
                return;

            if (password_metroTextBox.Text != confirmPass_metroTextBox.Text)
            {
                MetroFramework.MetroMessageBox.Show(this, "Пароли должны совпадать!",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool result = false;
            result = userController.ChangePasswordAsync(password_metroTextBox.Text).Result;

            if (result)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
