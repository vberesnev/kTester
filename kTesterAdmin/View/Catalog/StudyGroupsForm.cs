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
            FillGroupsDataGridView();
        }

        private async void GetFacultiesAsync()
        {
            var bindingSource = new BindingSource();
            bindingSource.DataSource = await searchController.GetFaculties();

            users_metroComboBox.DataSource = bindingSource;
            users_metroComboBox.DisplayMember = "Name";
            users_metroComboBox.ValueMember = "Id";
        }

        private void delete_metroTile_Click(object sender, EventArgs e)
        {
            if (studyGroups_metroGrid.SelectedRows.Count == 0) return;
            int row = studyGroups_metroGrid.SelectedRows[0].Index;
            if (studyGroups_metroGrid.Rows[row].Cells["Login"].Value.ToString() == "admin")
            {
                message("Нельзя удалять главного администратора");
                return;
            }
            if (MetroFramework.MetroMessageBox.Show(this, $"Вы действительно хотите удалить пользователя {studyGroups_metroGrid.Rows[row].Cells["Login"].Value}?",
                    "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DeleteStudyGroup((int)studyGroups_metroGrid.Rows[row].Cells["Id"].Value);
            }
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

        private void add_metroTile_Click(object sender, EventArgs e)
        {
            studyGroupController.SetCurrentItem();
            using (StudyGroupSingleForm SGSF = new StudyGroupSingleForm(studyGroupController))
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
            using (StudyGroupSingleForm SGSF = new StudyGroupSingleForm(studyGroupController))
            {
                SGSF.Owner = this.ParentForm;
                if (SGSF.ShowDialog() == DialogResult.OK)
                    GetDataSourceAsync();
            }
        }


        private void filter_metroTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            MetroTextBox textBox = sender as MetroTextBox;
            if (textBox == null) return;
            FilterLog(textBox.Text);
        }

        private void FilterLog(string parametr)
        {
            info_textBox.Visible = true;
            studyGroups_metroGrid.Visible = false;

            studyGroups_metroGrid.DataSource = studyGroupController.FilterItems(parametr);

            FillGroupsDataGridView();
        }

        private async void SearchGroups(int facultyId)
        {
            info_textBox.Visible = true;
            studyGroups_metroGrid.Visible = false;

            //studyGroups_metroGrid.DataSource = await studyGroupController.SearchLogs(facultyId);

            FillGroupsDataGridView();
        }

        private void FillGroupsDataGridView()
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
                studyGroups_metroGrid.Columns[1].Width = (int)(studyGroups_metroGrid.Width * 0.5);
                studyGroups_metroGrid.Columns[2].Visible = false;
                studyGroups_metroGrid.Columns[3].HeaderText = "Тип";
                studyGroups_metroGrid.Columns[3].Width = (int)(studyGroups_metroGrid.Width * 0.5);
                studyGroups_metroGrid.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }
    }
}
