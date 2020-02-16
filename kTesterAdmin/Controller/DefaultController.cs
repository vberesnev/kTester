using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kTesterLib.Service;
using Newtonsoft.Json;

namespace kTesterAdmin.Controller
{
    public abstract class DefaultController<T>
        where T: class
    {
        [JsonRequired]
        protected string serverParametr; //параметр, который передается на сервер для вызова соответсвующей функции
        [JsonRequired]
        protected User currentUser; //пользователь, от которого пришел запрос

        protected Dictionary<string, string> serverParametrsDict; //словарь параметров для сервера, для каждого контроллера свой словарь 

        [JsonIgnore]
        public BindingList<T> DataSourse; // источник данных для привязки значений

        [JsonIgnore]
        public T CurrentItem { get; protected set; } //текущий элемент, над котором совершается действие (удаление, добавлени, правка)

        protected List<T> items; // список элементов 

        [JsonRequired]
        protected Dictionary<string, string> queryParametrsDict; //слварь параметров, которые передаются на сервер для sql запроса

        protected Action<string> information; //информационное сообщение, показывается на форме
        protected Action<string> message; //информационное сообщение, вызывающее MessageBox

        public void SetInformation(Action<string> info)
        {
            information = info;
        }

        public DefaultController(Action<string> info, Action<string> mess, AuthController userController)
        {
            items = new List<T>();
            currentUser = userController.GetUser();
            queryParametrsDict = new Dictionary<string, string>();
            information = info;
            message = mess;
        }

        /// <summary>
        /// Метод по присвоению полю CurrentItem значения, основываясь на Id записи (если Id = 0, то создавать новый экземпляр объекта)
        /// </summary>
        /// <param name="id"></param>
        public virtual void SetCurrentItem(int id = 0)
        {
            CurrentItem = null;
        }

        /// <summary>
        /// Задача по добавлению данных на сервер или обновлению уже существующих
        /// </summary>
        /// <param name="parametrs"></param>
        /// <returns></returns>
        internal async virtual Task<bool> AddOrUpdateItemAsync(params string[] parametrs) 
        {
            return await new Task<bool>(() => { return false; });
        }

        /// <summary>
        /// Задача по получению данных от сервера
        /// </summary>
        /// <returns></returns>
        internal async virtual Task<BindingList<T>> GetDataAsync()
        {
            return await new Task<BindingList<T>>(() => { return null; });
        }

        /// <summary>
        /// Задача по удалению данных с сервера
        /// </summary>
        /// <returns></returns>
        internal async virtual Task<bool> DeleteItemAsync() 
        {
            return await new Task<bool>(() => { return false; });
        }

        /// <summary>
        /// Задача по фильтрации полученного списка данных по параметру 
        /// </summary>
        /// <param name="paramert">Параметр фильтрации</param>
        /// <returns></returns>
        internal async virtual  Task<BindingList<T>> FilterItems(string paramert)
        {
            return await new Task<BindingList<T>>(() => { return null; });
        }
    }
}
