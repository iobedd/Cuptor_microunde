using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuptor_microunde
{
    internal class Stare_Gateste_On : Stare
    {
        private static Stare_Gateste_On singleton;

        private Stare_Gateste_On()
        {
        }

        public static Stare_Gateste_On Instance()
        {
            if (singleton == null)
            {
                singleton = new Stare_Gateste_On();
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
