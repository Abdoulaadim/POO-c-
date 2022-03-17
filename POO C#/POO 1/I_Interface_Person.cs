using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_1
{
    internal interface I_Interface_Person
    {
        string nom { get; set; }
        string prenom { get; set; }
        string AfficherNomComplet(string prenom, string nom);

    }
}
