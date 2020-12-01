using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractDemo
{
    class SQLiteDataAccess : DataAccess
    {
        // add new or not is the same action, when you call LoadConnectionString from outside
        // SQLite DataAccess console line will be printed
        // if you use new, then when instance has been convert to parent class, instance will invoke function of base class
        public new void LoadConnectionString()
        {
            Console.WriteLine("SQLite DataAccess class load connection string");
        }
        public override void TestOverride()
        {
            Console.WriteLine("SQLite DataAccess class test override");
        }
        public override void GetData()
        {
            Console.WriteLine($"SQLiteDataAccess implement GetData function");
        }

        public override void SetData()
        {
            Console.WriteLine($"SQLiteDataAccess implement SetData function");
        }
    }
}
