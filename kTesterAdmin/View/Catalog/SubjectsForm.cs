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
    public partial class SubjectsForm : MetroFramework.Controls.MetroUserControl
    {

        private SubjectController subjectController;
        private Action<string> message;
        private Action<string> info;
        public SubjectsForm(AuthController userController)
        {
            
            info = new Action<string>((x) => BeginInvoke(new Action(() => info_textBox.Text = x)));
            message = new Action<string>((x) => BeginInvoke(new Action(() =>
            {
                MetroFramework.MetroMessageBox.Show(this, x,
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            })));

            subjectController = new SubjectController(info, message, userController);
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
            subjects_metroGrid.Visible = false;

            subjects_metroGrid.DataSource = await subjectController.GetDataAsync();
            if (subjects_metroGrid.DataSource != null || subjects_metroGrid.Rows.Count > 0)
            {
                subjects_metroGrid.Visible = true;
                info_textBox.Visible = false;              
                subjects_metroGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                subjects_metroGrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                subjects_metroGrid.Columns[0].Visible = false;
                subjects_metroGrid.Columns[1].HeaderText = "Предмет";
            }
        }

        private void delete_metroTile_Click(object sender, EventArgs e)
        {
            if (subjects_metroGrid.SelectedRows.Count == 0) return; 
            int row = subjects_metroGrid.SelectedRows[0].Index;
            if (MetroFramework.MetroMessageBox.Show(this, $"Вы действительно хотите удалить факультет {subjects_metroGrid.Rows[row].Cells["Name"].Value}?",
                    "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Delete((int)subjects_metroGrid.Rows[row].Cells["Id"].Value);
            }
        }

        private void Delete(int id)
        {
            info_textBox.Visible = true;
            subjects_metroGrid.Visible = false;
            info_textBox.Text = "Удаление, подождите . . .";
            subjectController.SetCurrentItem(id);


            if (subjectController.DeleteItemAsync().Result)
                GetDataSourceAsync();
        }

        private void add_metroTile_Click(object sender, EventArgs e)
        {
            subjectController.SetCurrentItem();
            using (SubjectSingleForm SSF = new SubjectSingleForm(subjectController))
            {
                SSF.Owner = this.ParentForm;
                if (SSF.ShowDialog() == DialogResult.OK)
                    GetDataSourceAsync();
            }
        }

        private void edit_metroTile_Click(object sender, EventArgs e)
        {
            if (subjects_metroGrid.SelectedRows.Count == 0) return;
            subjectController.SetCurrentItem((int)subjects_metroGrid.SelectedRows[0].Cells["Id"].Value);
            using (SubjectSingleForm SSF = new SubjectSingleForm(subjectController))
            {
                SSF.Owner = this.ParentForm;
                if (SSF.ShowDialog() == DialogResult.OK)
                    GetDataSourceAsync();
            }
        }
    }
}
