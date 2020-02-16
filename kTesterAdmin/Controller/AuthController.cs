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
        private Professor currentProfessor;

        [JsonRequired]
        private Dictionary<string, string> queryParametrsDict;
        public User GetUser()
        {
            return currentUser;
        }

        public Professor GetProfessor()
        {
            return currentProfessor;
        }
        
        public AuthController() 
        {
            serverParametr = "USER_AUTH";
            queryParametrsDict = new Dictionary<string, string>();
        }

        public AuthController(int id, string name, string pass, int rights)
        {
            currentUser = new User(id, name, pass, rights);
            queryParametrsDict = new Dictionary<string, string>();
            if (currentUser.UserRights == UserRights.Professor)
                currentProfessor = GetProfessorInfo(currentUser.Id).Result;
        }

        private Task<Professor> GetProfessorInfo(int userId)
        {
            serverParametr = "PRF_GET_BY_USER";
            queryParametrsDict.Clear();
            queryParametrsDict.Add("userId", userId.ToString());

            var task = new Task<Professor>(
                () => 
                {
                    Tuple<bool, string> result = RequestSender.SendRequest(JsonConvert.SerializeObject(this));
                    if (result.Item1 && result.Item2 != "[]")
                    {
                        List<object[]> list = JsonConvert.DeserializeObject<List<object[]>>(result.Item2);
                        foreach(var arr in list)
                        {
                            Professor professor = new Professor(Convert.ToInt32(arr[0]), arr[1].ToString(), Convert.ToInt32(arr[2]));
                            return professor;
                        }
                            
                    }
                    return null;
                });
            task.Start();
            return task;
        }

        public Task<Tuple<bool, string>> AuthAsync(string login, string password)
        {
            currentUser = new User(login, password);
            var task = new Task<Tuple<bool, string>>(
                () => 
                {
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
