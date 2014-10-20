using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory
{
    class ComputerPlayer : Player
    {
        int Difficulty;
        public ComputerPlayer(string _name, int _difficulty)
        {
            Winnings = 0;
            Points = 0;
            Name = _name;
            Difficulty = _difficulty;
            CurrentlyPlaying = false;
        }
        
    }
}
