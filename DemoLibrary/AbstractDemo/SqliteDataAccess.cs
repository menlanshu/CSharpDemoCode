using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DemoLibrary.AbstractDemo
{
    public class SqliteDataAccess : DataAccess
    {
        //public string LoadConnectionString(string connStr)
        //{
        //    WriteLine($"Load connection string");
        //    return $"TestDemoConnectionString";
        //}

        public override void LoadData(string sqlStr)
        {
            WriteLine("Loading data from SQLite database");
        }

        public override void SaveData(string sqlStr)
        {
            WriteLine("Save data to SQLite database");
        }
    }
}
