using System;
using System.Collections.Generic;
using System.Text;
using kTesterLib.Service;
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

            switch (serverParametr)
            {
                case "AUTH":
                    User user = new User((string)json["currentUser"]["Login"],(string)json["currentUser"]["Password"]);
                    User responseUser = DataBase.GetUser(user, serverParametr);
                    response = JsonConvert.SerializeObject(responseUser);
                    ServerLog.Log($"Пользователь {responseUser.Login} вошёл в систему");
                    break;
            }
            return response;
        }
    }
}
