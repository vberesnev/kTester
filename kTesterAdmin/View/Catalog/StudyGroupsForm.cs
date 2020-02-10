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

namespace kTesterAdmin.View.Catalog
{
    public partial class StudyGroupsForm : MetroFramework.Controls.MetroUserControl
    {

        private StudyGroupController studyGroupController;
        private SearchController searchController;

        private Action<string> info;
        private Action<string> message;

        private BindingSource combobindingSource = new BindingSource();
        public StudyGroupsForm(Controller.AuthController userController)
        {
            info = new Action<string>((x) => BeginInvoke(new Action(() => info_textBox.Text = x)));
            message = new Action<string>((x) => BeginInvoke(new Action(() =>
            {
                MetroFramework.MetroMessageBox.Show(this, x,
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            })));

            studyGroupController = new StudyGroupController(info, message, userController);
            searchController = new SearchController(message, userController);
            InitializeComponent();
        }

        private void StudyGroupsForm_Load(object sender, EventArgs e)
        {
            info_textBox.Text = "Загрузка данных, подождите . . .";
            GetDataSourceAsync();
            GetFacultiesAsync();
        }

        private async void GetDataSourceAsync()
        {
            info_textBox.Visible = true;
            studyGroups_metroGrid.Visible = false;

            studyGroups_metroGrid.DataSource = await studyGroupController.GetDataAsync();
            FillDataGrid();
        }

        private async void GetFacultiesAsync()
        {
            combobindingSource.DataSource = await searchController.GetFaculties();
            faculties_metroComboBox.DataSource = combobindingSource;
            faculties_metroComboBox.DisplayMember = "Name";
            faculties_metroComboBox.ValueMember = "Id";
        }

        private void DeleteStudyGroup(int id)
        {
            info_textBox.Visible = true;
            studyGroups_metroGrid.Visible = false;
            info_textBox.Text = "Удаление, подождите . . .";
            studyGroupController.SetCurrentItem(id);

            if (studyGroupController.DeleteItemAsync().Result)
                GetDataSourceAsync();
        }


        private void filter_metroTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            MetroTextBox textBox = sender as MetroTextBox;
            if (textBox == null) return;
            FilterGroupsAsync(textBox.Text);
        }

        private async void FilterGroupsAsync(string parametr)
        {
            info_textBox.Visible = true;
            studyGroups_metroGrid.Visible = false;
            studyGroups_metroGrid.DataSource = await studyGroupController.FilterItems(parametr);
            FillDataGrid();
        }

        private async void SearchGroupsAsync(int facultyId)
        {
            info_textBox.Visible = true;
            studyGroups_metroGrid.Visible = false;

            studyGroups_metroGrid.DataSource = await studyGroupController.SearchStudyGroups(facultyId);

            FillDataGrid();
        }

        private void FillDataGrid()
        {
            if (studyGroups_metroGrid.DataSource != null || studyGroups_metroGrid.Rows.Count > 0)
            {
                studyGroups_metroGrid.Visible = true;
                info_textBox.Visible = false;
                studyGroups_metroGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                studyGroups_metroGrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                studyGroups_metroGrid.Columns[0].Visible = false;
                studyGroups_metroGrid.Columns[1].HeaderText = "Группа";
                studyGroups_metroGrid.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                studyGroups_metroGrid.Columns[1].Width = (int)(studyGroups_metroGrid.Width * 0.4);
                studyGroups_metroGrid.Columns[2].Visible = false;
                studyGroups_metroGrid.Columns[3].HeaderText = "Факультет";
                studyGroups_metroGrid.Columns[3].Width = (int)(studyGroups_metroGrid.Width * 0.5);
                studyGroups_metroGrid.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                studyGroups_metroGrid.Columns[4].HeaderText = "Людей";
                studyGroups_metroGrid.Columns[4].Width = studyGroups_metroGrid.Width - studyGroups_metroGrid.Columns[1].Width - studyGroups_metroGrid.Columns[2].Width;
                studyGroups_metroGrid.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void faculties_metroComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            MetroComboBox combo = sender as MetroComboBox;
            if (combo != null)
                SearchGroupsAsync((int)combo.SelectedValue);
        }

        private void add_metroTile_Click(object sender, EventArgs e)
        {
            studyGroupController.SetCurrentItem();
            using (StudyGroupSingleForm SGSF = new StudyGroupSingleForm(studyGroupController,  searchController))
            {
                SGSF.Owner = this.ParentForm;
                if (SGSF.ShowDialog() == DialogResult.OK)
                    GetDataSourceAsync();
            }
        }

        private void edit_metroTile_Click(object sender, EventArgs e)
        {
            if (studyGroups_metroGrid.SelectedRows.Count == 0) return;
            studyGroupController.SetCurrentItem((int)studyGroups_metroGrid.SelectedRows[0].Cells["Id"].Value);
            using (StudyGroupSingleForm USF = new StudyGroupSingleForm(studyGroupController, searchController))
            {
                USF.Owner = this.ParentForm;
                if (USF.ShowDialog() == DialogResult.OK)
                    GetDataSourceAsync();
            }
        }

        private void delete_metroTile_Click(object sender, EventArgs e)
        {
            if (studyGroups_metroGrid.SelectedRows.Count == 0) return;
            int row = studyGroups_metroGrid.SelectedRows[0].Index;

            if (MetroFramework.MetroMessageBox.Show(this, $"Вы действительно хотите удалить группу {studyGroups_metroGrid.Rows[row].Cells["Name"].Value}?",
                    "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DeleteStudyGroup((int)studyGroups_metroGrid.Rows[row].Cells["Id"].Value);
            }
        }
    }
}
