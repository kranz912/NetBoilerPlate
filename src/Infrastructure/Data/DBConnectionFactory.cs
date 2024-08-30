using Core.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.Data.Sqlite;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    internal class DBConnectionFactory : IDBConnectionFactory
    {
        private readonly IConfiguration _configuration;

        public DBConnectionFactory(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IDbConnection CreateConnection()
        {
            string dbType = _configuration.GetValue<string>("DatabaseType") ?? "SQLServer";

            return dbType switch
            {
                "SQLite" => CreateSqliteConnection(),
                "SQLServer" => CreateSqlServerConnection(),
                _ => throw new NotSupportedException($"Unsupported database type: {dbType}")
            };
        }

        private IDbConnection CreateSqlServerConnection()
        {
            string connectionString = _configuration.GetConnectionString("SqlServerConnection")
                ?? throw new InvalidOperationException("SQL Server connection string is not configured.");
            return new SqlConnection(connectionString);
        }

        private IDbConnection CreateSqliteConnection()
        {
            string connectionString = _configuration.GetConnectionString("SQLiteConnection")
                ?? throw new InvalidOperationException("SQLite connection string is not configured.");
            return new SqliteConnection(connectionString);
        }


    }
}
