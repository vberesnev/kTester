using kTesterLib.Meta;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kTesterAdmin.Controller
{
    public class StudyGroupController : DefaultController<StudyGroup>
    {

        public StudyGroupController(Action<string> info, Action<string> mess, AuthController userController)
            : base(info, mess, userController)
        {
            serverParametrsDict = new Dictionary<string, string>()
            {
                {"getGroups", "SGRP_GET" },
                {"getGroupsByParams", "SGRP_PRM" },
                {"addGroup", "SGRP_ADD" },
                {"editGroup", "SGRP_EDT" },
                {"deleteGroup", "SGRP_DLT" }
            };
        }

        public override void SetCurrentItem(int id = 0)
        {
            if (id == 0)
                CurrentItem = new StudyGroup();
            else
                CurrentItem = items.FirstOrDefault(x => x.Id == id);
        }

        internal override Task<BindingList<StudyGroup>> GetDataAsync()
        {
            serverParametr = serverParametrsDict["getGroups"];
            queryParametrsDict.Clear();
            var task = new Task<BindingList<StudyGroup>>(
                () => {
                    Tuple<bool, string> result = RequestSender.SendRequest(JsonConvert.SerializeObject(this));
                    DataSourse = null;
                    if (result.Item1)
                    {
                        items.Clear();
                        List<object[]> list = JsonConvert.DeserializeObject<List<object[]>>(result.Item2);
                        foreach (var arr in list)
                            items.Add(new StudyGroup(Convert.ToInt32(arr[0]), arr[1].ToString(), Convert.ToInt32(arr[2]), Convert.ToInt32(arr[3])));

                        if (items.Count == 0)
                            message("Нет ниодной учебной группы. Добавьте данные");
                        DataSourse = new BindingList<StudyGroup>(items);
                    }
                    else
                        information($"Ошибка получения данных:\r\n{result.Item2}");

                    return DataSourse;
                });
            task.Start();
            return task;
        }

        internal override Task<bool> DeleteItemAsync()
        {
            serverParametr = serverParametrsDict["deleteGroup"];
            queryParametrsDict.Clear();
            queryParametrsDict.Add("@id", CurrentItem.Id.ToString());

            var task = new Task<bool>(
                () => {
                    Tuple<bool, string> result = RequestSender.SendRequest(JsonConvert.SerializeObject(this));
                    if (!result.Item1)
                    {
                        message($"Ошибка удаления учебной группы:\r\n{result.Item2}");
                        return false;
                    }
                    else
                        return true;
                });
            task.Start();
            return task;
        }
    }
}
