using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_1
{
    internal class Interface_Etudiant : I_Interface_Person
    {
        private string nom;
        private string prenom;

        string I_Interface_Person.nom { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string I_Interface_Person.prenom { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }



        //public string Nom
        //{
        //    set { this.nom = value; }
        //    get { return this.nom; }

        //}

        //public string Prenom
        //{ 
        //    set { this.prenom = value; }
        //    get { return this.prenom; }

        //}



        public string AfficherNomComplet(string prenom, string nom)
        {
            return nom + " " + prenom; 
        }





    }
}
