using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory
{
    class computerPlayer : Player
    {
        int difficulty;
        public computerPlayer(string _name, int _difficulty)
        {
            winnings = 0;
            points = 0;
            name = _name;
            difficulty = _difficulty;
            currentlyPlaying = false;
        }
        
    }
}
