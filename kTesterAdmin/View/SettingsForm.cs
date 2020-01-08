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

namespace kTesterAdmin.View
{
    public partial class SettingsForm : Form
    {
        SettingsController controller;
        public SettingsForm()
        {
            InitializeComponent();
            controller = new SettingsController();
            serverIP_textBox.Text = controller.Ip();
            serverPort_textBox.Text = controller.Port().ToString();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            int port = 0;
            if (IsIpCorrect(serverIP_textBox.Text) && Int32.TryParse(serverPort_textBox.Text, out port))
            {
                controller.SaveSettings(port, serverIP_textBox.Text.Replace(",","."));
                this.Close();
            }
            else
                MessageBox.Show("Введены неверные данные");
        }

        /// <summary>
        /// Проверка на верность IP адреса 
        /// </summary>
        /// <param name="ipString">IP адрес в строку</param>
        /// <returns></returns>
        private bool IsIpCorrect(string ipString)
        {
            try
            {
                ipString = ipString.Replace(",", ".");
                string[] ipArr = ipString.Split('.');
                for (int i = 0; i < 3; i++)
                {
                    byte okted = Convert.ToByte(ipArr[i]);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
