using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory
{
    class HumanPlayer : Player
    {
        public HumanPlayer(string _name)
        {
            Name = _name;
            Points = 0;
            Winnings = 0;
            CurrentlyPlaying = false;
        }
    }
}
