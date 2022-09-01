using Dapper;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using WebApplication4.Models;

namespace WebApplication4.Commands
{
    public class UserCommand
    {
        private string connStr = DbConnectionString.ConnectionString;

        public UserCommand()
        { 
        }

        public IList<User> GetAll()
        {
            using (var conn = new SqlConnection(connStr))
            {
                return new List<User>();
            }
        }

        public User Get(int? id)
        {
            if (id != null)
            {
                using (var conn = new SqlConnection(connStr))
                {
                    string sql = $"SELECT * FROM Users WHERE UID = {id}";
                    return conn.Query<User>(sql).ToList().FirstOrDefault();
                }
            }
            else
            {
                return null;
            }
        }

        public IList<User> Find(string username)
        {
            using (var conn = new SqlConnection(connStr))
            {
                string sql = $"SELECT * FROM Users WHERE Username like '{username}'";
                return conn.Query<User>(sql).ToList();
            }
        }
    }
}