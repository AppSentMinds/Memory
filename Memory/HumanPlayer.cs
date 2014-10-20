using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory
{
    public class HumanPlayer : Player
    {
        public HumanPlayer(string _name)
        {  
            this.Name = _name;
            Points = 0;
            Winnings = 0;
        }

      
    }
}

