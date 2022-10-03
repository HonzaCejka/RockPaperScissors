using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace RockPaperScissors
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        rps Rps1 = new rps();
        rps Rps2 = new rps();

        DispatcherTimer timer = new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();
            timer.Interval = new TimeSpan(0, 0, 0, 1);
            timer.Tick += new EventHandler(generate);
        }

        public void generate(Object sender, EventArgs e)
        {
            Rps1.hod();
            Rps2.hod();
            player1.Text = Rps1.hodPick.ToString(); //nefunguje
            player2.Text = Rps2.hodPick.ToString();
            player1Mon.Text = Rps1.money.ToString();
            player2Mon.Text = Rps2.money.ToString();
            rockpaperscissors();
        }

        public void rockpaperscissors()
        {
            if (Rps1.pick == 1 && Rps2.pick == 1)
            {
                generate(null, null);
            }
            else if (Rps1.pick == 0 && Rps2.pick == 0)
            {
                generate(null, null);
            }
            else if (Rps1.pick == 2 && Rps2.pick == 2)
            {
                generate(null, null);
            }
            else if (Rps1.pick == 0 && Rps2.pick == 1)
            {
                Rps2.win();
                Rps1.losse();
                generate(null, null);
            }
            else if (Rps1.pick == 2 && Rps2.pick == 1)
            {
                Rps1.win();
                Rps2.losse();
                generate(null, null);
            }
            else if (Rps1.pick == 1 && Rps2.pick == 0)
            {
                Rps1.win();
                Rps2.losse();
                generate(null, null);
            }
            else if (Rps1.pick == 2 && Rps2.pick == 0)
            {
                Rps2.win();
                Rps1.losse();
                generate(null, null);
            }
            else if (Rps1.pick == 0 && Rps2.pick == 2)
            {
                Rps1.win();
                Rps2.losse();
                generate(null, null);
            }
            else if (Rps1.pick == 1 && Rps2.pick == 2)
            {
                Rps2.win();
                Rps1.losse();
                generate(null, null);
            }
            else
            {
                generate(null, null);
            }

            if (Rps1.money == 0 )
            {
                player2.Text = "win";
                timer.Stop();

            }
            else if (Rps2.money == 0)
            {
                player1.Text = "win";
                timer.Stop();
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            timer.Start();
        }
    }
}
