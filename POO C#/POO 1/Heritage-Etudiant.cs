using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_1
{
    internal class Heritage_Etudiant :Heritage_Person
    {

        public float note;

        public Heritage_Etudiant(string prenom, string nom,float note) : base(prenom, nom)
        {
            this.note = note;
        }

        //public Heritage_Etudiant(string prenom, string nom, float note)
        //{
        //    base.prenom = prenom;
        //    base.nom = nom;
        //    this.note = note;
        //}




    }
}
