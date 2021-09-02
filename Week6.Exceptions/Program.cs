using System;
using System.IO;
using Week6.Exceptions.ThrowExample;

namespace Week6.Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Divisione(6, 2); //Tutto ok
            //Divisione(6, 0); //Da eccezione

            #region Try.. catch
            //try
            //{
            //    Divisione(6, 0);
            //}
            //catch(Exception ex) //Gestore generico per la risoluzione del problema e cattura ogni tipo di eccezione
            //{
            //    Console.WriteLine("Errore!");
            //}

            //------------Oppure---------------

            //try
            //{
            //    Divisione(6, 0);
            //}
            //catch (DivideByZeroException ex) //O anche ArithmeticException
            //{
            //    Console.WriteLine("Errore!");
            //}

            //try.. catch //--> Si possono mettere più clausole catch

            //try
            //{
            //    Divisione(6, 0);
            //}
            //catch (OutOfMemoryException ex)
            //{
            //    Console.WriteLine("Errore memoria!");
            //}
            //catch (ArithmeticException e) 
            //{
            //    Console.WriteLine("Errore Matematico!");
            //}
            //catch (Exception exc)
            //{
            //    Console.WriteLine("Errore!");
            //}
            #endregion

            #region Try... Finally e Try...catch...finally

            //TryConvert("34");
            //TryConvert("abc");

            TryToReadFile();

            #endregion

            #region Throw

            //UserManager.FetchUsers(); //Viene scatenata un eccezione che dovrebbe ritornare all'utente come una lista 

            //UserManager.TryAddUser("Pluto", "1234");
            //UserManager.TryAddUser(null, "1234");

            #endregion

            #region Inner Exception
            TryUserDivision();
            #endregion


        }

        //Metodo che esegue la divisione
        private static void Divisione(int a, int b)
        {
            int result = a / b;//-> Scatena un'eccezione

            Console.WriteLine(result); //codice mai raggiunto
        }

        //Metodo che prova a convertire una stringa in un intero
        private static void TryConvert(string s)
        {
            try
            {
                int result = int.Parse(s);
            }
            finally
            {
                Console.WriteLine("Coice raggiunto a prescindere che venga o meno scatenata un'eccezione");
            }
        }

        //Metodo che prova a leggere da un file
        private static void TryToReadFile()
        {
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(@"C:\User\LudovicaLucidi\Desktop\");
                string content = sr.ReadToEnd();
                Console.WriteLine(content);
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                if (sr != null)
                    sr.Close();
            }
        }

        //Metodo che prova a fare la dvisione e se non ci riesce, salva le informazioni su un file
        private static void UserDivision()
        {
            try
            {
                Console.WriteLine("Inserisci un numero intero");
                int n = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Inserisci un numero intero");
                int m = Convert.ToInt32(Console.ReadLine());

                int result = n / m;

                Console.WriteLine($"Il risulato è {result}");
            }
            catch(Exception ex) //Se viene catturata l'eccezione, va a scrivere i dettagli nel file al path indicato
            {
                string path = @"";

                if(File.Exists(path))
                {
                    StreamWriter sw = new StreamWriter(path);
                    sw.Write(ex.ToString());
                    sw.Close();
                }
                else
                {
                    throw new FileNotFoundException(path + "non contiene un file su cui scrivere", ex); //costruttore con message, innerException
                }
            }

        }

        private static void TryUserDivision()
        {
            try
            {
                UserDivision();
            }
            catch (Exception exc)
            {
                Console.WriteLine("Eccezione più 'esterna' ", exc.ToString());

                if(exc.InnerException != null)
                {
                    Console.WriteLine("Eccezione più 'interna' " + exc.InnerException.ToString());
                }

                throw;
            }
        }

    }
}
