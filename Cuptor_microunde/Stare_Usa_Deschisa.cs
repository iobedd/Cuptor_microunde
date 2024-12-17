using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuptor_microunde
{
    public class Stare_Usa_Deschisa : Stare
    {
        private static Stare_Usa_Deschisa singleton;

        private Stare_Usa_Deschisa()
        {
        }

        public static Stare_Usa_Deschisa Instance()
        {
            if (singleton == null)
            {
                singleton = new Stare_Usa_Deschisa();
            }
            return singleton;
        }
        public override void InchideUsa()
        {

        }
        public override void DeschideUsa()
        {

        }
        public override void Pornit()
        {

        }
        public override void Ticks()
        {

        }

    }
}
