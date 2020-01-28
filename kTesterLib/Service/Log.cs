using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kTesterLib.Service
{
    /// <summary>
    /// Класс логирования действий пользователя
    /// </summary>
    public class Log
    {
        public int Id { get; set; }
        private int UserId { get; set; }
        
        private DateTime date;
        public string Date 
        { 
            get { return date.ToString("HH:mm:ss"); } 
        }
        public User User { get; set; }

        public string Text { get; set; }

        public Log(int id, DateTime date, string text, int userId, string user)
        {
            Id = id;
            this.date = date;
            Text = text;
            UserId = userId;
            User = new User(userId, user);
        }
    }
}
