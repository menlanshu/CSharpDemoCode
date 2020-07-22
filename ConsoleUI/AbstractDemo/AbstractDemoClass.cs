using DemoLibrary.AbstractDemo;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.AbstractDemo
{
    public static class AbstractDemoClass
    {
        public static void MainTest()
        {
            // You can not create an object to an abstract class
            //DataAccess test = new DataAccess();

            SqliteDataAccess dataAccessSqlite = new SqliteDataAccess();

            DataAccess dataAccess = new SqliteDataAccess();
            dataAccess.LoadConnectionString("demo");
            //dataAccess.LoadData
            //dataAccess.SaveData

            List<DataAccess> databases = new List<DataAccess>()
            {
                new SqlDataAccess(),
                new SqliteDataAccess()
            };

            foreach (var db in databases)
            {
                db.LoadConnectionString("demo");
                db.LoadData("Select * from table");
                db.SaveData("Inert Into table");
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
