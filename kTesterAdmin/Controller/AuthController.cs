using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using kTesterLib.Service;
using Newtonsoft.Json;

namespace kTesterAdmin.Controller
{
    public class AuthController
    {
        [JsonRequired]
        private string serverParametr = ""; 
        [JsonRequired]
        private User currentUser;
        public User GetUser()
        {
            return currentUser;
        }
        
        public AuthController() 
        {
            serverParametr = "USER_AUTH";
        }

        public AuthController(int id, string name, string pass, int rights)
        {
            currentUser = new User(id, name, pass, rights);
        }

        

        public Task<Tuple<bool, string>> AuthAsync(string login, string password)
        {
            currentUser = new User(login, password);
            var task = new Task<Tuple<bool, string>>(
                () => {
                    Tuple<bool, string> result = RequestSender.SendRequest(JsonConvert.SerializeObject(this));
                    if (result.Item1)
                    {
                        currentUser = JsonConvert.DeserializeObject<User>(result.Item2);
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
