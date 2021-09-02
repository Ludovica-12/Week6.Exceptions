using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week6.Exceptions.Exercise.ADO;
using Week6.Exceptions.Exercise.Core.Models;

namespace Week6.Exceptions.Exercise
{
    public class DbManager
    {
        static ADOUserRepository userRepository = new ADOUserRepository();

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
                User user = userRepository.GetUserByCredentials(username, password);

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
