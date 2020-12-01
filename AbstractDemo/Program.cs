using System;

namespace AbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            SQLiteDataAccess testDataAccess = new SQLiteDataAccess();

            ((DataAccess)testDataAccess).LoadConnectionString();
            ((DataAccess)testDataAccess).TestOverride();

            Console.WriteLine("Hello World!");
        }
    }
}
