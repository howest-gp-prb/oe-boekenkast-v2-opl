using System;
using System.Collections.Generic;
using System.Text;

namespace Prb.Boekenkast.Core
{
    public class Bibliotheek
    {
        public List<Boek> Boeken { get; set; }
        public List<Auteur> Auteurs { get; set; }

        public Bibliotheek()
        {
            Boeken = new List<Boek>();
            Auteurs = new List<Auteur>();
            VulTestgevens();
        }
        private void VulTestgevens()
        {
            Auteur auteur1 = new Auteur("Boon", "Belg", Geslacht.Man);
            Auteur auteur2 = new Auteur("Tuchman", "USA", Geslacht.Vrouw);
            Auteur auteur3 = new Auteur("Cronwell", "UK", Geslacht.Man);

            Auteurs.Add(auteur1);
            Auteurs.Add(auteur2);
            Auteurs.Add(auteur3);

            Boek boek1 = new Boek("De bende van Jan Delichte", 1999, auteur1);
            Boek boek2 = new Boek("De trotse toren", 1999, auteur2);
            Boek boek3 = new Boek("De kanonnen van augustus", 1999, auteur2);
            Boek boek4 = new Boek("Azincourt", 1999, auteur3);

            Boeken.Add(boek1);
            Boeken.Add(boek2);
            Boeken.Add(boek3);
            Boeken.Add(boek4);


        }
    }
}
