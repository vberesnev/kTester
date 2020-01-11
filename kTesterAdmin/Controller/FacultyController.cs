using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kTesterLib.Meta;
using Newtonsoft.Json;

namespace kTesterAdmin.Controller
{   
    class FacultyController
    {
        [JsonRequired]
        private string serverParametr;
        [JsonRequired]
        private string userParametr;
        

        private Faculty currentFaculty;

        [JsonIgnore]
        public List<Faculty> Faculties;
        private Dictionary<string, string> serverParametrsDict;

        [JsonRequired]
        private Dictionary<string, string> queryParametrsDict;


        private Action<string> message;

        public FacultyController(Action<string> mes, string userName)
        {
            Faculties = new List<Faculty>();
            currentFaculty = new Faculty();
            userParametr = userName;
            serverParametrsDict = new Dictionary<string, string>()
            {
                {"getFaculties", "FAC_GET" },
                {"addFaculty", "FAC_ADD" },
                {"editFaculty", "FAC_EDT" },
                {"deleteFaculty", "FAC_DLT" }
            };

            queryParametrsDict = new Dictionary<string, string>();


            message = mes;
        }

        internal Task<List<Faculty>> GetFacultiesAsync()
        {
            serverParametr = serverParametrsDict["getFaculties"];
            var task = new Task<List<Faculty>>(
                () => {
                    Tuple<bool, string> result = RequestSender.SendRequest(JsonConvert.SerializeObject(this));
                    if (result.Item1)
                    {
                        Faculties.Clear();
                        List<object[]> list = JsonConvert.DeserializeObject<List<object[]>>(result.Item2);
                        foreach (var arr in list)
                            Faculties.Add(new Faculty(Convert.ToInt32(arr[0]), arr[1].ToString()));

                        if (Faculties.Count == 0)
                            message("Нет ниодного факультета. Добавьте данные");
                        else
                            message(String.Empty);
                    }
                    else
                        message($"Ошибка получения данных:\r\n{result.Item2}\r\nОбратитесь к администратору");

                    return Faculties;
                });
            task.Start();
            return task;
        }

        internal Task DeleteFacultyAsync(int id)
        {
            serverParametr = serverParametrsDict["deleteFaculty"];
            queryParametrsDict.Clear();
            queryParametrsDict.Add("@id", id.ToString());

            var task = new Task(
                () => {
                    Tuple<bool, string> result = RequestSender.SendRequest(JsonConvert.SerializeObject(this));
                    if (!result.Item1)
                    {
                        message($"Ошибка удаления факультета:\r\n{result.Item2}\r\nОбратитесь к администратору");
                    }
                    else
                    {
                        message("Удалено");
                    }
                });
            task.Start();
            return task;
        }

        internal Task AddFacultyAsync(string name)
        {
            serverParametr = serverParametrsDict["addFaculty"];
            queryParametrsDict.Clear();
            queryParametrsDict.Add("@name", name);

            var task = new Task(
                () => {
                    Tuple<bool, string> result = RequestSender.SendRequest(JsonConvert.SerializeObject(this));
                    if (result.Item1)
                    {
                        int id = JsonConvert.DeserializeObject<int>(result.Item2);

                        if (id == 0)
                            message("Такой факультет уже существует");
                        else
                            message($"Факультет {name} добавлен");
                    }
                    else
                        message($"Ошибка добавления факультета:\r\n{result.Item2}\r\nОбратитесь к администратору");
                });
            task.Start();
            return task;
        }
    }
}
