using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kTesterAdmin.Model;

namespace kTesterAdmin.Controller
{
    class SettingsController
    {
        
        internal void SaveSettings(int port, string ip)
        {
            Settings.GetSettings().Ip = ip;
            Settings.GetSettings().Port = port;
            Settings.Save();
        }

        public string Ip()
        {
            return Settings.GetSettings().Ip;
        }

        public int Port()
        {
            return Settings.GetSettings().Port;
        }
    }
}
