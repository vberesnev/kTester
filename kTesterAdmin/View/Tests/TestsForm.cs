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
    public partial class TestsForm : UserControl
    {
        private AuthController userInfo;
        private TestController testController;

        private Action<string> info;
        private Action<string> message;

        private TestListForm TLF;

        public TestsForm(AuthController userInfo)
        {
            message = new Action<string>((x) => BeginInvoke(new Action(() =>
            {
                MetroFramework.MetroMessageBox.Show(this, x,
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            })));

            this.userInfo = userInfo;
            testController = new TestController(info, message, userInfo);

            InitializeComponent();
            
        }

        private void OpenTestsList()
        {
            TLF = new TestListForm(testController);
            tests_metroPanel.Controls.Clear();
            tests_metroPanel.Controls.Add(TLF);
            TLF.Dock = DockStyle.Fill;
            VisibleButton(true);
        }


        private void add_metroTile_Click(object sender, EventArgs e)
        {
            //VisibleButton(false);
            
            MessageBox.Show(TLF.SetCurrent.Invoke().ToString());
        }

        private void VisibleButton(bool visible)
        {
            add_metroTile.Visible = visible;
            edit_metroTile.Visible = visible;
            delete_metroTile.Visible = visible;
            open_metroTile.Visible = visible;
        }

        private void TestsForm_Load(object sender, EventArgs e)
        {
            OpenTestsList();
        }

        private void delete_metroTile_Click(object sender, EventArgs e)
        {
            var result = TLF.SetCurrent();
            if (!result.Item1) return;

            if (MetroFramework.MetroMessageBox.Show(this, $"Вы действительно хотите удалить тест {result.Item1}?",
                    "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Delete();
            }
        }

        private void Delete()
        {
            TLF.info_textBox.Visible = true;
            TLF.tests_metroGrid.Visible = false;
            TLF.info_textBox.Text = "Удаление, подождите . . .";

            testController.DeleteItemAsync();
            OpenTestsList();
        }
    }
}
