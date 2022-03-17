using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_1
{
    //Il est utilisé pour initialiser les données membres d'un nouvel objet en général. Le constructeur en C# porte le même nom que la classe ou la structure.
    internal class Constructeurx
    {
        public string Prenom;
        public int Age;
        public double Montant;

        //Constructeur par défaut
        public Constructeurx()
        {

        }

        //constructeur initialisation && Constructeur paramétré
        public Constructeurx(string Pre,int ag,double mont)
        {
            Prenom = Pre;
            Age = ag;
            Montant = mont;
        }
        public void Afficher()
        {
            Console.WriteLine("Le Prenom : {0} \nL' Age : {1}  \nMontant : {2} \n", Prenom, Age, Montant);
        }

    }
}
