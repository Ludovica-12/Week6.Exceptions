using System;
using System.Linq;
using Week6.EF.Core.Models;
using Week6.EF.EF;

namespace Week6.EF
{
    class Program
    {
        //Istanza di KnightsContext:
        private static KnightsContext _knightsContext = new KnightsContext();

        static void Main(string[] args)
        {
            _knightsContext.Database.EnsureCreated(); //Per assicurarsi dell'esistenza del db.
                                                      //Se non esiste, lo crea.
                                                      //(questo metodo si usa nei test)

            //Recuperiamo tutti i cavalieri
            Console.WriteLine("Prima dell'aggiunta");
            //FetchKnights();
            //Aggiungiamo un cavaliere
            //AddKnights();

            //Recuperiamo tutti i cavalieri dopo l'aggiunta
            Console.WriteLine("Dopo dell'aggiunta");
            //FetchKnights();

            //Aggiunta tipi diversi
            //AddVariousTypes();

            //Filtrare tutti i cavalieri con nome Orar

            //Recuperare il primo con il nome Oscar

            //Recuperare un cavaliere con un certo Id

            //Update cavaliere
            GetAndUpDateKnight();

            //Delete cavaliere
            GetAndDelete();
            
        }

        private static void FetchKnights()
        {
            //Query LINQ
            var knights = _knightsContext.Knights.ToList();

            //var query = _knightsContext.Knights;
            //var kinghts = query.ToList();

            //stampiamo il numero di record di cavalieri nella tabella db
            Console.WriteLine($"Il numero di cavalieri è: {knights.Count}");

            //Stampiamo i noi dei cavalieri nel db
            foreach(var k in knights)
            {
                Console.WriteLine(k.Name);
            }

            foreach (var k in _knightsContext.Knights)
            {
                Console.WriteLine(k.Name);
            }


        }

        private static void AddKnights()
        {
            var newKnight = new Knight { Name = "Giulio" }; //avrà una lista di armi vuota

            _knightsContext.Knights.Add(newKnight);

            _knightsContext.SaveChanges();

        }

        private static void AddVariousTypes()
        {
            _knightsContext.AddRange(
                new Knight { Name = "Driacco" },
                new Battle { Name = "Cassel" }
                );

            _knightsContext.SaveChanges();

        }

        private static void GetByName()
        {
            var knights = _knightsContext.Knights.Where(k => k.Name == "Orar").ToList();
        }

        private static void FilterByName()
        {
            var name = "Driacco";
            var knights = _knightsContext.Knights.Where(k => k.Name == name).ToList();
        }

        private static void GetFirstByName() //Recupera il primo che trova con un certo nome
        {
            var name = "Orar";
            //var knight = _knightsContext.Knights.Where(k => k.Name == name).First();
            //var knight = _knightsContext.Knights.Where(k => k.Name == name).FirstOrDefault(); //Se non trova niente da null
            var knight = _knightsContext.Knights.FirstOrDefault(k => k.Name == name);
        }

        public static void GetKnightById()
        {
            var knight = _knightsContext.Knights.FirstOrDefault(k => k.Id == 1);
        }

        public static void GetKnightById_Find()
        {
            var knight = _knightsContext.Knights.Find(1);
        }

        public static void GetAndUpDateKnight()
        {
            var knight = _knightsContext.Knights.FirstOrDefault();

            knight.Name = "Valfred";

            _knightsContext.SaveChanges();

        }

        public static void GetAndDelete()
        {
            //Voglio cancellare un cavaliere tramite il suo id
            var knight = _knightsContext.Knights.Find();

            _knightsContext.Knights.Remove(knight);

            _knightsContext.SaveChanges();
        }

    }
}
