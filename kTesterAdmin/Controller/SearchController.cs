using kTesterLib.Meta;
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
        private List<Faculty> faculties;


        [JsonRequired]
        private Dictionary<string, string> queryParametrsDict;

        private Action<string> message;

        public SearchController(Action<string> mess, AuthController userController)
        {
            
            currentUser = userController.GetUser();

            serverParametrsDict = new Dictionary<string, string>()
            {
                {"getUsers", "USER_GET" },
                {"getFaculties", "FAC_GET" }
            };

            queryParametrsDict = new Dictionary<string, string>();
            this.message = mess;
        }


        internal Task<List<User>> GetUsers()
        {
            users = new List<User>();
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

        internal Task<List<Faculty>> GetFaculties()
        {
            faculties = new List<Faculty>();
            serverParametr = serverParametrsDict["getFaculties"];
            queryParametrsDict.Clear();
            var task = new Task<List<Faculty>>(
                () => {
                    Tuple<bool, string> result = RequestSender.SendRequest(JsonConvert.SerializeObject(this));
                    if (result.Item1)
                    {
                        faculties.Clear();
                        List<object[]> list = JsonConvert.DeserializeObject<List<object[]>>(result.Item2);
                        faculties.Add(new Faculty(0, "Не выбрано"));
                        foreach (var arr in list)
                            faculties.Add(new Faculty(Convert.ToInt32(arr[0]), arr[1].ToString()));
                        return faculties;
                    }
                    else
                    {
                        message($"Ошибка получения данных:\r\n{result.Item2}\r\nОбратитесь к администратору");
                        faculties.Clear();
                        return faculties;
                    }
                });
            task.Start();
            return task;
        }
    }
}
