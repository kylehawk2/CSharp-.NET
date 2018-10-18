using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Data;
using MySql.Data.MySqlClient;
using Dapper_Practice.Models;

namespace DapperApp.Factory
{
    public class UserFactory
    {
        private string connectionString;
        public UserFactory()
        {
            connectionString = "server=localhost;userid=root;password=root;port=8889;database=dapper_practice;SslMode=None";
        }
        internal IDbConnection Connection
        {
            get {
                return new MySqlConnection(connectionString);
            }
        }

        public User FindByID(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                IEnumerable<User> result = Connection.Query<User>("SELECT * FROM users WHERE user_id = {id}");
                return result.First();
            }
            
        }
    }
}