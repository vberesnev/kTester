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
    public class FacultyController
    {
        [JsonRequired]
        private string serverParametr;
        [JsonRequired]
        private User currentUser;

        [JsonIgnore]
        public Faculty CurrentFaculty { get; private set; }

        private List<Faculty> faculties;
        private Dictionary<string, string> serverParametrsDict;

        [JsonIgnore]
        public BindingList<Faculty> DataSourse;


        [JsonRequired]
        private Dictionary<string, string> queryParametrsDict;


        private Action<string> info;
        private Action<string> message;

        public FacultyController(Action<string> info, Action<string> mess, AuthController userController)
        {
            faculties = new List<Faculty>();
            currentUser = userController.GetUser();
            serverParametrsDict = new Dictionary<string, string>()
            {
                {"getFaculties", "FAC_GET" },
                {"addFaculty", "FAC_ADD" },
                {"editFaculty", "FAC_EDT" },
                {"deleteFaculty", "FAC_DLT" }
            };

            queryParametrsDict = new Dictionary<string, string>();
            this.info = info;
            message = mess;
        }

        public void SetCurrentFaculty(int id=0)
        {
            if (id == 0)
                CurrentFaculty = new Faculty();
            else
                CurrentFaculty = faculties.FirstOrDefault(x => x.Id == id);
        }

        internal Task<BindingList<Faculty>> GetFacultiesAsync()
        {
            serverParametr = serverParametrsDict["getFaculties"];
            queryParametrsDict.Clear();
            var task = new Task<BindingList<Faculty>>(
                () => {
                    Tuple<bool, string> result = RequestSender.SendRequest(JsonConvert.SerializeObject(this));
                    DataSourse = null;
                    if (result.Item1)
                    {
                        faculties.Clear();
                        List<object[]> list = JsonConvert.DeserializeObject<List<object[]>>(result.Item2);
                        foreach (var arr in list)
                            faculties.Add(new Faculty(Convert.ToInt32(arr[0]), arr[1].ToString()));

                        if (faculties.Count == 0)
                            info("Нет ниодного факультета. Добавьте данные");
                        DataSourse = new BindingList<Faculty>(faculties);
                    }
                    else
                        info($"Ошибка получения данных:\r\n{result.Item2}\r\nОбратитесь к администратору");

                    return DataSourse;
                });
            task.Start();
            return task;
        }

        internal Task<bool> DeleteFacultyAsync()
        {
            serverParametr = serverParametrsDict["deleteFaculty"];
            queryParametrsDict.Clear();
            queryParametrsDict.Add("@id", CurrentFaculty.Id.ToString());

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

        internal Task<bool> AddFacultyAsync(string name)
        {
            CurrentFaculty.Name = name;
            serverParametr = serverParametrsDict["addFaculty"];
            queryParametrsDict.Clear();
            queryParametrsDict.Add("@name", CurrentFaculty.Name);

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
                        message($"Ошибка добавления факультета:\r\n{result.Item2}\r\nОбратитесь к администратору");
                    return false;
                });
            task.Start();
            return task;
        }

        internal Task<bool> EditFacultyAsync(string name)
        {
            CurrentFaculty.Name = name;
            serverParametr = serverParametrsDict["editFaculty"];
            queryParametrsDict.Clear();
            queryParametrsDict.Add("@id", CurrentFaculty.Id.ToString());
            queryParametrsDict.Add("@name", CurrentFaculty.Name);

            var task = new Task<bool>(
                () => {
                    Tuple<bool, string> result = RequestSender.SendRequest(JsonConvert.SerializeObject(this));
                    if (result.Item1)
                    {
                        if (result.Item2 == "IsExist")
                            message("Такой факультет уже существует!");
                        else
                            return true;
                    }
                    else
                    {
                        message($"Ошибка редактирования факультета:\r\n{result.Item2}\r\nОбратитесь к администратору");
                    }
                    return false;
                });
            task.Start();
            return task;
        }
    }
}
