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
            var task = GetTask();
            task.Start();
            return task;
        }

        internal Task<BindingList<StudyGroup>> SearchStudyGroups(int facultyId)
        {
            serverParametr = serverParametrsDict["getGroupsByParams"];
            queryParametrsDict.Clear();

            queryParametrsDict.Add("@facultyId", facultyId.ToString());
            var task = GetTask();
            task.Start();
            return task;
        }

        private Task<BindingList<StudyGroup>> GetTask()
        {
            return new Task<BindingList<StudyGroup>>(
                () =>
                {
                    Tuple<bool, string> result = RequestSender.SendRequest(JsonConvert.SerializeObject(this));
                    DataSourse = null;
                    if (result.Item1)
                    {
                        items.Clear();
                        List<object[]> list = JsonConvert.DeserializeObject<List<object[]>>(result.Item2);
                        foreach (var arr in list)
                            items.Add(new StudyGroup(Convert.ToInt32(arr[0]), arr[1].ToString(), Convert.ToInt32(arr[2]), Convert.ToInt32(arr[3]), arr[4].ToString()));

                        if (items.Count == 0)
                            message("Нет ниодной учебной группы. Добавьте данные");
                        DataSourse = new BindingList<StudyGroup>(items);
                    }
                    else
                        information($"Ошибка получения данных:\r\n{result.Item2}");

                    return DataSourse;
                });
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

        internal override Task<BindingList<StudyGroup>> FilterItems(string paramert)
        {
            Task<BindingList<StudyGroup>> task;
            if (string.IsNullOrEmpty(paramert) || string.IsNullOrWhiteSpace(paramert))
            {
                task = new Task<BindingList<StudyGroup>>(() =>
                {
                    information(items.Count.ToString());
                    return DataSourse = new BindingList<StudyGroup>(items);
                });
            }
            else
            {
                task = new Task<BindingList<StudyGroup>>(() =>
                {
                    information(items.Count.ToString());
                    List<StudyGroup> filterList = items.Where(x => x.Name.Contains(paramert)).ToList();
                    return DataSourse = new BindingList<StudyGroup>(filterList);
                });
            }
            task.Start();
            return task;
        }

        internal override Task<bool> AddOrUpdateItemAsync(params string[] parametrs)
        {
            queryParametrsDict.Clear();
            string actMessage = "";
            if (CurrentItem.Id == 0)
            {
                serverParametr = serverParametrsDict["addGroup"];
                actMessage = "добавления";
                queryParametrsDict.Add("@name", parametrs[0]);
                queryParametrsDict.Add("@facultyId", parametrs[1]);
                queryParametrsDict.Add("@quantity", parametrs[2]);
            }
            else
            {
                serverParametr = serverParametrsDict["editGroup"];
                actMessage = "редактирования";
                queryParametrsDict.Add("@id", CurrentItem.Id.ToString());
                queryParametrsDict.Add("@name", parametrs[0]);
                queryParametrsDict.Add("@facultyId", parametrs[1]);
                queryParametrsDict.Add("@quantity", parametrs[2]);
            }
            

            var task = new Task<bool>(
                () => {
                    Tuple<bool, string> result = RequestSender.SendRequest(JsonConvert.SerializeObject(this));
                    if (result.Item1)
                    {
                        int id = JsonConvert.DeserializeObject<int>(result.Item2);
                        if (id == 0)
                            message("Группа с такими параметрами уже существует");
                        return id > 0;
                    }
                    else
                        message($"Ошибка {actMessage} гурппы:\r\n{result.Item2}");
                    return false;
                });
            task.Start();
            return task;
        }

    }
}
