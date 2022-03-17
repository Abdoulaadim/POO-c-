using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_1
{
    internal class Getter_Setter_ClubSportif
    {
        private string nom;
        private int age;
        private bool autorisation;

        //Accesseur 
        public string Nom
        {
            set { nom = value; }
            get { return nom; }
        }

        public int Age
        {
            set {
                if (age >= 15)
                {
                    age = value;
                    autorisation = true;
                }
                
            }
            get { return age; }
        }

        public bool Autorisation
        {
            set { autorisation = value; }
            get { return autorisation; }
        }
    }
}
