using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week6.Exceptions.Exercise.Core.Entites;
using Week6.Exceptions.Exercise.Core.Repositories;

namespace Week6.Exception.Exercise.ADO.Repositories
{
    class UserAdoRepository : IUserRepository
    {
        const string connectionString = @"Data Source = (localdb)\MSSQLLocalDB;" +
                                          "Initial Catalog = Calendar;" +
                                          "Integrated Security = true;";

        public void Add(User item)
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
                command.CommandText = "select * from Utente where Username = @username and Password = @password";

                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var uname = (string)reader["Username"];
                    var pwd = (string)reader["Password"];
                    var id = (int)reader["Id"];

                    user = new User(uname, pwd, id);
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
