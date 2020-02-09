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
    public partial class StudyGroupSingleForm : MetroFramework.Forms.MetroForm 
    {

        private StudyGroupController studyGroupController;
        private SearchController searchController;
        public StudyGroupSingleForm(StudyGroupController studyGroupController, SearchController searchController)
        {
            InitializeComponent();

            this.studyGroupController = studyGroupController;
            this.searchController = searchController;

            FillDataAsync();
        }


        private async void FillDataAsync()
        {
            var bindingSource = new BindingSource();
            bindingSource.DataSource = await searchController.GetFaculties();

            faculties_metroComboBox.DataSource = bindingSource;
            faculties_metroComboBox.DisplayMember = "Name";
            faculties_metroComboBox.ValueMember = "Id";

            if (studyGroupController.CurrentItem.Id == 0)
            {
                this.Text = "Добавить группу";
                quantity_metroTextBox.Text = "20";
            }
            else
            {
                this.Text = "Редактировать группу";
                name_metroTextBox.Text = studyGroupController.CurrentItem.Name;
                faculties_metroComboBox.SelectedValue = studyGroupController.CurrentItem.FacultyId;
                quantity_metroTextBox.Text = studyGroupController.CurrentItem.MenQuantity.ToString();
            }
        }

        private void save_metroButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(name_metroTextBox.Text) || (int)faculties_metroComboBox.SelectedValue == 0) return;
            int quantity;
            if (!Int32.TryParse(quantity_metroTextBox.Text, out quantity))
                return;

            bool result = false;
            result = studyGroupController.AddOrUpdateItemAsync(name_metroTextBox.Text, ((int)faculties_metroComboBox.SelectedValue).ToString(), quantity.ToString()).Result;
            if (result)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
