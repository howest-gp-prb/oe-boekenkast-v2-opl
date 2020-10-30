using System;
using System.Collections.Generic;
using System.Text;

namespace Prb.Boekenkast.Core
{
    public class Boek
    {
        public string Titel { get; set; }
        public int Jaar { get; set; }
        public Auteur Auteur { get; set; }

        public Boek(string titel, int jaar, Auteur auteur)
        {
            Titel = titel;
            Jaar = jaar;
            Auteur = auteur;
        }
        public override string ToString()
        {
            return Titel;
        }
    }
}
