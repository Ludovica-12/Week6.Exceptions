using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week6.Exceptions.Exercise.Core.Models;
using Week6.Exceptions.Exercise.Core.Repositories;

namespace Week6.Exceptions.Exercise.ADO
{
    class ADOUserRepository : IUserRepository
    {
        const string connectionString = @"Data Source = (localdb)\MSSQLLocalDB;" +
                                       "Initial Catalog = Utenti;" +
                                       "Integrated Security = true;";

        public bool Add(User item)
        {
            throw new NotImplementedException();
        }

        public bool DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> Fetch()
        {
            throw new NotImplementedException();
        }

        public User GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public User GetUserByCredentials(string username, string password)
        {
            User user = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "select * from User where Username = @username and Password = @password";

                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var uname = (string)reader["Username"];
                    var pwd = (string)reader["Password"];
                    var id = (int)reader["Id"];

                    user = new User(id, uname, pwd);
                }
            }
            return user;
        }

        public bool Update(User item)
        {
            throw new NotImplementedException();
        }
    }
}
