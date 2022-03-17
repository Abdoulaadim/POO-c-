using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_1
{
    internal class Professeur_heritage:Heritage_Person
    {

        public float salaire;

        public Professeur_heritage(string prenom, string nom, float salaire) : base(prenom, nom)
        {
            this.salaire = salaire;
        }



        //public Professeur_heritage(string prenom, string nom, float salaire) : base(prenom, nom)
        //{
        //    base.prenom = prenom;
        //    base.nom = nom;
        //    this.salaire = salaire;
        //}

        //public Professeur_heritage(string prenom, string nom, float salaire) 
        //{
        //    base.prenom = prenom;
        //    base.nom = nom;
        //    this.salaire = salaire;
        //}


    }
}
