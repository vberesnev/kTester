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
using MetroFramework.Controls;

namespace kTesterAdmin.View
{
    public partial class LogsForm : UserControl
    {
        private LogController logController;
        private SearchController searchController;

        private Action<string> info;
        private Action<string> message;

        public LogsForm(AuthController userController)
        {
            info = new Action<string>((x) => BeginInvoke(new Action(() => info_textBox.Text = x)));
            message = new Action<string>((x) => BeginInvoke(new Action(() =>
            {
                MetroFramework.MetroMessageBox.Show(this, x,
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            })));


            logController = new LogController(info, userController);
            searchController = new SearchController(message, userController);
            InitializeComponent();
        }

        private void LogsForm_Load(object sender, EventArgs e)
        {
            info_textBox.Text = "Загрузка данных, подождите . . .";
            info_textBox.Visible = true;
            logs_metroGrid.Visible = false;
            metroDateTime.Value = DateTime.Now;
            GetUsers();
            //GetDataSource(DateTime.Now);
        }

        private async void GetDataSource(DateTime date)
        {
            info_textBox.Visible = true;
            logs_metroGrid.Visible = false;

            //logs_metroGrid.Rows.Clear();
            //logs_metroGrid.Columns.Clear();
            //logs_metroGrid.Refresh();

            logs_metroGrid.DataSource = await logController.GetLogsByDateAsync(date);
            if (logs_metroGrid.DataSource != null || logs_metroGrid.Rows.Count > 0)
            {
                logs_metroGrid.Visible = true;
                info_textBox.Visible = false;
                logs_metroGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                logs_metroGrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                logs_metroGrid.Columns[0].Visible = false;
                logs_metroGrid.Columns[1].HeaderText = "Время";
                logs_metroGrid.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                logs_metroGrid.Columns[1].Width = (int)(logs_metroGrid.Width * 0.15);
                logs_metroGrid.Columns[2].HeaderText = "Пользователь";
                logs_metroGrid.Columns[2].Width = (int)(logs_metroGrid.Width * 0.15);
                logs_metroGrid.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                logs_metroGrid.Columns[3].HeaderText = "Лог";
                logs_metroGrid.Columns[3].Width = logs_metroGrid.Width - logs_metroGrid.Columns[1].Width - logs_metroGrid.Columns[2].Width;
            }
        }

        private async void GetUsers()
        {
            var bindingSource = new BindingSource();
            bindingSource.DataSource = await searchController.GetUsersAsync();

            users_metroComboBox.DataSource = bindingSource;
            users_metroComboBox.DisplayMember = "Login";
            users_metroComboBox.ValueMember = "Id";
        }

        private void metroDateTime_ValueChanged(object sender, EventArgs e)
        {
            GetDataSource(metroDateTime.Value);
        }

        private async void SearchLog(int userId, string parametr)
        {
            info_textBox.Visible = true;
            logs_metroGrid.Visible = false;

            //logs_metroGrid.Rows.Clear();
            //logs_metroGrid.Columns.Clear();
            //logs_metroGrid.Refresh();

            logs_metroGrid.DataSource = await logController.SearchLogsAsync(userId, parametr);
            if (logs_metroGrid.DataSource != null || logs_metroGrid.Rows.Count > 0)
            {
                logs_metroGrid.Visible = true;
                info_textBox.Visible = false;
                logs_metroGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                logs_metroGrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                logs_metroGrid.Columns[0].Visible = false;
                logs_metroGrid.Columns[1].HeaderText = "Время";
                logs_metroGrid.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                logs_metroGrid.Columns[1].Width = (int)(logs_metroGrid.Width * 0.15);
                logs_metroGrid.Columns[2].HeaderText = "Пользователь";
                logs_metroGrid.Columns[2].Width = (int)(logs_metroGrid.Width * 0.15);
                logs_metroGrid.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                logs_metroGrid.Columns[3].HeaderText = "Лог";
                logs_metroGrid.Columns[3].Width = logs_metroGrid.Width - logs_metroGrid.Columns[1].Width - logs_metroGrid.Columns[2].Width;
            }
        }

        private async void FilterLog(string parametr)
        {
            info_textBox.Visible = true;
            logs_metroGrid.Visible = false;

            //logs_metroGrid.Rows.Clear();
            //logs_metroGrid.Columns.Clear();
            //logs_metroGrid.Refresh();

            logs_metroGrid.DataSource = await logController.FilterLogsAsync(parametr);
            if (logs_metroGrid.DataSource != null || logs_metroGrid.Rows.Count > 0)
            {
                logs_metroGrid.Visible = true;
                info_textBox.Visible = false;
                logs_metroGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                logs_metroGrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                logs_metroGrid.Columns[0].Visible = false;
                logs_metroGrid.Columns[1].HeaderText = "Время";
                logs_metroGrid.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                logs_metroGrid.Columns[1].Width = (int)(logs_metroGrid.Width * 0.15);
                logs_metroGrid.Columns[2].HeaderText = "Пользователь";
                logs_metroGrid.Columns[2].Width = (int)(logs_metroGrid.Width * 0.15);
                logs_metroGrid.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                logs_metroGrid.Columns[3].HeaderText = "Лог";
                logs_metroGrid.Columns[3].Width = logs_metroGrid.Width - logs_metroGrid.Columns[1].Width - logs_metroGrid.Columns[2].Width;
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            SearchLog((int)users_metroComboBox.SelectedValue, searchText_metroTextBox.Text);
        }

        private void search_metroRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton checkBox = sender as RadioButton;
            if (checkBox == null) return;
            if (checkBox.Checked)
            {
                search_metroPanel.Enabled = true;
                metroLabel1.ForeColor = Color.Black;
                metroLabel2.ForeColor = Color.Black;
                users_metroComboBox.BackColor = Color.White;
                searchText_metroTextBox.BackColor = Color.White;
                metroDateTime.Enabled = false;
            }
            else
            {
                search_metroPanel.Enabled = false;
                metroLabel1.ForeColor = Color.LightGray;
                metroLabel2.ForeColor = Color.LightGray;
                users_metroComboBox.BackColor = Color.LightGray;
                searchText_metroTextBox.BackColor = Color.LightGray;
                searchText_metroTextBox.Clear();
                metroDateTime.Enabled = true;
                GetDataSource(metroDateTime.Value);
            }
        }


        private void search_metroRadioButton_MouseClick(object sender, MouseEventArgs e)
        {
            RadioButton checkBox = sender as RadioButton;
            if (checkBox == null) return;
            checkBox.Checked = !checkBox.Checked;
        }

        private void filter_metroTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            MetroTextBox textBox = sender as MetroTextBox;
            if (textBox == null) return;
            FilterLog(textBox.Text);
        }
    
    }
}
