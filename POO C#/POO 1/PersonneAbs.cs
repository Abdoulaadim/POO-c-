using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_1
{
    abstract internal class PersonneAbs
    {
        public string prenom, nom;
        public float saliare;


        public string nomComplet()
        {
            return this.nom +" "+this.prenom;
        }
        public abstract float calculesalaireAnnuel();
    }
}
