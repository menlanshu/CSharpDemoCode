using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.AbstractDemo
{
    // If it's not absract, then this class is not actually a entity that can be used in real world
    // It's a mess
    public abstract class DataAccess
    {
        // Only when method define as virtual class, child class can override it, or override will be forbidden
        public virtual string LoadConnectionString(string connStr)
        {
            Console.WriteLine($"Load connection string");
            return $"TestDemoConnectionString";
        }


        // Abstract method, you must realize this method in your child class! Override in child class
        public abstract void LoadData(string sqlStr);
        public abstract void SaveData(string sqlStr);
    }
}
