using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using kTesterLib.Service;
using kTesterLib.Meta;
using Newtonsoft.Json;

namespace kTesterAdmin.Controller
{
    public class AuthController
    {
        [JsonRequired]
        private string serverParametr; 
        [JsonRequired]
        private User currentUser;

        [JsonRequired]
        private Dictionary<string, string> queryParametrsDict;
        public User GetUser()
        {
            return currentUser;
        }
        
        public AuthController() 
        {
            serverParametr = "USER_AUTH";
            currentUser = new User();
            queryParametrsDict = new Dictionary<string, string>();
        }

        public AuthController(int id, string login, int rights, string name)
        {
            currentUser = new User(id, login, rights, name);
            queryParametrsDict = new Dictionary<string, string>();
        }

        public Task<Tuple<bool, string>> AuthAsync(string login, string password)
        {
            queryParametrsDict.Add("@login", Helper.GetCryptPass(login));
            queryParametrsDict.Add("@password", Helper.GetCryptPass(password));

            var task = new Task<Tuple<bool, string>>(
                () => 
                {
                    Tuple<bool, string> result = RequestSender.SendRequest(JsonConvert.SerializeObject(this));
                    if (result.Item1)
                    {
                        List<object[]> list = JsonConvert.DeserializeObject<List<object[]>>(result.Item2);
                        currentUser = new User(Convert.ToInt32(list[0][0]), list[0][1].ToString(), Convert.ToInt32(list[0][2]), list[0][3].ToString());
                        if (currentUser.Id > 0)
                            return new Tuple<bool, string>(true, "");
                        else
                            return new Tuple<bool, string>(false, "Введены неверные логин или пароль");
                    }
                    else
                    {
                        return result;
                    }
                });
            task.Start();
            return task;
        }
    }
}
