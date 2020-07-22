using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DemoLibrary.AbstractDemo
{
    public class SqlDataAccess : DataAccess
    {
        //public string LoadConnectionString(string connStr)
        //{
        //    WriteLine($"Load connection string");
        //    return $"TestDemoConnectionString";
        //}

        // Base class load connection string will also do action even if you override the function
        public override string LoadConnectionString(string connStr)
        {
            Console.WriteLine($"Load connection string SQLDATA");
            return $"TestDemoConnectionStringSQLDATA";

            //base.LoadConnectionString()
        }

        public override void LoadData(string sqlStr)
        {
            WriteLine("Loading Microsoft SQL Data");
        }

        public override void SaveData(string sqlStr)
        {
            WriteLine("Save data to Microsoft SQL database");
        }
    }
}
