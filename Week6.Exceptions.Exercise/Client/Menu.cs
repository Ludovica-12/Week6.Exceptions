using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6.Exceptions.Exercise.Client
{
    class Menu
    {
        internal static void Start()
        {
            bool continuare = true;

            do
            {
                Console.WriteLine("Premi 1 per fare Login");
                Console.WriteLine("Premi 0 per uscire");
                Console.WriteLine();
                string scelta = Console.ReadLine();

                switch (scelta)
                {
                    case "1":
                        DbManager.Login();
                        break;
                    case "0":
                        Console.WriteLine("Ciao!");
                        continuare = false;
                        break;
                    default:
                        Console.WriteLine("Scelta sbagliata riprova");
                        break;
                }
            } while (continuare);
        }
    }
}
