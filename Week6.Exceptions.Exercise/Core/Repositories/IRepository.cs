using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6.Exceptions.Exercise.Core.Repositories
{
    interface IRepository<T>
    {
        List<T> Fetch();
        T GetByID(int id);
        bool Add(T item);
        bool Update(T item);
        bool DeleteById(int id);
    }
}
