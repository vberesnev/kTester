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
    public partial class ProfessorsForm : MetroFramework.Controls.MetroUserControl
    {

        private ProfessorController professorController;
        private SearchController searchController;
        private Action<string> message;
        private Action<string> info;
        public ProfessorsForm(AuthController userController)
        {
            
            info = new Action<string>((x) => BeginInvoke(new Action(() => info_textBox.Text = x)));
            message = new Action<string>((x) => BeginInvoke(new Action(() =>
            {
                MetroFramework.MetroMessageBox.Show(this, x,
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            })));

            professorController = new ProfessorController(info, message, userController);
            searchController = new SearchController(message, userController);
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            info_textBox.Text = "Загрузка данных, подождите . . .";
            GetDataSourceAsync();
        }

        private async void GetDataSourceAsync()
        {
            info_textBox.Visible = true;
            professors_metroGrid.Visible = false;

            professors_metroGrid.DataSource = await professorController.GetDataAsync();
            FillDataGrid();
        }

        private void filter_metroTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            MetroTextBox textBox = sender as MetroTextBox;
            if (textBox == null) return;
            Filter(textBox.Text);
        }

        private async void Filter(string parametr)
        {
            info_textBox.Visible = true;
            professors_metroGrid.Visible = false;

            professors_metroGrid.DataSource = await professorController.FilterItems(parametr);
            FillDataGrid();
        }

        private void FillDataGrid()
        {
            if (professors_metroGrid.DataSource != null || professors_metroGrid.Rows.Count > 0)
            {
                professors_metroGrid.Visible = true;
                info_textBox.Visible = false;
                professors_metroGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                professors_metroGrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                professors_metroGrid.Columns[0].Visible = false;
                professors_metroGrid.Columns[1].HeaderText = "ФИО";
                professors_metroGrid.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                professors_metroGrid.Columns[1].Width = (int)(professors_metroGrid.Width * 0.5);
                professors_metroGrid.Columns[2].Visible = false;
                professors_metroGrid.Columns[3].HeaderText = "Логин";
                professors_metroGrid.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                professors_metroGrid.Columns[3].Width = (int)(professors_metroGrid.Width * 0.5);
            }
        }

        private void delete_metroTile_Click(object sender, EventArgs e)
        {
            if (professors_metroGrid.SelectedRows.Count == 0) return; 
            int row = professors_metroGrid.SelectedRows[0].Index;
            if (MetroFramework.MetroMessageBox.Show(this, $"Вы действительно хотите удалить факультет {professors_metroGrid.Rows[row].Cells["Name"].Value}?",
                    "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Delete((int)professors_metroGrid.Rows[row].Cells["Id"].Value);
            }
        }

        private void Delete(int id)
        {
            info_textBox.Visible = true;
            professors_metroGrid.Visible = false;
            info_textBox.Text = "Удаление, подождите . . .";
            professorController.SetCurrentItem(id);


            if (professorController.DeleteItemAsync().Result)
                GetDataSourceAsync();
        }

        private void add_metroTile_Click(object sender, EventArgs e)
        {
            professorController.SetCurrentItem();
            using (ProfessorSingleForm PSF = new ProfessorSingleForm(professorController, searchController))
            {
                PSF.Owner = this.ParentForm;
                if (PSF.ShowDialog() == DialogResult.OK)
                    GetDataSourceAsync();
            }
        }

        private void edit_metroTile_Click(object sender, EventArgs e)
        {
            if (professors_metroGrid.SelectedRows.Count == 0) return;
            professorController.SetCurrentItem((int)professors_metroGrid.SelectedRows[0].Cells["Id"].Value);
            using (ProfessorSingleForm PSF = new ProfessorSingleForm(professorController, searchController))
            {
                PSF.Owner = this.ParentForm;
                if (PSF.ShowDialog() == DialogResult.OK)
                    GetDataSourceAsync();
            }
        }

        


    }
}
