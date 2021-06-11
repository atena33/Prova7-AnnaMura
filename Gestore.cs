using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova7_AnnaMura
{
    static class Gestore
    {
        public static List <Utente> BuildList()
        {
            Utente u1 = new Utente("Mario", "Rossi");
            Utente u2 = new Utente("Marco", "Bianchi");
            List<Utente> utenti = new List<Utente>();
            utenti.Add(u1);
            utenti.Add(u2);
            return utenti;
        }

        public static void FindUser(string nome, List<Utente> utenti)
        {
            
            foreach (var utente in utenti)
            {
                if (utente.Nome == nome)
                {
                    Console.WriteLine($"{utente.Nome} {utente.Cognome}");
                }
                else
                {
                    throw new UserNotFoundException("Utente non trovato");
                }

            }
        }
    }
}
