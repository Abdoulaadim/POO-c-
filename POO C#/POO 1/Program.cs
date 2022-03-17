using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_1
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            Person p1 = new Person();

            p1.nom = "Mabrouki";
            p1.emploi = "Developpeur";
            p1.genre = 'H';
            p1.age = 25;

            p1.Afficher();

            Person p2 = new Person();

            p2.nom = "Abdoulaadim";
            p2.emploi = "Developpeur";
            p2.genre = 'H';
            p2.age = 25;

            p1.Afficher();


            //_________________________Constructeur________________________________//

            Constructeurx C1 = new Constructeurx();
            C1.Prenom = "Ahmed";
            C1.Age = 30;
            C1.Montant = 1000;

            C1.Afficher();

            Constructeurx C2 = new Constructeurx("Morad",30,1000);
            C2.Afficher();

            //_______________________Tableau,List,ArrayList,Dictionary___________________//
            
            /*Tableau*/

            int[]T = new int[3];
            T[0] = 3;
            T[1] = 9;
            T[2] = 2;

            for (int i = 0; T.Length > i; i++)
            {
                Console.WriteLine(T[i]);
            }

            Console.WriteLine("\n");

            /*List*/

            List<double> ls = new List<double>();
            ls.Add(12.4);
            ls.Add(13.5);
            ls.Add(2.7);
            ls.Add(20.20);
            ls.Add(19.21);

            Console.WriteLine(ls.Count);

            Console.WriteLine("\n");

            /*ArrayList*/
            
            ArrayList ar = new ArrayList();

            ar.Add(12);
            ar.Add("Mabrouki");
            ar.Add(12.34);
            ar.Add(true);
            
            foreach (object elem in ar)
            {
                Console.WriteLine(elem + "");
            }

            Console.WriteLine("\n");

            /*Dictionary*/

            Dictionary<string, string> Dc = new Dictionary<string, string>();
            Dc.Add("Hous", "Maison");
            Dc.Add("computer", "Ordinateur");

            Console.WriteLine(Dc["Hous"]);

            Console.WriteLine("\n");

            //___________________________________Exception_____________________________//

            try
            {
                //int i = int.Parse(Console.ReadLine());
                //int i = int.Parse("az");
                int i = 3;
                Console.WriteLine(i);

            }
            catch 
            {
                Console.WriteLine("Valeur incorrect");
    
                
            }
            Console.WriteLine("\n");
            Console.WriteLine("Fin");
            Console.WriteLine("\n");
            /*_______________________________________________________________*/
            int x = 9;
            int y = 0;
            try
            {
                int result = x / y;

            }
            catch (Exception Ex)
            {

                Console.WriteLine(Ex);
            }

            finally
            {
                Console.WriteLine("finaly");
            }

            Console.WriteLine("\n");
            Console.WriteLine("Fin");
            Console.WriteLine("\n");


            //__________________static__________________________//

            ClassRoom cl = new ClassRoom();

            cl.nom = "Ahmed";
            cl.cin = 191;
            cl.note = 19;
            ClassRoom.professeur = "Mabrouki";

            ClassRoom.Afficher();
            cl.Afficherx();

            Console.WriteLine("\n");

            //____________________Getter && Setter___________________//


            //-------------------Heriage---------------------------//
            Professeur_heritage pro = new Professeur_heritage("Mabrouki","Abdoulaadim",1203994);
            string profNomComplet =    pro.AfficherNomComplet();

            Console.WriteLine("Le nom complet de professeur : "+profNomComplet);

            Console.WriteLine("\n");


            //---------------Inerface-------------------------//

            Interface_Etudiant inte = new Interface_Etudiant();

            string NomComplet = inte.AfficherNomComplet("Mabrouki", "Abdoulaadim");
            Console.WriteLine("Nom cmplet " +NomComplet);



            Console.WriteLine("\n");


            //------------------Abstract----------------------//

            salariespecial s1 = new salariespecial(10)
            {
                prenom = "Achraf",
                nom = "Achraf",
                saliare = 1000,
            };

            Console.WriteLine("Mr" + s1.nomComplet());
            Console.WriteLine("votre salaire annuel : " + s1.calculesalaireAnnuel());
            Console.WriteLine("\n");
            Console.WriteLine("\n");
    
            //------------------Polymorphisme----------------------//

            Ploymorphisme_Directeur dr1 = new Ploymorphisme_Directeur("MAbrouki Abdoulaadim",new DateTime(2022,06,01),1212191F);
            float salaireannuel = dr1.CalculerSalaireAnnuel();
            Console.WriteLine("Votre salaire annuel est : " +salaireannuel);


            Console.WriteLine("\n");
            Console.WriteLine("\n");

            Polymorphisme_Employee dr2 = new Ploymorphisme_Directeur("MAbrouki Abdoulaadim", new DateTime(2022, 06, 01), 100000);

            if(dr2 is Ploymorphisme_Directeur)
            {
                Console.WriteLine("l'employee est un directeur ");
            }
            else
            {
                Console.WriteLine("l'employee n' est pas un directeur ");
            }
            float salaireannuel2 = dr1.CalculerSalaireAnnuel();
            Console.WriteLine("Votre salaire annuel est : " + salaireannuel2);

            Console.WriteLine("\n");
            Console.WriteLine("\n");

            Polymorphisme_Employee dr3 = new Ploymorphisme_Directeur("MAbrouki Abdoulaadim", new DateTime(2022, 06, 01), 100000);

            Ploymorphisme_Directeur dir = (Ploymorphisme_Directeur)dr3; //cast

            float salaireannuel3 = dir.CalculerSalaireAnnuel();
            Console.WriteLine("Votre salaire annuel est : " + salaireannuel3);



            Console.WriteLine("\n");
            Console.WriteLine("\n");


            Polymorphisme_Employee dr4 = new Ploymorphisme_Directeur("MAbrouki Abdoulaadim", new DateTime(2022, 06, 01), 100000);

            Console.WriteLine(dr4.ToString());

            Console.WriteLine("\n");
            Console.WriteLine("\n");


            //------------------Encapsulation----------------------//
            Encapsulation_Professeur prof = new Encapsulation_Professeur();
            prof.Nom = "Mabroooouki";
            string name = prof.Nom;





            Console.ReadKey();


        }
    }
}
