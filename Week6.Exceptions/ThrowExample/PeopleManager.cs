using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6.Exceptions.ThrowExample
{
    public class PeopleManager
    {
        public static List<Person> users = new List<Person>();

        public static List<Person> FetchUsers()
        {
            if (users == null) throw new ArgumentNullException("Lista null");
            if (users.Count == 0) throw new ArgumentNullException("Non ci sono utenti nella lista");

            return users;
        }

        private static Person AddUser(string username, string password)
        {
            if (username == null) throw new ArgumentNullException("email null");
            if (password == null) throw new ArgumentNullException("password null");

            Person u = new Person { Username = username, Password = password };

            return u;

        }

        //public static void TryAddUser(string username, string password)
        //{
        //    try
        //    {
        //        User user = AddUser(username, password);
        //    }
        //    catch (ArgumentNullException ex)
        //    {
        //        Console.WriteLine(ex.ToString());
        //    }
        //}

        public static void TryAddUser(string username, string password)
        {
            try
            {
                Person user = AddUser(username, password);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.StackTrace);
                throw;//Se catturi l'eccezione rilanciala
                //throw ex;//Viene alterato lo stack delle chiamate
            }
        }
    }
}
