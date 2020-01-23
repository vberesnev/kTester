using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using kTesterLib.Service;

namespace kTesterServer
{
    static class ServerLog
    {
        private static string LOG_PATH = Path.Combine(System.Environment.CurrentDirectory, "Log");
        
        public static void Log(string text)
        {
            if (!Directory.Exists(LOG_PATH))
                Directory.CreateDirectory(LOG_PATH);

            string fileName = string.Concat(DateTime.Now.ToString("yyyy-MM-dd"), ".txt");
            string logText = string.Format("{0:G} - {1}{2}", DateTime.Now, text, "\r\n");
            File.AppendAllText(Path.Combine(LOG_PATH, fileName), logText, Encoding.UTF8);
        }

        public static void BaseLog(User user, string text)
        {
            DataBase.CreateLog(user, text);
        }
    }
}
