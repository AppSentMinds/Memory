using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory
{
    public class Player //???? PUBLIC ????
    {
        private string name;
        private int points;
        private  bool currentlyPlaying = false;
        private int winnings;
       
        public Player()
        {  
         
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Points
        {
            get { return points; }
            set { points = value; }
        }

        public bool CurrentlyPlaying
        {
            get { return currentlyPlaying; }
            set { currentlyPlaying = value; }
        }

        public int Winnings
        {
            get { return winnings; }
            set { winnings = value; }
        }
    }
}
