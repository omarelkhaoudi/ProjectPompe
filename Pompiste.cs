// File:    Pompiste.cs
// Author:  Omar
// Created: mardi 1 juin 2021 12:00:58
// Purpose: Definition of Class Pompiste

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPompe
{
    class Pompiste
    {
        private string numpompiste;
        private String cnspompiste;
        private String nompompiste;
        private String prenompompiste;
        private String sexepompiste;
        private char situationfamiliale;
        private String addresse;
        private String ville;
        private string numTele;
        public static List<Pompiste> ListePompiste = new List<Pompiste>();
                   


        public Pompiste(string numpompiste, string cnspompiste, string nompompiste, string prenompompiste, string addresse,  string numTele)
        {
            this.numpompiste = numpompiste;
            this.cnspompiste = cnspompiste;
            this.nompompiste = nompompiste;
            this.prenompompiste = prenompompiste;
            //this.sexepompiste = sexepompiste;
            //this.situationfamiliale = situationfamiliale;
            this.addresse = addresse;
            //this.ville = ville;
            this.numTele = numTele;
        }

        public string Numpompiste { get => numpompiste; set => numpompiste = value; }
        public string Cnspompiste { get => cnspompiste; set => cnspompiste = value; }
        public string Nompompiste { get => nompompiste; set => nompompiste = value; }
        public string Prenompompiste { get => prenompompiste; set => prenompompiste = value; }
        public string Sexepompiste { get => sexepompiste; set => sexepompiste = value; }
        public char Situationfamiliale { get => situationfamiliale; set => situationfamiliale = value; }
        public string Addresse { get => addresse; set => addresse = value; }
        public string Ville { get => ville; set => ville = value; }
        public string NumTele { get => numTele; set => numTele = value; }
    
      public void AjouterPomPiste( Pompiste Pom)
        {
            Pompiste.ListePompiste.Add(Pom);
        }

       

    }
    
}

