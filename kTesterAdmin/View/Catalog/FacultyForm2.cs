using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using kTesterAdmin.Controller;

namespace kTesterAdmin.View.Catalog
{
    public partial class FacultyForm2 : Form
    {
        private FacultyController facultyController;
        private Action<string> message;
        public FacultyForm2(string userName)
        {
            InitializeComponent();
            message = new Action<string> ((x) => BeginInvoke( new Action(() => info_label.Text = x)));
            //facultyController = new FacultyController(message, userName);
        }

        private void FacultyForm_Load(object sender, EventArgs e)
        {
            message("Загрузка данных, подождите . . . ");
            GetDataSource();
            message("");
        }

        private async void GetDataSource()
        {
            faculties_dataGridView.Rows.Clear();
            faculties_dataGridView.Columns.Clear();
            faculties_dataGridView.Refresh();

            faculties_dataGridView.DataSource = await facultyController.GetFacultiesAsync();
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

        

        private void DeleteFaculty(int id, int row)
        {
            //message("Удаление факультета . . .");
            //if (facultyController.DeleteFacultyAsync(id).Result)
            //{
            //    GetDataSource();
            //}
        }

        private void faculties_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                if (MessageBox.Show($"Вы действительно хотите удалить факультет {faculties_dataGridView.Rows[e.RowIndex].Cells["Name"].Value}?",
                    "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    DeleteFaculty((int)faculties_dataGridView.Rows[e.RowIndex].Cells["Id"].Value, e.RowIndex);
                }
            }
            
            if (e.ColumnIndex == 2)
            {
                faculty_panel.Visible = true;
                id_textBox.Text = faculties_dataGridView.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                name_textBox.Text = faculties_dataGridView.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            }
        }

        private void addFaculty_button_Click(object sender, EventArgs e)
        {
            faculty_panel.Visible = true;
            id_textBox.Text = "0";
            addFaculty_button.Visible = false;
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            faculty_panel.Visible = false;
            name_textBox.Clear();
            id_textBox.Clear();
            addFaculty_button.Visible = true;

        }

        private async void save_button_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(name_textBox.Text))
            //{
            //    name_textBox.BackColor = System.Drawing.Color.LightCoral;
            //    return;
            //}

            //int id = 0;
            //if (Int32.TryParse(id_textBox.Text, out id))
            //{
            //    if (id == 0)
            //    {
            //        if (await facultyController.AddFacultyAsync(name_textBox.Text) > 0)
            //            GetDataSource();
            //    }
            //    else
            //    {
            //        if (await facultyController.EditFacultyAsync(id_textBox.Text, name_textBox.Text))
            //            GetDataSource();
            //    } 
            //}
            //else
            //    message("Ошибка сохранения данных, введен строчный идентификатор\r\nОбратитесь к администратору");

            addFaculty_button.Visible = true;
            faculty_panel.Visible = false;
            id_textBox.Clear();
            name_textBox.Clear();

        }
    }
}
