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
    public class SubjectController: DefaultController<Subject>
    {
        public SubjectController(Action<string> info, Action<string> mess, AuthController userController)
            :base (info, mess, userController)
        {
            serverParametrsDict = new Dictionary<string, string>()
            {
                {"getSubject", "SBJ_GET" },
                {"addSubject", "SBJ_ADD" },
                {"editSubject", "SBJ_EDT" },
                {"deleteSubject", "SBJ_DLT" }
            };
        }

        public override void SetCurrentItem(int id=0)
        {
            if (id == 0)
                CurrentItem = new Subject();
            else
                CurrentItem = items.FirstOrDefault(x => x.Id == id);
        }

        internal override Task<BindingList<Subject>> GetDataAsync()
        {
            serverParametr = serverParametrsDict["getSubject"];
            queryParametrsDict.Clear();
            var task = new Task<BindingList<Subject>>(
                () => {
                    Tuple<bool, string> result = RequestSender.SendRequest(JsonConvert.SerializeObject(this));
                    DataSourse = null;
                    if (result.Item1)
                    {
                        items.Clear();
                        List<object[]> list = JsonConvert.DeserializeObject<List<object[]>>(result.Item2);
                        foreach (var arr in list)
                            items.Add(new Subject(Convert.ToInt32(arr[0]), arr[1].ToString()));

                        if (items.Count == 0)
                            information("Нет ниодного учебного предмета. Добавьте данные");
                        DataSourse = new BindingList<Subject>(items);
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
                serverParametr = serverParametrsDict["addSubject"];
                queryParametrsDict.Add("@name", parametrs[0]);
                actMessage = "добавления";
            }
            else
            {
                serverParametr = serverParametrsDict["editSubject"];
                queryParametrsDict.Add("@id", CurrentItem.Id.ToString());
                queryParametrsDict.Add("@name", parametrs[0]);
                actMessage = "редактирования";
            }
            
            var task = new Task<bool>(
                () => {
                    Tuple<bool, string> result = RequestSender.SendRequest(JsonConvert.SerializeObject(this));
                    if (result.Item1)
                    {
                        int id = JsonConvert.DeserializeObject<int>(result.Item2);
                        if (id == 0)
                            message("Такой предмет уже существует");
                        return id > 0;
                    }
                    else
                        message($"Ошибка {actMessage} предмета:\r\n{result.Item2}\r\nОбратитесь к администратору");
                    return false;
                });
            task.Start();
            return task;
        }

        internal override Task<bool> DeleteItemAsync()
        {
            serverParametr = serverParametrsDict["deleteSubject"];
            queryParametrsDict.Clear();
            queryParametrsDict.Add("@id", CurrentItem.Id.ToString());

            var task = new Task<bool>(
                () => {
                    Tuple<bool, string> result = RequestSender.SendRequest(JsonConvert.SerializeObject(this));
                    if (!result.Item1)
                    {
                        message($"Ошибка удаления предмета:\r\n{result.Item2}\r\nОбратитесь к администратору");
                        return false;
                    }
                    else
                        return true;
                });
            task.Start();
            return task;
        }
    }
}
