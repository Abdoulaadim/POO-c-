using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_1
{
    internal class salariespecial : PersonneAbs
    {
        public int hoursTravailSupp;

        public salariespecial(int hoursTravailSupp)
        {
            this.hoursTravailSupp = hoursTravailSupp;
        }


        public override float calculesalaireAnnuel()
        {
            return base.saliare * 12 +this.hoursTravailSupp * 8 ;

        }
    }
}
