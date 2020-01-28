﻿using System;
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
            metroDateTime.Value = DateTime.Now;
            //GetDataSource(DateTime.Now);
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

        private void metroDateTime_ValueChanged(object sender, EventArgs e)
        {
            GetDataSource(metroDateTime.Value);
        }

        private async void FilterLog(string parametr)
        {
            info_textBox.Visible = true;
            logs_metroGrid.Visible = false;

            logs_metroGrid.Rows.Clear();
            logs_metroGrid.Columns.Clear();
            logs_metroGrid.Refresh();

            logs_metroGrid.DataSource = await logController.GetLogsByFilterAsync(parametr);
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
            FilterLog("фак");
        }
    }
}
