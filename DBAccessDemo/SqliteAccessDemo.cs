using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;

namespace DBAccessDemo
{
    public class SqliteAccessDemo
    {
        IDbConnection _dbConnection;

        public SqliteAccessDemo(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }


        public List<T> LoadData<T>(string sql)
        {
            _dbConnection.Open();
            try
            {
                var output = _dbConnection.Query<T>(sql, new DynamicParameters());
                return output.ToList();

            }
            finally
            {
                _dbConnection.Close();
            }        
        }
        public void SaveData<T>(T data, string sql)
        {
            _dbConnection.Open();
            try
            {
                _dbConnection.Execute(sql, data);
            }
            finally
            {
                _dbConnection.Close();
            }        
        }
        public void Update<T>(T data, string sql)
        {
            _dbConnection.Open();
            try
            {
                _dbConnection.Execute(sql, data);
            }
            finally
            {
                _dbConnection.Close();
            }        
        }
    }
}
