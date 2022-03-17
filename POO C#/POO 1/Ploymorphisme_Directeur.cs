using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_1
{
    internal class Ploymorphisme_Directeur : Polymorphisme_Employee
    {
        private float tauxPrime;

        public Ploymorphisme_Directeur(string nom, DateTime dateRecrutement, float salaire) : base(nom, dateRecrutement, salaire)
        {
            this.tauxPrime = 0.1F   ;
        }

        public override float CalculerSalaireAnnuel()
        {
            return base.CalculerSalaireAnnuel() + (base.salaire * this.tauxPrime);
        }

        public override string ToString()
        {
            return base.ToString() + "taux prime : " + this.tauxPrime;
        }

        //public override float CalculerSalaireAnnuel()
        //{
        //    return (base.salaire * 12) + (base.salaire * this.tauxPrime);
        //}

        //public new float CalculerSalaireAnnuel()
        //{
        //    return (base.salaire * 12) + (base.salaire * this.tauxPrime);
        //}
    }
}
