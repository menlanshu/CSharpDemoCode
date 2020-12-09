using Dapper;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DBAccessDemo
{
    public class OracleAccessDemo
    {
        IDbConnection _myconn;

        public OracleAccessDemo(IDbConnection dbConnection)
        {
            _myconn = dbConnection;
        }

        public void TestReadData(string sql)
        {
            try
            {
                _myconn.Open();
                using OracleCommand oracleCommand = new OracleCommand(sql);
                oracleCommand.Connection = (OracleConnection)_myconn;

                var reader = oracleCommand.ExecuteReader();
                reader.Read();
                while (reader.Read())
                {
                    Console.WriteLine(reader.GetInt32(0) + ", " + reader.GetString(1));
                }
            }
            finally
            {
                _myconn.Close();
            }
        }

        public int ExecuteNonQuery(string sql, params OracleParameter[] parameters)
        {
            _myconn.Open();
            try
            {
                using (OracleCommand cmd = (OracleCommand)_myconn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddRange(parameters);
                    return cmd.ExecuteNonQuery();
                }

            }
            finally
            {
                _myconn.Close();
            }
        }

        public DataTable ExecuteDataTable(string sql, params OracleParameter[] parameters)
        {
            _myconn.Open();
            try
            {
                using (OracleCommand cmd = (OracleCommand)_myconn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddRange(parameters);
                    OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                    DataTable datatable = new DataTable();
                    adapter.Fill(datatable);
                    return datatable;
                }

            }
            finally
            {
                _myconn.Close();
            }
        }
        public IEnumerable<T> ExecuteDataTableWithDapper<T>(string sql, params OracleParameter[] parameters)
        {
            _myconn.Open();
            try
            {
                var result = ((OracleConnection)_myconn).Query<T>(sql);
                return result;
            }
            finally
            {
                _myconn.Close();
            }
        }
    }
}
