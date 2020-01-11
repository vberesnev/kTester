using System;
using System.Collections.Generic;
using System.Text;
using kTesterLib.Service;
using kTesterLib.Meta;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Linq;

namespace kTesterServer
{
    public class RequestParser
    {
        private string requestBody;
        private RequestType requestType;

        private Dictionary<string, string> logParams = new Dictionary<string, string>()
        {
            { "USER_AUTH", "вошёл в систему"},
            { "FAC_GET", "загрузил список факультетов"},
            { "FAC_ADD", "добавил новый факультет"},
            { "FAC_DLT", "удалил факультет"}
        };

        public RequestParser(string request)
        {
            requestBody = request;
        }

        private RequestType GerRequestType()
        {
            if (requestBody.StartsWith("AUTH")) return RequestType.AUTH;
            else return RequestType.LOGOUT;
        }

        public string GetResponse()
        {
            string response = String.Empty;
            Dictionary<string, string> dict = new Dictionary<string, string>();


            dynamic json = JObject.Parse(requestBody);
            string serverParametr = json.serverParametr;
            string userLogin = json.userParametr;

            dynamic dictJson = json.queryParametrsDict;
            string dictStr = Convert.ToString(dictJson);
            if (dictStr != null)
                dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(dictStr);

            bool isSuccess = false;

            switch (serverParametr)
            {
                case "USER_AUTH": //Авторизация
                    User user = new User((string)json["currentUser"]["Login"],(string)json["currentUser"]["Password"]);
                    User responseUser = DataBase.GetUser(user, serverParametr);
                    if (responseUser != null)
                    {
                        isSuccess = true;
                        response = JsonConvert.SerializeObject(responseUser);
                    }
                    break;
                case "FAC_GET": //Список всех факультетов
                    List<object[]> list = DataBase.DefaultSelectQuery(serverParametr);
                    if (list != null)
                    {
                        isSuccess = true;
                        response = JsonConvert.SerializeObject(list);
                    }
                    break;
                case "FAC_ADD": //добавить факультет
                    
                    int id = DataBase.AddFaculty(dict, serverParametr);
                    if (id >= 0)
                    {
                        isSuccess = true;
                        response = JsonConvert.SerializeObject(id);
                    }
                    break;
                case "FAC_DLT": //удалить факультет
                    bool result = DataBase.DefaultDeleteQuery(dict, serverParametr);
                    if (result)
                    {
                        isSuccess = true;
                        response = "Success";
                    }
                    break;

                default: //неизвестный параметр
                    response = "Unknown";
                    isSuccess = true;
                    ServerLog.Log($"Пользователь {userLogin} отправил неопознаные данные: {requestBody}");
                    break;
            }
            if (isSuccess)
            {
                if (dict.Count > 0)
                    ServerLog.Log($"Пользователь {userLogin} {logParams[serverParametr]} " +
                                  $"c параметрами {string.Join(";", dict.Select(x => x.Key + "=" + x.Value).ToArray())}");
                else
                    ServerLog.Log($"Пользователь {userLogin} {logParams[serverParametr]}");
            }
                
            else
                response = "Exception";
            return response;
        }
    }
}
