using System;
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

namespace RockPaperScissors
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private game Game;
  
        public MainWindow()
        {
            InitializeComponent();
            Game = new game(10);
            Game.FightFinished += Game_FightFinished;
            
        }

        private void Game_FightFinished()
        {
            player1.Text = Game.Player1.Money.ToString();
            player2.Text = Game.Player2.Money.ToString();
            player1Mon.Text = Game.Player1.GetHod().ToString();
            player2Mon.Text = Game.Player2.GetHod().ToString();

            if (Game.Player1.Money == 0)
            {
                player1.Text = "prohral";
                Game.stop();
            }else if (Game.Player2.Money == 0)
            {
                player2.Text = "prohral";
                Game.stop();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Game.start();
            if (Game.Player1.Money == 0  || Game.Player2.Money == 0)
            {
                MainWindow m = new MainWindow();
                m.Show();
                Close();
                
            }
            
        }
    }
}
