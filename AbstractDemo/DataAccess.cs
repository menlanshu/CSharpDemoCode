using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractDemo
{
    // when no instance can be created as DataAccess, then it shoudl be a virtual class
    // No data access can just be data access
    // it should be sql server data access or sqlite data access or other kind of data access


    // abstract vs interface
    // interface only can contain property, function without implementation
    // but abstract class can have virtua method with implementation
    // and all can have normal method with implmentation
    // abstract class for A is B condition
    // interface can only focuse on function. A has B, A has C, then you can use A : B, C to implment interface
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
