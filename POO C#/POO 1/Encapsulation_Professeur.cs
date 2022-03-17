using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_1
{
    internal class Encapsulation_Professeur
    {
        private string nom;

        public string Nom
        {
            //get { return this.nom; }
            //set { this.nom = value; }

            //get => this.nom;
            //set => this.nom = value;

            get => (this.nom != "") ? this.nom : "le nom est vide";
            set => this.nom = value;

        }
    }
}
