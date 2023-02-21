using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnection
{
    abstract class DatabaseConnection
    {
        private string ConnectionString;
        private TimeSpan TimeOut;

        public DatabaseConnection(string connectionString, TimeSpan timeOut)
        {
            ConnectionString = connectionString;
            TimeOut = timeOut;
            ///или так:
            ///this.TimeOut = TimeOut;
        }

        public string connectionString
        {
            get
            {
                return ConnectionString;
            }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Не установлено значение для строки подключения");
                }
                else
                    ConnectionString = value;
            }
        }

        public TimeSpan timeOut
        {
            get
            {
                return TimeOut;
            }
            private set
            {
                TimeOut = value;
            }
        }

        public abstract void OpenConnection();

        public abstract void CloseConnection();
    }
}
