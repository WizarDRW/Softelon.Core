using System;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using MySql.Data.MySqlClient;

namespace Softelon.Core.Context
{
    public class DapperContext : IDisposable
    {
        public static IDbConnection OpenConn(string _conn)
        {
            return new MySqlConnection(_conn);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
