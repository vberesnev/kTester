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
        public int UserId { get; set; }
        public User User { get; set; }
        public DateTime DateTime { get; set; }
        public string Text { get; set; }
    }
}
