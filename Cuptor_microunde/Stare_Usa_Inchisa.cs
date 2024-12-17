using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuptor_microunde
{
    public class Stare_Usa_Inchisa : Stare
    {
        private static Stare_Usa_Inchisa singleton;

        private Stare_Usa_Inchisa()
        {
        }

        public static Stare_Usa_Inchisa Instance()
        {
            if (singleton == null)
            {
                singleton = new Stare_Usa_Inchisa();
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
