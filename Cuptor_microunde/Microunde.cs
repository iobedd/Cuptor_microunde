using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuptor_microunde
{
    public class Microunde
    {
        //singleton + clasa context
        public Enums.StareUsa StareUsa
        { get; set; }

        public Enums.StareMicrounde StareMicrounde
        { get; set; }

        public int Ticker
        { get; set; }

        private MainWindow mainWindow
        { get; set; }

        public Microunde(MainWindow window)
        {
            mainWindow = window;
            StareUsa = Enums.StareUsa.Inchisa;
            StareMicrounde = Enums.StareMicrounde.Oprit;
            Ticker = 0;
        }

        public void InchideUsa()
        {
            StareUsa = Enums.StareUsa.Inchisa;
            mainWindow.Set_usa_inchisa();
        }

        public void DeschideUsa()
        {
            StareUsa = Enums.StareUsa.Deschisa;
            if (StareMicrounde == Enums.StareMicrounde.Pornit)
            {
                StareMicrounde = Enums.StareMicrounde.Oprit;
                mainWindow.Set_gateste_OFF();
            }
            mainWindow.Set_usa_deschisa();
        }

        public void Pornit()
        {
            if (StareUsa == Enums.StareUsa.Inchisa)
            {
                StareMicrounde = Enums.StareMicrounde.Pornit;
                mainWindow.Set_gateste_ON();
                Ticker = Ticker + 30;
            }
        }

        public void Ticks()
        {
            if (Ticker > 0 && StareMicrounde == Enums.StareMicrounde.Pornit)
            {
                Ticker--;
                mainWindow.Set_timp_ramas(Ticker);
            }
        }


        //private async void tick_timer()
        //{
        //    timer_on = true;
        //    timer = timer_start;
        //    for (int i = timer; i >= 0; i--)
        //    {
        //        if (i == 0) timer_over = true;
        //        else
        //        {
        //            timer = i;
        //            Timer.Text = timer.ToString();
        //            Stare.Text = "TIMER MERGE HUAAA";
        //            await (Task.Delay(1000));
        //        }
        //    }
        //    if (timer_over == true)
        //    {
        //        timer = 0;
        //        timer_over = false;
        //    }
        //}

    }
}
