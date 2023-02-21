using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnection
{
    class Program
    {
        //// первая часть задания:
        //static void Main(string[] args)
        //{
        //    ////можно так:
        //    //TimeSpan timeOut = new TimeSpan(1000);
        //    //DatabaseConnection mySqlConnection = new MySqlConnection("111", timeOut);
        //    ////но так короче:
        //    DatabaseConnection mySqlConnection = new MySqlConnection("111", new TimeSpan(1000));
        //    DatabaseConnection msSqlConnection = new MsSqlConnection("222", new TimeSpan(1000));

        //    msSqlConnection.OpenConnection();
        //    msSqlConnection.CloseConnection();

        //    mySqlConnection.OpenConnection();
        //    mySqlConnection.CloseConnection();

        //    Console.ReadKey();
        //}

        ///////////////////////////////////////
        ////продолжение. первая и вторая часть задания:

        static void Main(string[] args)
        {
            TimeSpan timeout = new TimeSpan(1000);
            MySqlConnection mySqlConnection = new MySqlConnection("Server=myServerAddress;Port=1234;", timeout);
            MsSqlConnection msSqlConnection = new MsSqlConnection("Server=msServerAddress;Port=2345;", timeout);

            DatabaseCommand command = new DatabaseCommand(msSqlConnection, "Запрос SQL в базе msSQL");
            DatabaseCommand command2 = new DatabaseCommand(mySqlConnection, "Запрос SQL в базе mySQL");


            command.Execute();
            Console.WriteLine();
            command2.Execute();
            
            Console.ReadKey();
        }
    }

    class DatabaseCommand
    {
        //// почему здесь (след. строка) DatabaseConnection ??????
        //// почему нет get, set ?????? = так задумано было, т.к. это дальше никуда не пойдёт.
        private readonly DatabaseConnection dbConnection;
        private readonly string sqlString;

        public DatabaseCommand(DatabaseConnection connection, string sql)
        {
            if (connection == null)
            {
                throw new NullReferenceException("Что-то не так с соединением");
            }
            if (String.IsNullOrWhiteSpace(sql))
            {
                throw new ArgumentException("Что-то не так с sql");
            }
            sqlString = sql;
            dbConnection = connection;
        }

        public void Execute()
        {
            dbConnection.OpenConnection();
            Console.WriteLine("Выполнение SQL запроса: {0}", sqlString);
            Console.Beep(3000, 2000);
            dbConnection.CloseConnection();
        }

    }
}


