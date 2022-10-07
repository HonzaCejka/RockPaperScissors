using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors
{
    public class player
    {
        private Random rand = new Random();
        public int Money { get; set; }

        public player(int money)
        {
            Money = money;
        }

        public hod GetHod()
        {
            int value = rand.Next(0, 3);
            return (hod)value;
        }

        public void win()
        {
            Money++;
        }
        public void losse()
        {
            Money--;
        }

        public enum hod
        {
            Rock,
            Paper,
            Scissors
        }
    }
}
