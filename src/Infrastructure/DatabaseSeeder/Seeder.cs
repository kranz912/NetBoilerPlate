using Core.Interfaces;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DatabaseSeeder
{
    public class Seeder
    {
        private readonly IDBConnectionFactory _dbConnectionFactory;
        public Seeder(IDBConnectionFactory dbConnectionFactory)
        {
            _dbConnectionFactory = dbConnectionFactory;

        }
        public void SeedDatabase()
        {
            using IDbConnection db = _dbConnectionFactory.CreateConnection();
            db.Open();

            var seedScript = File.ReadAllText("../Infrastructure/DatabaseSeeder/SQLScripts/SeedCustomers.sql");
            db.Execute(seedScript);

            db.Close();

        }
    }
}
