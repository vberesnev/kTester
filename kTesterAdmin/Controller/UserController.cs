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
                            items.Add(new User(Convert.ToInt32(arr[0]), arr[1].ToString(), Convert.ToInt32(arr[2])));

                        if (items.Count == 0)
                            information("Нет ниодного пользователя. Добавьте данные");
                        DataSourse = new BindingList<User>(items);
                    }
                    else
                        information($"Ошибка получения данных:\r\n{result.Item2}\r\nОбратитесь к администратору");

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
