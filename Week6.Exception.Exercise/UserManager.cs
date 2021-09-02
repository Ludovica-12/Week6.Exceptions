using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week6.Exception.Exercise.ADO.Repositories;
using Week6.Exceptions.Exercise.Core.Entites;
using Week6.Exceptions.Exercise.Mock.Repositories;

namespace Week6.Exceptions.Exercise
{
    class UserManager
    {
        //public static MockUserRepository userReporitory = new MockUserRepository();
        public static UserAdoRepository userReporitory = new UserAdoRepository();

        internal static void Login()
        {
            string username = string.Empty;
            do
            {
                Console.WriteLine("Inserisci username");
                username = Console.ReadLine();

            } while (string.IsNullOrEmpty(username));

            string password = string.Empty;
            do
            {
                Console.WriteLine("Inserisci password");
                password = Console.ReadLine();

            } while (string.IsNullOrEmpty(password));

            try
            {
                User user = userReporitory.GetUserByCredentials(username, password);

                if (user != null)
                    Console.WriteLine("Login avvenuto con successo");
                else
                    Console.WriteLine("Username o password non validi");
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
