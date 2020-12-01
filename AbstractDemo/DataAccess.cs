using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractDemo
{
    // when no instance can be created as DataAccess, then it shoudl be a virtual class
    // No data access can just be data access
    // it should be sql server data access or sqlite data access or other kind of data access
    abstract class DataAccess
    {
        public virtual void LoadConnectionString()
        {
            Console.WriteLine("Abstract DataAccess class load connection string");
        }

        public virtual void TestOverride()
        {
            Console.WriteLine("Abstract DataAccess class test override");
        }

        // abstract class can not have body
        // abstract class must be implemented by child class
        // child class must use override to explicit implement function
        public abstract void GetData();
        public abstract void SetData();
    }
}
