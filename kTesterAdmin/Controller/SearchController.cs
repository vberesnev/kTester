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
    public class SearchController
    {


        [JsonRequired]
        private string serverParametr;
        private Dictionary<string, string> serverParametrsDict;

        [JsonRequired]
        private User currentUser;

        private List<User> users;
        
        
        

        [JsonRequired]
        private Dictionary<string, string> queryParametrsDict;

        private Action<string> message;

        public SearchController(Action<string> mess, AuthController userController)
        {
            users = new List<User>();
            currentUser = userController.GetUser();

            serverParametrsDict = new Dictionary<string, string>()
            {
                {"getUsers", "USER_GET" }
            };

            queryParametrsDict = new Dictionary<string, string>();
            this.message = mess;
        }


        internal Task<List<User>> GetUsersAsync()
        {
            serverParametr = serverParametrsDict["getUsers"];
            queryParametrsDict.Clear();
            var task = new Task<List<User>>(
                () => {
                    Tuple<bool, string> result = RequestSender.SendRequest(JsonConvert.SerializeObject(this));
                    if (result.Item1)
                    {
                        users.Clear();
                        List<object[]> list = JsonConvert.DeserializeObject<List<object[]>>(result.Item2);
                        users.Add(new User(0, "Не выбрано"));
                        foreach (var arr in list)
                            users.Add(new User(Convert.ToInt32(arr[0]), arr[1].ToString()));
                        return users;
                    }
                    else
                    {
                        message($"Ошибка получения данных:\r\n{result.Item2}\r\nОбратитесь к администратору");
                        users.Clear();
                        return users; 
                    }
                        

                });
            task.Start();
            return task;
        }
    }
}
