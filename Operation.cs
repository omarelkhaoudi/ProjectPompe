// File:    Operation.cs
// Author:  Omar
// Created: mardi 1 juin 2021 10:13:11
// Purpose: Definition of Class Operation

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPompe
{
    class Operation
    {
        private string numéroOpération;
        private string typeCarburant;
        private float nombreLitre;
        private String typeRemplissage;
        private DateTime lheure;
        private DateTime dateRemplissage;
        private float prixLitre;
        private float montant;
       
        public static List<Operation> ListeOperation = new List<Operation>();

        public string NuméroOpération { get => numéroOpération; set => numéroOpération = value; }
        public string TypeCarburant { get => typeCarburant; set => typeCarburant = value; }
        public float NombreLitre { get => nombreLitre; set => nombreLitre = value; }
        public string TypeRemplissage { get => typeRemplissage; set => typeRemplissage = value; }
        public DateTime Lheure { get => lheure; set => lheure = value; }
        public DateTime DateRemplissage { get => dateRemplissage; set => dateRemplissage = value; }
        public float PrixLitre { get => prixLitre; set => prixLitre = value; }
        public float Montant { get => montant; set => montant = value; }


        public Operation() { }
        public Operation(string NuméroOpération, string TypeCarburant, float NombreLitre, string TypeRemplissage, DateTime Lheure, DateTime DateRemplissage, float PrixLitre, float Montant)
        {
            this.numéroOpération = NuméroOpération;
            this.typeCarburant = TypeCarburant;
            this.nombreLitre = NombreLitre;
            this.typeRemplissage = TypeRemplissage;
            this.lheure = Lheure;
            this.dateRemplissage = DateRemplissage;
            this.prixLitre = PrixLitre;
            this.montant = Montant;
        }
        public void AjouterOP(Operation Op)
        {

            Operation.ListeOperation.Add(Op);

        }
       
    }
}
