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
    public partial class SubjectSingleForm : MetroFramework.Forms.MetroForm 
    {
        private SubjectController subjectController;

        public SubjectSingleForm(SubjectController subjectController)
        {
            InitializeComponent();
            this.subjectController = subjectController;

            if (subjectController.CurrentItem.Id == 0)
                this.Text = "Добавить предмет";
            else
            {
                this.Text = "Редактировать предмет";
                faculty_metroTextBox.Text = subjectController.CurrentItem.Name;
            }
        }

        private void save_metroButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(faculty_metroTextBox.Text)) return;

            bool result = false;
            result = subjectController.AddOrUpdateItemAsync(faculty_metroTextBox.Text).Result;
            if (result)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            } 
        }
    }
}
