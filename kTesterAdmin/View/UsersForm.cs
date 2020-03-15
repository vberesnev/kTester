using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using kTesterAdmin.Controller;

namespace kTesterAdmin.View
{
    public partial class UsersForm : UserControl
    {

        private UserController userController;

        private Action<string> info;
        private Action<string> message;
        public UsersForm(AuthController currentUserController)
        {
            info = new Action<string>((x) => BeginInvoke(new Action(() => info_textBox.Text = x)));
            message = new Action<string>((x) => BeginInvoke(new Action(() =>
            {
                MetroFramework.MetroMessageBox.Show(this, x,
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            })));

            userController = new UserController(info, message, currentUserController);

            InitializeComponent();
            
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            info_textBox.Text = "Загрузка данных, подождите . . .";
            GetDataSourceAsync();
        }

        private async void GetDataSourceAsync()
        {
            info_textBox.Visible = true;
            users_metroGrid.Visible = false;

            users_metroGrid.DataSource = await userController.GetDataAsync();
            if (users_metroGrid.DataSource != null || users_metroGrid.Rows.Count > 0)
            {
                users_metroGrid.Visible = true;
                info_textBox.Visible = false;
                users_metroGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                users_metroGrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                users_metroGrid.Columns[0].Visible = false;
                users_metroGrid.Columns[1].HeaderText = "Логин";
                users_metroGrid.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                users_metroGrid.Columns[1].Width = (int)(users_metroGrid.Width * 0.33);
                users_metroGrid.Columns[2].HeaderText = "Тип";
                users_metroGrid.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                users_metroGrid.Columns[2].Width = (int)(users_metroGrid.Width * 0.33);
                users_metroGrid.Columns[3].HeaderText = "ФИО";
                users_metroGrid.Columns[3].Width = (int)(users_metroGrid.Width * 0.33);
                users_metroGrid.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void delete_metroTile_Click(object sender, EventArgs e)
        {
            if (users_metroGrid.SelectedRows.Count == 0) return;
            int row = users_metroGrid.SelectedRows[0].Index;
            if (users_metroGrid.Rows[row].Cells["Login"].Value.ToString() == "admin")
            {
                message("Нельзя удалять главного администратора");
                return;
            }
            if (MetroFramework.MetroMessageBox.Show(this, $"Вы действительно хотите удалить пользователя {users_metroGrid.Rows[row].Cells["Login"].Value}?",
                    "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DeleteUser((int)users_metroGrid.Rows[row].Cells["Id"].Value);
            }
        }

        private void DeleteUser(int id)
        {
            info_textBox.Visible = true;
            users_metroGrid.Visible = false;
            info_textBox.Text = "Удаление, подождите . . .";
            userController.SetCurrentItem(id);

            if (userController.DeleteItemAsync().Result)
                GetDataSourceAsync();
        }

        private void add_metroTile_Click(object sender, EventArgs e)
        {
            userController.SetCurrentItem();
            using (UserSingleForm USF = new UserSingleForm(userController))
            {
                USF.Owner = this.ParentForm;
                if (USF.ShowDialog() == DialogResult.OK)
                    GetDataSourceAsync();
            }
        }

        private void edit_metroTile_Click(object sender, EventArgs e)
        {
            if (users_metroGrid.SelectedRows.Count == 0) return;
            userController.SetCurrentItem((int)users_metroGrid.SelectedRows[0].Cells["Id"].Value);
            using (UserSingleForm USF = new UserSingleForm(userController))
            {
                USF.Owner = this.ParentForm;
                if (USF.ShowDialog() == DialogResult.OK)
                    GetDataSourceAsync();
            }
        }
    }
    
}
