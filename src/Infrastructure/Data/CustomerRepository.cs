using Core.Entities;
using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
namespace Infrastructure.Data
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly IDBConnectionFactory _dbConnectionFactory;

        public CustomerRepository(IDBConnectionFactory dbConnectionFactory)
        {
            _dbConnectionFactory = dbConnectionFactory;
        }

        public async Task<Customer?> GetByIdAsync(int id)
        {
            using var connection = _dbConnectionFactory.CreateConnection();
            return await connection.QuerySingleOrDefaultAsync<Customer>(
                "SELECT * FROM Customers WHERE Id = @Id", new { Id = id });
        }

        public async Task<IEnumerable<Customer>> GetAllAsync()
        {
            using var connection = _dbConnectionFactory.CreateConnection();
            return await connection.QueryAsync<Customer>("SELECT * FROM Customers");
        }

        public async Task AddAsync(Customer customer)
        {
            using var connection = _dbConnectionFactory.CreateConnection();
            var sql = "INSERT INTO Customers (Name, Email) VALUES (@Name, @Email)";
            await connection.ExecuteAsync(sql, customer);
        }

        public async Task UpdateAsync(Customer customer)
        {
            using var connection = _dbConnectionFactory.CreateConnection();
            var sql = "UPDATE Customers SET Name = @Name, Email = @Email WHERE Id = @Id";
            await connection.ExecuteAsync(sql, customer);
        }

        public async Task DeleteAsync(int id)
        {
            using var connection = _dbConnectionFactory.CreateConnection();
            await connection.ExecuteAsync("DELETE FROM Customers WHERE Id = @Id", new { Id = id });
        }
    }
}
