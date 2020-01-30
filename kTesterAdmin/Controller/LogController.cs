using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kTesterLib.Service;
using Newtonsoft.Json;

namespace kTesterAdmin.Controller
{
    class LogController
    {
        private Action<string> info;
        private AuthController userController;


        [JsonRequired]
        private string serverParametr;

        [JsonRequired]
        private User currentUser;

        [JsonRequired]
        private Dictionary<string, string> queryParametrsDict;

        
        private List<Log> logs;
        private Dictionary<string, string> serverParametrsDict;

        [JsonIgnore]
        public BindingList<Log> DataSourse;

        public LogController(Action<string> info, AuthController userController)
        {
            logs = new List<Log>();
            this.info = info;
            currentUser = userController.GetUser();

            serverParametrsDict = new Dictionary<string, string>()
            {
                {"getLogsByDate", "LOG_DAT" },
                {"getLogsByParams", "LOG_PRM" },
                {"getLogsByText", "LOG_TXT" }
            };

            queryParametrsDict = new Dictionary<string, string>();
        }

        internal Task<BindingList<Log>> GetLogsByDateAsync(DateTime date)
        {
            serverParametr = serverParametrsDict["getLogsByDate"];
            queryParametrsDict.Clear();

            queryParametrsDict.Add("@dateBegin", new DateTime(date.Year, date.Month, date.Day, 0, 0, 0).ToString("yyyyMMdd HH:mm:ss"));
            queryParametrsDict.Add("@dateEnd", new DateTime(date.Year, date.Month, date.Day, 23, 59, 59).ToString("yyyyMMdd HH:mm:ss"));

            var task = GetTask();
            task.Start();
            return task;
        }

        internal Task<BindingList<Log>> SearchLogsAsync(int userId, string paramert)
        {
            if (string.IsNullOrEmpty(paramert) || string.IsNullOrWhiteSpace(paramert))
                paramert = "";

            serverParametr = serverParametrsDict["getLogsByParams"];

            queryParametrsDict.Clear();

            queryParametrsDict.Add("@userId", userId.ToString());
            queryParametrsDict.Add("@parametr", "%" + paramert + "%");
            var task = GetTask();
            task.Start();
            return task;
        }

        internal Task<BindingList<Log>> FilterLogsAsync(string paramert)
        {
            Task<BindingList<Log>> task;
            if (string.IsNullOrEmpty(paramert) || string.IsNullOrWhiteSpace(paramert)) 
            {
                task = new Task<BindingList<Log>>(() =>
                {
                    info(logs.Count.ToString());
                    return DataSourse = new BindingList<Log>(logs);
                });
            }
            else
            {
                task =  new Task<BindingList<Log>>(() =>
                {
                    info(logs.Count.ToString());
                    List<Log> filterList = logs.Where(x => x.Text.Contains(paramert) || x.User.Login.Contains(paramert)).ToList();
                    return DataSourse = new BindingList<Log>(filterList);
                });
            }
            task.Start();
            return task; 
        }

        private Task<BindingList<Log>> GetTask()
        {
            return new Task<BindingList<Log>>(
                () =>
                {
                    Tuple<bool, string> result = RequestSender.SendRequest(JsonConvert.SerializeObject(this));
                    DataSourse = null;
                    if (result.Item1)
                    {
                        logs.Clear();
                        List<object[]> list = JsonConvert.DeserializeObject<List<object[]>>(result.Item2);
                        foreach (var arr in list)
                            logs.Add(new Log(Convert.ToInt32(arr[0]), Convert.ToDateTime(arr[1]), arr[2].ToString(), Convert.ToInt32(arr[3]), arr[4].ToString()));

                        if (logs.Count == 0)
                            info("Нет ниодного лога");
                        else
                            DataSourse = new BindingList<Log>(logs);
                    }
                    else
                        info($"Ошибка получения данных:\r\n{result.Item2}\r\nОбратитесь к администратору");

                    return DataSourse;
                });
        }
    }
}
