using kTesterLib.Service;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kTesterAdmin.Controller
{
    public class UserController : DefaultController<User>
    {
        public UserController(Action<string> info, Action<string> mess, AuthController userController)
            : base(info, mess, userController)
        {
            serverParametrsDict = new Dictionary<string, string>()
            {
                {"getUsers", "USER_GET" },
                {"addUser", "USER_ADD" },
                {"editUser", "USER_EDT" },
                {"deleteUser", "USER_DLT" },
                {"changePassUser", "USER_PASS" },
            };
        }

        public override void SetCurrentItem(int id = 0)
        {
            if (id == 0)
                CurrentItem = new User();
            else
                CurrentItem = items.FirstOrDefault(x => x.Id == id);
        }

        internal override Task<BindingList<User>> GetDataAsync()
        {
            serverParametr = serverParametrsDict["getUsers"];
            queryParametrsDict.Clear();
            var task = new Task<BindingList<User>>(
                () => {
                    Tuple<bool, string> result = RequestSender.SendRequest(JsonConvert.SerializeObject(this));
                    DataSourse = null;
                    if (result.Item1)
                    {
                        items.Clear();
                        List<object[]> list = JsonConvert.DeserializeObject<List<object[]>>(result.Item2);
                        foreach (var arr in list)
                            items.Add(new User(Convert.ToInt32(arr[0]), arr[1].ToString(), Convert.ToInt32(arr[2]), arr[3].ToString()));

                        if (items.Count == 0)
                            message("Нет ниодного пользователя. Добавьте данные");
                        DataSourse = new BindingList<User>(items);
                    }
                    else
                        information($"Ошибка получения данных:\r\n{result.Item2}");

                    return DataSourse;
                });
            task.Start();
            return task;
        }


        internal override Task<bool> DeleteItemAsync()
        {
            serverParametr = serverParametrsDict["deleteUser"];
            queryParametrsDict.Clear();
            queryParametrsDict.Add("@id", CurrentItem.Id.ToString());

            var task = new Task<bool>(
                () => {
                    Tuple<bool, string> result = RequestSender.SendRequest(JsonConvert.SerializeObject(this));
                    if (!result.Item1)
                    {
                        message($"Ошибка удаления факультета:\r\n{result.Item2}");
                        return false;
                    }
                    else
                        return true;
                });
            task.Start();
            return task;
        }

        internal override Task<bool> AddOrUpdateItemAsync(params string[] parametrs)
        {
            queryParametrsDict.Clear();
            string actMessage = "";

            queryParametrsDict.Add("@login", parametrs[0]);
            queryParametrsDict.Add("@password", parametrs[1]);
            queryParametrsDict.Add("@userRights", parametrs[2]);
            queryParametrsDict.Add("@userName", parametrs[3]);

            if (CurrentItem.Id == 0)
            {
                serverParametr = serverParametrsDict["addUser"];
                actMessage = "добавления";
            }
            else
            {
                serverParametr = serverParametrsDict["editUser"];
                queryParametrsDict.Add("@id", CurrentItem.Id.ToString());
                actMessage = "редактирования";
            }

            var task = new Task<bool>(
                () => {
                    Tuple<bool, string> result = RequestSender.SendRequest(JsonConvert.SerializeObject(this));
                    if (result.Item1)
                    {
                        int id = JsonConvert.DeserializeObject<int>(result.Item2);
                        if (id == 0)
                            message("Пользователь с таким логином уже существует");
                        return id > 0;
                    }
                    else
                        message($"Ошибка {actMessage} пользователя:\r\n{result.Item2}");
                    return false;
                });
            task.Start();
            return task;
        }

        internal Task<bool> ChangePasswordAsync(string password)
        {
            serverParametr = serverParametrsDict["changePassUser"];
            queryParametrsDict.Clear();
            queryParametrsDict.Add("@id", CurrentItem.Id.ToString());
            queryParametrsDict.Add("@password", password);

            var task = new Task<bool>(
                () => {
                    Tuple<bool, string> result = RequestSender.SendRequest(JsonConvert.SerializeObject(this));
                    if (!result.Item1)
                    {
                        message($"Ошибка смены пароля:\r\n{result.Item2}");
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
