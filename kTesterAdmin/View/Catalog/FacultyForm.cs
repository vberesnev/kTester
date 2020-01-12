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
            GetDataSource();
        }

        private void addFaculty_button_Click(object sender, EventArgs e)
        {
            message("Добавление факультета, подождите . . . ");
            facultyController.AddFacultyAsync("Механико-механический");
        }

        private void DeleteFaculty(int id, int row)
        {
            message("Удаление факультета . . .");
            if (facultyController.DeleteFacultyAsync(id).Result)
            {
                faculties_dataGridView.Rows.RemoveAt(row);
                faculties_dataGridView.Refresh();
            }

        }


        private void GetDataSource()
        {
            faculties_dataGridView.Rows.Clear();
            faculties_dataGridView.Columns.Clear();
            faculties_dataGridView.Refresh();

            faculties_dataGridView.DataSource = facultyController.GetFacultiesAsync().Result;
            faculties_dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            faculties_dataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;


            faculties_dataGridView.Columns[0].Visible = false;
            faculties_dataGridView.Columns[1].Width = 200;
            faculties_dataGridView.Columns[1].HeaderText = "Факультет";
            faculties_dataGridView.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewCellStyle imgStyle = new DataGridViewCellStyle();
            imgStyle.Padding = new Padding(0, 5, 0, 5);

            faculties_dataGridView.Columns.Add(new DataGridViewImageColumn()
            {
                Image = new Bitmap(global::kTesterAdmin.Properties.Resources.edit, new Size(20, 20)),
                Width = 50,
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                DefaultCellStyle = new DataGridViewCellStyle(imgStyle),
                ToolTipText = "Редактировать",
            });

            faculties_dataGridView.Columns.Add(new DataGridViewImageColumn()
            {
                Image = new Bitmap(global::kTesterAdmin.Properties.Resources.delete, new Size(20, 20)),
                Width = 50,
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                DefaultCellStyle = new DataGridViewCellStyle(imgStyle),
                ToolTipText = "Удалить",
            });




        }

        private void Btn_Click(object sender, EventArgs e)
        {
            int tag = (int)((Button)sender).Tag;
            message("Удаление факультета . . .");
            facultyController.DeleteFacultyAsync(tag);
        }

        

        private void faculties_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show($"Вы действительно хотите удалить факультет {faculties_dataGridView.Rows[e.RowIndex].Cells["Name"].Value}?",
                    "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    DeleteFaculty((int)faculties_dataGridView.Rows[e.RowIndex].Cells["Id"].Value, e.RowIndex);
                }
            }
        }
    }
}
