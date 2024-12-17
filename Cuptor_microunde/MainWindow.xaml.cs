using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using static Cuptor_microunde.Enums;

namespace Cuptor_microunde
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Microunde microunde;
        public MainWindow()
        {
            microunde = new Microunde(this);
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
        }

        //string inactiv = "inactiv";
        //string activ = "activ";
        //bool timer_on = true;
        //bool timer_off = false;
        //string stare_activ;
        //bool stare_timer;
        //int timer_start = 30;
        //bool timer_over= false;
        //int timer;

        //private void Click_deschide(object sender, RoutedEventArgs e)
        //{
        //    stare_activ = inactiv;
        //    stare_timer = timer_off;
        //}

        //private void Click_inchide(object sender, RoutedEventArgs e)
        //{
        //    stare_activ = inactiv;
        //    stare_timer = timer_off;
        //}

        //private void Click_start(object sender, RoutedEventArgs e)
        //{
        //    stare_activ = inactiv;
        //    stare_timer = timer_off;
        //    tick_timer();
        //}

        private void InchideUsa(object sender, RoutedEventArgs e)
        {
            microunde.InchideUsa();
        }

        private void DeschideUsa(object sender, RoutedEventArgs e)
        {
            microunde.DeschideUsa();
        }

        private void Pornit(object sender, RoutedEventArgs e)
        {
            microunde.Pornit();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            Ticks();
        }

        public void Set_gateste_OFF()
        {
            StareMicrounde.Text = "Oprit";
        }

        public void Set_gateste_ON()
        {
            StareMicrounde.Text = "Pornit";
        }

        public void Set_timp_ramas(int timp)
        {
            Ticker.Text = timp.ToString();
        }

        public void Set_usa_deschisa()
        {
            StareUsa.Text = "Usa Deschisa";
        }

        public void Set_usa_inchisa()
        {
            StareUsa.Text = "Usa Inchisa";
        }

        public void Ticks()
        {
            microunde.Ticks();
        }

    }
}
