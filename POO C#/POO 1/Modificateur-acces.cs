using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_1
{
    //public
    //private 
    //protected
    //static
    internal class ClassRoom
    {
        public string nom;
        public int cin;
        public double note;
        public static string professeur;

        public static void Afficher()
        {
            Console.WriteLine(professeur);
        }
        public void Afficherx()
        {
            Console.WriteLine(professeur);
        }
    }
}
