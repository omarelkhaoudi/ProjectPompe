using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPompe
{
    class Client
    {
        private string num;
        private String nom;
        private String prenom;
        private Object carte;
        private DateTime dateNaissance;
        private String adresse;
        private String ville;
        private String numCarte;
        private DateTime dateDébutCarte;

        public static List<Client> ListeClient = new List<Client>();

        public string Num { get => num; set => num = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public object Carte { get => carte; set => carte = value; }
        public DateTime DateNaissance { get => dateNaissance; set => dateNaissance = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public string Ville { get => ville; set => ville = value; }
        public string NumCarte { get => numCarte; set => numCarte = value; }
        public DateTime DateDébutCarte { get => dateDébutCarte; set => dateDébutCarte = value; }

        public Client(string Num, string Nom, string Prenom,  DateTime DateNaissance, string Adresse, string Ville, string NumCarte, DateTime DateDébutCarte)
        {
            this.num = Num;
            this.nom = Nom;
            this.prenom = Prenom;
            this.dateNaissance = DateNaissance;
            this.adresse = Adresse;
            this.ville = Ville;
            this.numCarte = NumCarte;
            this.dateDébutCarte = DateDébutCarte;
        }
        public void AjouterClient(Client Cl)
        {

           Client.ListeClient.Add(Cl);

        }
      
    }

}
