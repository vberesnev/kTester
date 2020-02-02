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
    class LogController: DefaultController<Log>
    {
        public LogController(Action<string> info, Action<string> mess, AuthController userController)
            : base(info, mess, userController)
        {
            serverParametrsDict = new Dictionary<string, string>()
            {
                {"getLogsByDate", "LOG_DAT" },
                {"getLogsByParams", "LOG_PRM" },
                {"getLogsByText", "LOG_TXT" }
            };
        }

        internal Task<BindingList<Log>> GetLogsByDate(DateTime date)
        {
            serverParametr = serverParametrsDict["getLogsByDate"];
            queryParametrsDict.Clear();

            queryParametrsDict.Add("@dateBegin", new DateTime(date.Year, date.Month, date.Day, 0, 0, 0).ToString("yyyyMMdd HH:mm:ss"));
            queryParametrsDict.Add("@dateEnd", new DateTime(date.Year, date.Month, date.Day, 23, 59, 59).ToString("yyyyMMdd HH:mm:ss"));

            var task = GetTask();
            task.Start();
            return task;
        }

        internal  Task<BindingList<Log>> SearchLogs(int userId, string paramert)
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

        internal override Task<BindingList<Log>> FilterItems(string paramert)
        {
            Task<BindingList<Log>> task;
            if (string.IsNullOrEmpty(paramert) || string.IsNullOrWhiteSpace(paramert)) 
            {
                task = new Task<BindingList<Log>>(() =>
                {
                    information(items.Count.ToString());
                    return DataSourse = new BindingList<Log>(items);
                });
            }
            else
            {
                task =  new Task<BindingList<Log>>(() =>
                {
                    information(items.Count.ToString());
                    List<Log> filterList = items.Where(x => x.Text.Contains(paramert) || x.User.Login.Contains(paramert)).ToList();
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
                        items.Clear();
                        List<object[]> list = JsonConvert.DeserializeObject<List<object[]>>(result.Item2);
                        foreach (var arr in list)
                            items.Add(new Log(Convert.ToInt32(arr[0]), Convert.ToDateTime(arr[1]), arr[2].ToString(), Convert.ToInt32(arr[3]), arr[4].ToString()));

                        if (items.Count == 0)
                            information("Нет ниодного лога");
                        else
                            DataSourse = new BindingList<Log>(items);
                    }
                    else
                        information($"Ошибка получения данных:\r\n{result.Item2}\r\nОбратитесь к администратору");

                    return DataSourse;
                });
        }
    }
}
