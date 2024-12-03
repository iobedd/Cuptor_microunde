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

namespace Cuptor_microunde
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        string inactiv = "inactiv";
        string activ = "activ";
        bool timer_on = true;
        bool timer_off = false;
        string stare_activ;
        bool stare_timer;
        int timer_start = 30;
        bool timer_over= false;
        int timer;

        private void Click_deschide(object sender, RoutedEventArgs e)
        {
            stare_activ = inactiv;
            stare_timer = timer_off;
        }

        private void Click_inchide(object sender, RoutedEventArgs e)
        {
            stare_activ = inactiv;
            stare_timer = timer_off;
        }

        private void Click_start(object sender, RoutedEventArgs e)
        {
            stare_activ = inactiv;
            stare_timer = timer_off;
            tick_timer();
        }

        private async void tick_timer()
        {
            timer_on = true;
            timer = timer_start;
            for(int i = timer; i >= 0; i--)
            {
                if (i == 0) timer_over= true;
                else
                {
                    timer = i;
                    Timer.Text = timer.ToString();
                    Stare.Text = "TIMER MERGE HUAAA";
                    await (Task.Delay(1000));
                }
            }
            if(timer_over == true)
            {
                timer = 0;
                timer_over = false;
            }
        }
    }
}
