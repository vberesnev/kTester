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
    public class FacultyController: DefaultController<Faculty>
    {
        public FacultyController(Action<string> info, Action<string> mess, AuthController userController)
            :base (info, mess, userController)
        {
            serverParametrsDict = new Dictionary<string, string>()
            {
                {"getFaculties", "FAC_GET" },
                {"addFaculty", "FAC_ADD" },
                {"editFaculty", "FAC_EDT" },
                {"deleteFaculty", "FAC_DLT" }
            };
        }

        public override void SetCurrentItem(int id=0)
        {
            if (id == 0)
                CurrentItem = new Faculty();
            else
                CurrentItem = items.FirstOrDefault(x => x.Id == id);
        }

        internal override Task<BindingList<Faculty>> GetDataAsync()
        {
            serverParametr = serverParametrsDict["getFaculties"];
            queryParametrsDict.Clear();
            var task = new Task<BindingList<Faculty>>(
                () => {
                    Tuple<bool, string> result = RequestSender.SendRequest(JsonConvert.SerializeObject(this));
                    DataSourse = null;
                    if (result.Item1)
                    {
                        items.Clear();
                        List<object[]> list = JsonConvert.DeserializeObject<List<object[]>>(result.Item2);
                        foreach (var arr in list)
                            items.Add(new Faculty(Convert.ToInt32(arr[0]), arr[1].ToString()));

                        if (items.Count == 0)
                            message("Нет ниодного факультета. Добавьте данные");
                        DataSourse = new BindingList<Faculty>(items);
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
                serverParametr = serverParametrsDict["addFaculty"];
                queryParametrsDict.Add("@name", parametrs[0]);
                actMessage = "добавления";
            }
            else
            {
                serverParametr = serverParametrsDict["editFaculty"];
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
                            message("Такой факультет уже существует");
                        return id > 0;
                    }
                    else
                        message($"Ошибка {actMessage} факультета:\r\n{result.Item2}\r\nОбратитесь к администратору");
                    return false;
                });
            task.Start();
            return task;
        }

        internal override Task<bool> DeleteItemAsync()
        {
            serverParametr = serverParametrsDict["deleteFaculty"];
            queryParametrsDict.Clear();
            queryParametrsDict.Add("@id", CurrentItem.Id.ToString());

            var task = new Task<bool>(
                () => {
                    Tuple<bool, string> result = RequestSender.SendRequest(JsonConvert.SerializeObject(this));
                    if (!result.Item1)
                    {
                        message($"Ошибка удаления факультета:\r\n{result.Item2}\r\nОбратитесь к администратору");
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
