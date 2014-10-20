using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory
{
    public class ComputerPlayer : Player   
    {
        int difficulty;
        
        public ComputerPlayer(string _name, int _difficulty)
        {
            Name = _name;
            this.difficulty = _difficulty;
        }
    }
}
