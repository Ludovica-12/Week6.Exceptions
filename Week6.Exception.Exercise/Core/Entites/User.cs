using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6.Exceptions.Exercise.Core.Entites
{
    class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public int? Id { get; set; }

        public User()
        {

        }
        public User(string username, string password, int? id)
        {
            Username = username;
            Password = password;
            Id = id;
        }
    }
}
