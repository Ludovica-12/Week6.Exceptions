using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week6.Exceptions.Exercise.Core.Entites;

namespace Week6.Exceptions.Exercise.Core.Repositories
{
    interface IUserRepository: IRepository<User>
    {
        User GetUserByCredentials(string username, string password);
    }
}
