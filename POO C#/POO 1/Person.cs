using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_1
{
    internal class Person
    {
        public string nom;
        public char genre;
        public string emploi;
        public int age;


        public void Afficher()
        {
            Console.WriteLine("Le nom : {0} \nLe Genre : {1}  \nl'emploi : {2} \nAge : {3}\n", nom, genre, emploi, age);
        }
    }
}
