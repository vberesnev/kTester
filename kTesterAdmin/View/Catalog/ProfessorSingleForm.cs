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
    public partial class ProfessorSingleForm : MetroFramework.Forms.MetroForm 
    {
        private ProfessorController professorController;
        private SearchController searchController;

        public ProfessorSingleForm(ProfessorController professorController, SearchController searchController)
        {
            InitializeComponent();
            this.professorController = professorController;
            this.searchController = searchController;

            FillDataAsync();

        }

        private async void FillDataAsync()
        {
            var bindingSource = new BindingSource();
            bindingSource.DataSource = await searchController.GetUsers();

            user_metroComboBox.DataSource = bindingSource;
            user_metroComboBox.DisplayMember = "Login";
            user_metroComboBox.ValueMember = "Id";

            if (professorController.CurrentItem.Id == 0)
                this.Text = "Добавить преподавателя";
            else
            {
                this.Text = "Редактировать преподавателя";
                name_metroTextBox.Text = professorController.CurrentItem.Name;
                user_metroComboBox.SelectedValue = professorController.CurrentItem.UserId;
            }
        }

        private void save_metroButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(name_metroTextBox.Text) || (int)user_metroComboBox.SelectedValue == 0) return;

            bool result = false;
            result = professorController.AddOrUpdateItemAsync(name_metroTextBox.Text, ((int)user_metroComboBox.SelectedValue).ToString()).Result;
            if (result)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            } 
        }
    }
}
