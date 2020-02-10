using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using kTesterLib.Meta;
using kTesterLib.Service;
using Newtonsoft.Json;

namespace kTesterAdmin.Controller
{   
    public class ProfessorController: DefaultController<Professor>
    {
        public ProfessorController(Action<string> info, Action<string> mess, AuthController userController)
            :base (info, mess, userController)
        {
            serverParametrsDict = new Dictionary<string, string>()
            {
                {"getProfessor", "PRF_GET" },
                {"addProfessor", "PRF_ADD" },
                {"editProfessor", "PRF_EDT" },
                {"deleteProfessor", "PRF_DLT" }
            };
        }

        public override void SetCurrentItem(int id=0)
        {
            if (id == 0)
                CurrentItem = new Professor();
            else
                CurrentItem = items.FirstOrDefault(x => x.Id == id);
        }

        internal override Task<BindingList<Professor>> GetDataAsync()
        {
            serverParametr = serverParametrsDict["getProfessor"];
            queryParametrsDict.Clear();
            var task = new Task<BindingList<Professor>>(
                () => {
                    Tuple<bool, string> result = RequestSender.SendRequest(JsonConvert.SerializeObject(this));
                    DataSourse = null;
                    if (result.Item1)
                    {
                        items.Clear();
                        List<object[]> list = JsonConvert.DeserializeObject<List<object[]>>(result.Item2);
                        foreach (var arr in list)
                            items.Add(new Professor(Convert.ToInt32(arr[0]), arr[1].ToString(), Convert.ToInt32(arr[2]), arr[3].ToString()));

                        if (items.Count == 0)
                            message("Нет ниодного преподавателя. Добавьте данные");
                        DataSourse = new BindingList<Professor>(items);
                    }
                    else
                        information($"Ошибка получения данных:\r\n{result.Item2}\r\nОбратитесь к администратору");

                    return DataSourse;
                });
            task.Start();
            return task;
        }

        internal override Task<bool> AddOrUpdateItemAsync(params string[] parametrs)
        {
            queryParametrsDict.Clear();
            string actMessage = "";
            if (CurrentItem.Id == 0)
            {
                serverParametr = serverParametrsDict["addProfessor"];
                queryParametrsDict.Add("@name", parametrs[0]);
                queryParametrsDict.Add("@userId", parametrs[1]);
                actMessage = "добавления";
            }
            else
            {
                serverParametr = serverParametrsDict["editProfessor"];
                queryParametrsDict.Add("@id", CurrentItem.Id.ToString());
                queryParametrsDict.Add("@name", parametrs[0]);
                queryParametrsDict.Add("@userId", parametrs[1]);
                actMessage = "редактирования";
            }
            
            var task = new Task<bool>(
                () => {
                    Tuple<bool, string> result = RequestSender.SendRequest(JsonConvert.SerializeObject(this));
                    if (result.Item1)
                    {
                        int id = JsonConvert.DeserializeObject<int>(result.Item2);
                        if (id == 0)
                            message("Такой преподаватель уже существует");
                        return id > 0;
                    }
                    else
                        message($"Ошибка {actMessage} преподавателя:\r\n{result.Item2}\r\nОбратитесь к администратору");
                    return false;
                });
            task.Start();
            return task;
        }

        internal override Task<bool> DeleteItemAsync()
        {
            serverParametr = serverParametrsDict["deleteProfessor"];
            queryParametrsDict.Clear();
            queryParametrsDict.Add("@id", CurrentItem.Id.ToString());

            var task = new Task<bool>(
                () => {
                    Tuple<bool, string> result = RequestSender.SendRequest(JsonConvert.SerializeObject(this));
                    if (!result.Item1)
                    {
                        message($"Ошибка удаления преподавателя:\r\n{result.Item2}\r\nОбратитесь к администратору");
                        return false;
                    }
                    else
                        return true;
                });
            task.Start();
            return task;
        }

        internal override Task<BindingList<Professor>> FilterItems(string paramert)
        {
            Task<BindingList<Professor>> task;
            if (string.IsNullOrEmpty(paramert) || string.IsNullOrWhiteSpace(paramert))
            {
                task = new Task<BindingList<Professor>>(() =>
                {
                    information(items.Count.ToString());
                    return DataSourse = new BindingList<Professor>(items);
                });
            }
            else
            {
                task = new Task<BindingList<Professor>>(() =>
                {
                    information(items.Count.ToString());
                    List<Professor> filterList = items.Where(x => x.Name.ToLower().Contains(paramert.ToLower()) || x.User.Login.Contains(paramert)).ToList();
                    return DataSourse = new BindingList<Professor>(filterList);
                });
            }
            task.Start();
            return task;
        }
    }
}
