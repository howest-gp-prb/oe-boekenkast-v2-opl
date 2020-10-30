using System;
using System.Collections.Generic;
using System.Text;

namespace Prb.Boekenkast.Core
{
    public class Auteur
    {
        public string Naam { get; set; }
        public string Nationaliteit { get; set; }
        public Geslacht Geslacht { get; set; }

        public Auteur(string naam, string nationaliteit, Geslacht geslacht)
        {
            Naam = naam;
            Nationaliteit = nationaliteit;
            Geslacht = geslacht;
        }
        public override string ToString()
        {
            return Naam;
        }
    }
}
