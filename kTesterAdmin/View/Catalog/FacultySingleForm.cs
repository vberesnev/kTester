using MetroFramework.Controls;
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
    public partial class FacultySingleForm : MetroFramework.Forms.MetroForm 
    {
        private FacultyController facultyController;

        public FacultySingleForm(FacultyController facultyController)
        {
            InitializeComponent();
            this.facultyController = facultyController;

            if (facultyController.CurrentItem.Id == 0)
                this.Text = "Добавить факультет";
            else
            {
                this.Text = "Редактировать факультет";
                faculty_metroTextBox.Text = facultyController.CurrentItem.Name;
            }
                
        }

        private void save_metroButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(faculty_metroTextBox.Text)) return;

            bool result = false;
            result = facultyController.AddOrUpdateItemAsync(faculty_metroTextBox.Text).Result;
            if (result)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            } 
        }
    }
}
