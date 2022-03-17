using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_1
{
    internal class Polymorphisme_Employee
    {
        public string nom;
        public DateTime dateRecrutement;
        public float salaire;

        public Polymorphisme_Employee(string nom, DateTime dateRecrutement, float salaire)
        {
            this.nom = nom;
            this.dateRecrutement = dateRecrutement;
            this.salaire = salaire;
        }

        //virtual  => mais la redifinissient dans la classe fille 
        public virtual float CalculerSalaireAnnuel()
        {
            return this.salaire * 12;
             
        }

        public override string ToString()
        {
            return "Nom Complet est :" + this.nom;
        }
    }
}
