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
    public partial class LogsForm : UserControl
    {
        private LogController logController;
        private Action<string> info;

        public LogsForm(AuthController userController)
        {
            info = new Action<string>((x) => BeginInvoke(new Action(() => info_textBox.Text = x)));

            logController = new LogController(info,  userController);
            InitializeComponent();
        }

        private void LogsForm_Load(object sender, EventArgs e)
        {
            info_textBox.Text = "Загрузка данных, подождите . . .";
            info_textBox.Visible = true;
            logs_metroGrid.Visible = false;
            GetDataSource(DateTime.Now);
        }

        private async void GetDataSource(DateTime date)
        {
            info_textBox.Visible = true;
            logs_metroGrid.Visible = false;

            logs_metroGrid.Rows.Clear();
            logs_metroGrid.Columns.Clear();
            logs_metroGrid.Refresh();

            logs_metroGrid.DataSource = await logController.GetLogsByDateAsync(date);
            if (logs_metroGrid.DataSource != null || logs_metroGrid.Rows.Count > 0)
            {
                logs_metroGrid.Visible = true;
                info_textBox.Visible = false;
                logs_metroGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                logs_metroGrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                logs_metroGrid.Columns[0].Visible = false;
                //logs_metroGrid.Columns[1].Width = logs_metroGrid.Width;
                logs_metroGrid.Columns[1].HeaderText = "Время";
                logs_metroGrid.Columns[2].HeaderText = "Пользователь";
                logs_metroGrid.Columns[3].HeaderText = "Текст";
            }
        }
    }
}
