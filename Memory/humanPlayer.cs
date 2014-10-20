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
            name = _name;
            points = 0;
            winnings = 0;
            currentlyPlaying = false;
        }
    }
}
