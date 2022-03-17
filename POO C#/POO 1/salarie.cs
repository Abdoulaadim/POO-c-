using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_1
{
    internal class Salarie : PersonneAbs
    {
       

        public override float calculesalaireAnnuel()
        {
            return base.saliare * 12;
        }
    }
}
