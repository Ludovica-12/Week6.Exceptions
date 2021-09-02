using System;
using Week6.Exceptions.Exercise.Client;

namespace Week6.Exceptions.Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Scrivere un programma che consente di fare login
            //L'utente deve poter inserire il suo usarname e la password
            //Il programma cerca di recuperare i dati dal database 'Utenti'
            //Identità utente ha:
            //- Id
            //- Username
            //- Password

            //Se l'utente è già nel db, comparirà un messaggio: "Login avvenuto con successo"

            //(ADO Connected Mode)

            //Tenere in considerazione che potrebbe mancare la connessone al db, la stringa di connessione potrebbe essere sbagliata..
            //gestendo le eventuali eccezioni (SqlException).

            Menu.Start();

        }
    }
}
