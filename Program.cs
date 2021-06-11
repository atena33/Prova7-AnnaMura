using System;
using System.Collections.Generic;


//Risposta 1 = C, D
//Risposta 2 = A, B
//Risposta 3: B
namespace Prova7_AnnaMura
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci un nome");
            var nome = Console.ReadLine();
            Gestore.FindUser(nome, Gestore.BuildList());

        }
    }
}
