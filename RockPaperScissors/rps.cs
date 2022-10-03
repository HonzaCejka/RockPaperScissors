using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors
{
    public class rps
    {
        Random rnd = new Random();
        public string hodPick { get; set; }
        public int pick { get; set; }
        public int money { get; internal set; }

        public rps()
        {
            money = 10;   
            
        }

        public void hod()
        {
            
            
            pick = rnd.Next(0,3);

            switch (pick)
            {
                case 0:
                    hodPick = "rock";
                    break;
                case 1:
                    hodPick = "paper";
                    break;
                case 2:
                    hodPick = "scissors";
                    break;
                default:
                    hodPick = "no tohle nevyjde";
                    break;
            }    
        }
        public void win()
        {
            money++;
        }
        public void losse()
        {
            money--;
        }
    }
}
