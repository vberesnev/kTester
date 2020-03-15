using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kTesterLib.Testing;
using kTesterLib.Service;
using Newtonsoft.Json;
using kTesterLib.Meta;

namespace kTesterAdmin.Controller
{
    public class TestController : DefaultController<Test>
    {

        private User currentUser;
        public TestController(Action<string> info, Action<string> mess, AuthController userController)
            : base(info, mess, userController)
        {
            serverParametrsDict = new Dictionary<string, string>()
            {
                {"getTestsAll", "TEST_GET" },
                {"addTest", "TEST_ADD" },
                {"editTest", "TEST_EDT" },
                {"deleteTest", "TEST_DLT" },
            };

            currentUser = userController.GetUser();
        }

        public override void SetCurrentItem(int id = 0)
        {
            if (id == 0)
                CurrentItem = new Test();
            else
                CurrentItem = items.FirstOrDefault(x => x.Id == id);
        }

        internal override Task<BindingList<Test>> GetDataAsync()
        {
            serverParametr = serverParametrsDict["getTestsAll"];
            queryParametrsDict.Clear();

            if (currentUser.UserRights == UserRights.Administrator)
                queryParametrsDict.Add("@userId", "0");
            else
            {
                if (currentUser.UserRights != UserRights.Professor)
                {
                    information($"Доступ запрещен!");
                    var errorTask = new Task<BindingList<Test>>(() =>
                    {
                        return null;
                    });
                    errorTask.Start();
                    return errorTask;
                }
                else
                    queryParametrsDict.Add("@userId", currentUser.Id.ToString());
            }

            var task = new Task<BindingList<Test>>(
                () => 
                {
                    Tuple<bool, string> result = RequestSender.SendRequest(JsonConvert.SerializeObject(this));
                    DataSourse = null;
                    if (result.Item1)
                    {
                        items.Clear();
                        List<object[]> list = JsonConvert.DeserializeObject<List<object[]>>(result.Item2);
                        foreach (var arr in list)
                            items.Add(new Test(Convert.ToInt32(arr[0]), arr[1].ToString(), Convert.ToInt32(arr[2]), arr[3].ToString(), Convert.ToInt32(arr[4]), arr[5].ToString(), Convert.ToInt32(arr[6])));
                        if (items.Count == 0)
                            message("Нет ниодного теста. Добавьте данные");
                        DataSourse = new BindingList<Test>(items);
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
            serverParametr = serverParametrsDict["deleteTest"];
            queryParametrsDict.Clear();
            queryParametrsDict.Add("@id", CurrentItem.Id.ToString());

            var task = new Task<bool>(
                () => {
                    Tuple<bool, string> result = RequestSender.SendRequest(JsonConvert.SerializeObject(this));
                    if (!result.Item1)
                    {
                        message($"Ошибка удаления теста:\r\n{result.Item2}");
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
