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
            { "FAC_DLT", "удалил факультет"},
            { "FAC_EDT", "отредактировал факультет"},
            { "LOG_DAT", "загрузил логи"},
            { "LOG_PRM", "загрузил логи"},
            { "USER_GET", "загрузил список пользователей"},
            { "USER_DLT", "удалил пользователя с параметрами"},
            { "USER_ADD", "добавил пользователя с параметрами"},
            { "USER_EDT", "отредактировал пользователя с параметрами"},
            { "USER_PASS", "сменил пароль"},
            { "SGRP_GET", "загрузил список учебных групп"},
            { "SGRP_DLT", "удалил учебную группу с параметрами"},
            { "SGRP_PRM", "загрузил список учебных групп"},
            { "SGRP_ADD", "добавил учебную группу с параметрами"},
            { "SGRP_EDT", "отредактировал учебную группу с параметрами"},
            { "SBJ_GET", "загрузил список предметов"},
            { "SBJ_ADD", "добавил новый пердмет"},
            { "SBJ_DLT", "удалил пердмет"},
            { "SBJ_EDT", "отредактировал пердмет"},


            


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
            User currentUser = new User((int)json["currentUser"]["Id"], (string)json["currentUser"]["Login"], (string)json["currentUser"]["Password"], (int)json["currentUser"]["UserRights"]);

            dynamic dictJson = json.queryParametrsDict;
            string dictStr = Convert.ToString(dictJson);
            if (dictStr != null)
                dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(dictStr);

            bool isSuccess = false;

            switch (serverParametr)
            {
                case "USER_AUTH": //Авторизация
                    //User user = new User((string)json["currentUser"]["Login"],(string)json["currentUser"]["Password"]);
                    currentUser = DataBase.GetUser(currentUser, serverParametr);
                    if (currentUser != null)
                    {
                        isSuccess = true;
                        response = JsonConvert.SerializeObject(currentUser);
                    }
                    break;
                case "FAC_GET":  //Список всех факультетов
                case "USER_GET": //Список пользователей системы
                case "SGRP_GET":
                case "SBJ_GET":
                    List<object[]> list = DataBase.DefaultSelectQuery(serverParametr, currentUser);
                    if (list != null)
                    {
                        isSuccess = true;
                        response = JsonConvert.SerializeObject(list);
                    }
                    break;
                case "LOG_DAT":
                case "LOG_PRM":
                case "SGRP_PRM":
                    List<object[]> paramList = DataBase.ParamSelectQuery(dict, serverParametr, currentUser);
                    if (paramList != null)
                    {
                        isSuccess = true;
                        response = JsonConvert.SerializeObject(paramList);
                    }
                    break;
                case "FAC_ADD": //добавить факультет
                case "USER_ADD": //добавить пользователя
                case "SGRP_ADD": //добавить группу
                case "SBJ_ADD": //добавить пердмет
                    int resultAdd = DataBase.DefaultAddQuery(dict, serverParametr, currentUser);
                    if (resultAdd >= 0)
                    {
                        isSuccess = true;
                        response = JsonConvert.SerializeObject(resultAdd);
                    }
                    break;
                case "FAC_EDT": //редактировать факультет
                case "USER_EDT": //редактировать пользователя
                case "USER_PASS": //смена пароля пользователя
                case "SGRP_EDT": //редактировать группу
                case "SBJ_EDT": //редактировать пердмет
                    int resultEdt = DataBase.DefaultEditQuery(dict, serverParametr, currentUser);
                    if (resultEdt >= 0)
                    {
                        isSuccess = true;
                        response = JsonConvert.SerializeObject(resultEdt);
                    }
                    break;
                case "FAC_DLT": //удалить факультет
                case "USER_DLT": //удалить пользователя
                case "SGRP_DLT": //удалить группу
                case "SBJ_DLT": //удалить предмет
                    bool resultDlt = DataBase.DefaultDeleteQuery(dict, serverParametr, currentUser);
                    if (resultDlt)
                    {
                        isSuccess = true;
                        response = "Success";
                    }
                    break;
                default: //неизвестный параметр
                    isSuccess = true;
                    response = "Unknown";
                    ServerLog.Log($"Пользователь {currentUser.Login} отправил неопознаные данные: {requestBody}");
                    break;
            }
            if (isSuccess)
            {
                if (dict.Count > 0)
                {
                    //ServerLog.Log($"Пользователь {currentUser.Login} {logParams[serverParametr]} " +
                     //             $"c параметрами {string.Join(";", dict.Select(x => x.Key + "=" + x.Value).ToArray())}");
                    ServerLog.BaseLog(currentUser, $"{logParams[serverParametr]} c параметрами {string.Join(";", dict.Select(x => x.Key + "=" + x.Value).ToArray())}");
                }
                else
                {
                    //ServerLog.Log($"Пользователь {currentUser.Login} {logParams[serverParametr]}");
                    ServerLog.BaseLog(currentUser, $"{logParams[serverParametr]}");
                }  
            }
            else
                response = "Exception";
            return response;
        }
    }
}
