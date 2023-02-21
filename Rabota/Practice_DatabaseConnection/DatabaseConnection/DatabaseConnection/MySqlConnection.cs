using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnection
{
    class MySqlConnection : DatabaseConnection
    {
        public MySqlConnection(string connectionString, TimeSpan timeOut) : base(connectionString, timeOut)
        {
            
        }

        public override void OpenConnection()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Соединение c MySql установлено");
            Console.Beep(1000, 1000);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public override void CloseConnection()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Соединение c MsSql разорвано");
            Console.Beep(500, 500);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
