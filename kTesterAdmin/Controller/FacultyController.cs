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
        [JsonRequired]
        private Faculty currentFaculty;

        public List<Faculty> Faculties;
        private Dictionary<string, string> serverParametrsDict;


        private Action<string> message;

        public FacultyController(Action<string> mes, string userName)
        {
            Faculties = new List<Faculty>();
            currentFaculty = new Faculty();
            userParametr = userName;
            serverParametrsDict = new Dictionary<string, string>()
            {
                {"getFaculties", "GET_FAC" },
                {"addFaculty", "ADD_FAC" },
                {"editFaculty", "EDT_FAC" },
                {"deleteFaculty", "DLT_FAC" }
            };
            message = mes;
        }

        public Task<List<Faculty>> GetFacultiesAsync()
        {
            serverParametr = serverParametrsDict["getFaculties"];
            var task = new Task<List<Faculty>>(
                () => {
                    Tuple<bool, string> result = RequestSender.SendRequest(JsonConvert.SerializeObject(this));
                    if (result.Item1)
                    {
                        Faculties = JsonConvert.DeserializeObject<List<Faculty>>(result.Item2);
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
    }
}
