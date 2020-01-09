using System;
using System.Collections.Generic;
using System.Text;
using kTesterLib.Service;
using kTesterLib.Meta;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace kTesterServer
{
    public class RequestParser
    {
        private string requestBody;
        private RequestType requestType;

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
            dynamic json = JObject.Parse(requestBody);
            string serverParametr = json.serverParametr;
            string userLogin = json.userParametr;

            switch (serverParametr)
            {
                case "AUTH": //Авторизация
                    User user = new User((string)json["currentUser"]["Login"],(string)json["currentUser"]["Password"]);
                    User responseUser = DataBase.GetUser(user, serverParametr);
                    response = JsonConvert.SerializeObject(responseUser);
                    ServerLog.Log($"Пользователь {responseUser.Login} вошёл в систему");
                    break;
                case "GET_FAC": //Список всех факультетов
                    List<Faculty> faculties = DataBase.GetFaculties(serverParametr);
                    if (faculties != null)
                    {
                        response = JsonConvert.SerializeObject(faculties);
                        ServerLog.Log($"Пользователь {userLogin} загрузил список факультетов");
                    }
                    break;
                default: //неизвестный параметр
                    response = JsonConvert.SerializeObject(false);
                    break;
            }
            return response;
        }
    }
}
