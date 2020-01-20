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
        private Action<string> info;
        public FacultyForm(string userName)
        {
            
            info = new Action<string>((x) => BeginInvoke(new Action(() => info_textBox.Text = x)));
            message = new Action<string>((x) => BeginInvoke(new Action(() =>
            {
                MetroFramework.MetroMessageBox.Show(this, x,
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            })));

            facultyController = new FacultyController(info, message, userName);
            InitializeComponent();
        }

        private void FacultyForm_Load(object sender, EventArgs e)
        {
            info_textBox.Text = "Загрузка данных, подождите . . .";
            info_textBox.Visible = true;
            faculties_metroGrid.Visible = false;
            GetDataSource();
        }

        private async void GetDataSource()
        {
            info_textBox.Visible = true;
            faculties_metroGrid.Visible = false;

            faculties_metroGrid.Rows.Clear();
            faculties_metroGrid.Columns.Clear();
            faculties_metroGrid.Refresh();

            faculties_metroGrid.DataSource = await facultyController.GetFacultiesAsync();
            if (faculties_metroGrid.DataSource != null || faculties_metroGrid.Rows.Count > 0)
            {
                faculties_metroGrid.Visible = true;
                info_textBox.Visible = false;              
                faculties_metroGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                faculties_metroGrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                faculties_metroGrid.Columns[0].Visible = false;
                faculties_metroGrid.Columns[1].Width = faculties_metroGrid.Width;
                faculties_metroGrid.Columns[1].HeaderText = "Факультет";
            }
        }

        private void delete_metroTile_Click(object sender, EventArgs e)
        {
            if (faculties_metroGrid.SelectedRows.Count == 0) return; 
            int row = faculties_metroGrid.SelectedRows[0].Index;
            if (MetroFramework.MetroMessageBox.Show(this, $"Вы действительно хотите удалить факультет {faculties_metroGrid.Rows[row].Cells["Name"].Value}?",
                    "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DeleteFaculty((int)faculties_metroGrid.Rows[row].Cells["Id"].Value);
            }
        }

        private void DeleteFaculty(int id)
        {
            info_textBox.Visible = true;
            faculties_metroGrid.Visible = false;
            info_textBox.Text = "Удаление, подождите . . .";
            facultyController.SetCurrentFaculty(id);


            if (facultyController.DeleteFacultyAsync().Result)
                GetDataSource();
        }

        private void add_metroTile_Click(object sender, EventArgs e)
        {
            facultyController.SetCurrentFaculty();
            using (FacultySingleForm FSF = new FacultySingleForm(facultyController))
            {
                FSF.Owner = this.ParentForm;
                if (FSF.ShowDialog() == DialogResult.OK)
                    GetDataSource();
            }
        }

        private void edit_metroTile_Click(object sender, EventArgs e)
        {
            if (faculties_metroGrid.SelectedRows.Count == 0) return;
            facultyController.SetCurrentFaculty((int)faculties_metroGrid.SelectedRows[0].Cells["Id"].Value);
            using (FacultySingleForm FSF = new FacultySingleForm(facultyController))
            {
                FSF.Owner = this.ParentForm;
                if (FSF.ShowDialog() == DialogResult.OK)
                    GetDataSource();
            }
        }
    }
}
