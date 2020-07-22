using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.AbstractDemo
{
    public interface IDataAccess
    {
        string LoadConnectionString(string connStr);

        void LoadData(string sqlStr);

        void SaveData(string sqlStr);
    }
}
