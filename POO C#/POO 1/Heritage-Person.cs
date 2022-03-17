using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_1
{
    internal class Heritage_Person
    {
        public string prenom;
        public string nom;
        protected DateTime dateNaissance; // definit sur la classe mere et les classe fille 
        private  DateTime dateNaissances;

        public Heritage_Person(string prenom, string nom)
        {
            this.prenom = prenom;
            this.nom = nom;
        }

        public string AfficherNomComplet()
        {
            this.dateNaissances = DateTime.Now;
            return this.prenom+" "+this.nom;    
        }

        public float CalculAge(DateTime dateNaissance)
        {
            return 0;
        }
    }
}
