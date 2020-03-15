using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Components;
using MetroFramework.Forms;
using kTesterAdmin.View.Menu;
using kTesterAdmin.View.Catalog;
using kTesterAdmin.View.Tests;
using kTesterAdmin.Controller;

namespace kTesterAdmin.View
{
    public partial class MainForm : MetroForm
    {
        private AuthController userInfo;

        public MainForm(AuthController authController)
        {
            InitializeComponent();
            this.userInfo = authController;
            this.MinimumSize = new Size(650, 400);
            OpenAdminMenu(this, null);
        }

        //Удалить после окончания разработки
        public MainForm()
        {
            InitializeComponent();

            //userInfo = new AuthController(1, "admin", "admin", 1);
            userInfo = new AuthController(1004, "prof3", 2, "проф3");
            this.MinimumSize = new Size(650, 400);
            OpenAdminMenu(this, null);
        }

        private void OpenAdminMenu(object sender, EventArgs e)
        {
            AdminMenu AM = new AdminMenu();
            AM.tests_metroTile.Click += OpenTests;
            AM.users_metroTile.Click += OpenUsers;
            AM.catalogs_metroTile.Click += OpenCatalogs;
            AM.logs_metroTile.Click += OpenLogs;
            menu_metroPanel.Controls.Clear();
            menu_metroPanel.Controls.Add(AM);
        }

        private void OpenLogs(object sender, EventArgs e)
        {
            this.Text = "kTester - Логи";
            this.Refresh();
            LogsForm LF = new LogsForm(userInfo);
            content_metroPanel.Controls.Clear();
            content_metroPanel.Controls.Add(LF);
            LF.Dock = DockStyle.Fill;
        }

        private void OpenUsers(object sender, EventArgs e)
        {
            this.Text = "kTester - Пользователи";
            this.Refresh();
            UsersForm UF = new UsersForm(userInfo);
            content_metroPanel.Controls.Clear();
            content_metroPanel.Controls.Add(UF);
            UF.Dock = DockStyle.Fill;
        }

        private void OpenTests(object sender, EventArgs e)
        {
            this.Text = "kTester - Тесты";
            this.Refresh();
            TestsForm TF = new TestsForm(userInfo);
            content_metroPanel.Controls.Clear();
            content_metroPanel.Controls.Add(TF);
            TF.Dock = DockStyle.Fill;
        }

        private void OpenCatalogs(object sender, EventArgs e)
        {
            CatalogMenu CM = new CatalogMenu();
            CM.facults_metroTile.Click += OpenFaculties;
            CM.stusyGroups_metroTile.Click += OpenStudyGroups;
            CM.subjects_metroTile.Click += Subjects_metroTile_Click;
            CM.back_metroTile.Click += OpenAdminMenu;
            menu_metroPanel.Controls.Clear();
            menu_metroPanel.Controls.Add(CM);
        }

        private void Subjects_metroTile_Click(object sender, EventArgs e)
        {
            this.Text = "kTester - Справочники - Предметы";
            this.Refresh();
            SubjectsForm SF = new SubjectsForm(userInfo);
            content_metroPanel.Controls.Clear();
            content_metroPanel.Controls.Add(SF);
            SF.Dock = DockStyle.Fill;
        }

        private void OpenStudyGroups(object sender, EventArgs e)
        {
            this.Text = "kTester - Справочники - Учебные группы";
            this.Refresh();
            StudyGroupsForm SGF = new StudyGroupsForm(userInfo);
            content_metroPanel.Controls.Clear();
            content_metroPanel.Controls.Add(SGF);
            SGF.Dock = DockStyle.Fill;
        }

        private void OpenFaculties(object sender, EventArgs e)
        {
            this.Text = "kTester - Справочники - Факультеты";
            this.Refresh();
            FacultiesForm FF = new FacultiesForm(userInfo);
            content_metroPanel.Controls.Clear();
            content_metroPanel.Controls.Add(FF);
            FF.Dock = DockStyle.Fill;
        }
    }
}
