using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;
using System.Threading;
using System.Windows.Threading;

namespace RockPaperScissors
{
    public class game
    {
        
        public DispatcherTimer timer;
        public player Player1 { get; }
        public player Player2 { get; }

        public event Action FightFinished;

        public game(int money)
        {
            Player1 = new player(money);
            Player2 = new player(money);
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 0, 0, 10);
            timer.Tick += generate;
        }
        public void generate(object sender, EventArgs e)
        {
            var player1 = Player1.GetHod();
            Thread.Sleep(145);
            var player2 = Player2.GetHod();

            if (player1 != player2)
            {
                if (player1 == player.hod.Rock)
                {
                    if (player2 == player.hod.Scissors)
                    {
                        Player2.losse();
                        Player1.win();
                    }
                    else
                    {
                        Player1.losse();
                        Player2.win();
                    }
                }
                else if (player1 == player.hod.Scissors)
                {
                    if (player2 == player.hod.Rock)
                    {
                        Player1.losse();
                        Player2.win();                        
                    }
                    else
                    {
                        Player2.losse();
                        Player1.win();
                    }
                }
                else
                {
                    if (player2 == player.hod.Scissors)
                    {
                        Player1.losse();
                        Player2.win();
                    }
                    else
                    {
                        Player2.losse();
                        Player1.win();
                    }
                }
            }
            FightFinished?.Invoke();
        }
        public void start()
        {
            
            timer.Start();
            

        }
        public void stop()
        {
            timer.Stop();
        }

    }
}
