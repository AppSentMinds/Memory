using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory
{
    class ComputerPlayer : Player
    {
        public string name;
        public int difficulty;
        public bool currentlyPlaying = false;
        public int winnings;

        public ComputerPlayer(string _name, int _difficulty)
        {
            Name = _name;
            this.difficulty = _difficulty;
        }

    }
}
