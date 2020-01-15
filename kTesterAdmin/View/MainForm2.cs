using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using kTesterAdmin.View;
using kTesterAdmin.View.Catalog;
using kTesterAdmin.Controller;


namespace kTesterAdmin.View
{
    public partial class MainForm2 : Form
    {
        private AuthController authController;
        public MainForm2(AuthController authController)
        {
            InitializeComponent();
            this.authController = authController;
            this.MinimumSize = new Size(650, 400);
        }

        //Удалить после окончания разработки
        public MainForm2() 
        {
            InitializeComponent();
            authController = new AuthController();
            authController.UserName = "admin";
        }

        private void facultyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<FacultyForm2>(new FacultyForm2(authController.UserName));
        }

        private void OpenForm<T>(T form)
            where T: Form
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
            form.MdiParent = this;
            form.Dock = DockStyle.Fill;
            form.Show();
        }
    }
    
}
