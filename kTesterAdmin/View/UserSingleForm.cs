using kTesterAdmin.Controller;
using kTesterLib.Service;
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
    public partial class UserSingleForm : MetroFramework.Forms.MetroForm
    {

        private UserController userController;
        public UserSingleForm(Controller.UserController userController)
        {
            InitializeComponent();
            this.userController = userController;

            userRights_metroComboBox.DataSource = Enum.GetValues(typeof(UserRights));
            
            if (userController.CurrentItem.Id == 0)
            {
                this.Text = "Добавить пользователя";
                changePassword_metroButton.Visible = false;
            }
                
            else
            {
                this.Text = "Редактировать пользователя";
                login_metroTextBox.Text = userController.CurrentItem.Login;
                password_metroTextBox.Visible = false;
                userRights_metroComboBox.SelectedItem = userController.CurrentItem.UserRights;
            }
        }

        private void save_metroButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(login_metroTextBox.Text)) return;
            if (password_metroTextBox.Visible && string.IsNullOrWhiteSpace(password_metroTextBox.Text)) return;

            bool result = false;
            result = userController.AddOrUpdateItemAsync(login_metroTextBox.Text, 
                                                         password_metroTextBox.Text, 
                                                         Convert.ToInt32(userRights_metroComboBox.SelectedItem).ToString()).Result;
            if (result)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void changePassword_metroButton_Click(object sender, EventArgs e)
        {
            using (UserChangePassForm UCPF = new UserChangePassForm(userController))
            {
                UCPF.Owner = this.ParentForm;
                if (UCPF.ShowDialog() == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }
    }
}
