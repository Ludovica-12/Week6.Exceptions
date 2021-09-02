using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week6.Exceptions.Exercise.Core.Models;
using Week6.Exceptions.Exercise.Core.Repositories;

namespace Week6.Exceptions.Exercise.Mock
{
    class MockUserRepository : IUserRepository
    {
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
            throw new NotImplementedException();
        }

        public bool Update(User item)
        {
            throw new NotImplementedException();
        }
    }
}
