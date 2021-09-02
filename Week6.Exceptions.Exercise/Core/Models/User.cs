using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6.Exceptions.Exercise.Core.Models
{
    class User
    {
        public int Id;
        public string Username;
        public string Password;

        public User()
        {
        }

        public User(int id, string uname, string pwd)
        {
            Id = id;
            Username = uname;
            Password = pwd;
        }
    }
}
