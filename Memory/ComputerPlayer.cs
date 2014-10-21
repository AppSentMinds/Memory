using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory
{
    public class ComputerPlayer : Player   
    {
        public ComputerPlayer(string _name)
        {
            Name = _name;
            Points = 0;
            Winnings = 0;
            Type = "computer";
        }

        //metod för ForgetACard();
        //medod MemorizeACard(); kolla om den redan finns i minnet.
        

        
    }
}
