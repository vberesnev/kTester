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

namespace kTesterAdmin.View.Tests
{
    public partial class TestListForm : UserControl
    {
        private TestController testController;

        private Action<string> info;

        public Func<Tuple<bool, string>> SetCurrent;
        public Action SetCurrentNull;

        public TestListForm(Controller.TestController testController)
        {
            info = new Action<string>((x) => BeginInvoke(new Action(() => info_textBox.Text = x)));
            this.testController = testController;
            this.testController.SetInformation(info);

            SetCurrent = new Func<Tuple<bool, string>>(() =>
            {
                if (tests_metroGrid.SelectedRows.Count == 0) return new Tuple<bool, string>(false, "");
                int row = tests_metroGrid.SelectedRows[0].Index;
                testController.SetCurrentItem(Convert.ToInt32(tests_metroGrid.Rows[row].Cells["Id"].Value));
                return new Tuple<bool, string>(true, tests_metroGrid.Rows[row].Cells["Title"].Value.ToString());
            });

            SetCurrentNull = new Action(() => testController.SetCurrentItem());

            InitializeComponent();
        }

        private void TestListForm_Load(object sender, EventArgs e)
        {
            info_textBox.Text = "Загрузка данных, подождите . . .";
            GetDataSourceAsync();
        }

        private async void GetDataSourceAsync()
        {
            info_textBox.Visible = true;
            tests_metroGrid.Visible = false;

            tests_metroGrid.DataSource = await testController.GetDataAsync();
            if (tests_metroGrid.DataSource != null || tests_metroGrid.Rows.Count > 0)
            {
                tests_metroGrid.Visible = true;
                info_textBox.Visible = false;
                tests_metroGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                tests_metroGrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                tests_metroGrid.Columns[0].Visible = false;
                tests_metroGrid.Columns[1].HeaderText = "Тест";
                tests_metroGrid.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                tests_metroGrid.Columns[1].Width = (int)(tests_metroGrid.Width * 0.5);
                tests_metroGrid.Columns[2].Visible = false;
                tests_metroGrid.Columns[3].HeaderText = "Тип";
                tests_metroGrid.Columns[3].Width = (int)(tests_metroGrid.Width * 0.5);
                tests_metroGrid.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }
    }
}
