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

namespace kTesterAdmin.View.Catalog
{
    public partial class FacultyForm : MetroFramework.Controls.MetroUserControl
    {

        private FacultyController facultyController;
        private Action<string> message;
        public FacultyForm(string userName)
        {
            message = new Action<string>((x) => BeginInvoke(new Action(() => info_metroLabel.Text = x)));
            facultyController = new FacultyController(message, userName);
            InitializeComponent();
            
            
        }

        private void FacultyForm_Load(object sender, EventArgs e)
        {
            message("Загрузка данных, подождите . . . ");
            GetDataSource();
            message("");
        }

        private async void GetDataSource()
        {
            faculties_metroGrid.Rows.Clear();
            faculties_metroGrid.Columns.Clear();
            faculties_metroGrid.Refresh();

            faculties_metroGrid.DataSource = await facultyController.GetFacultiesAsync();
            faculties_metroGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            faculties_metroGrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;


            faculties_metroGrid.Columns[0].Visible = false;
            faculties_metroGrid.Columns[1].Width = faculties_metroGrid.Width;
            faculties_metroGrid.Columns[1].HeaderText = "Факультет";
            //faculties_metroGrid.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            
        }
    }
}
