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

namespace kTesterAdmin.View.Catalog
{
    public partial class FacultyForm : Form
    {
        private FacultyController facultyController;
        private Action<string> message;
        public FacultyForm(string userName)
        {
            InitializeComponent();
            message = new Action<string> ((x) => BeginInvoke( new Action(() => info_label.Text = x)));
            facultyController = new FacultyController(message, userName);

        }

        private void FacultyForm_Load(object sender, EventArgs e)
        {
            message("Загрузка данных, подождите . . . ");
            facultyController.GetFacultiesAsync();
        }
    }
}
