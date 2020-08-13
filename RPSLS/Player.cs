using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Player
    {
        //member variables(HAS A)
        List<string> choice = new List<string>();
        //constructor(SPAWNER)
        public Player()
        {
            choice.Add("Rock");
            choice.Add("Paper");
            choice.Add("Scissors");
            choice.Add("Lizard");
            choice.Add("Spock");
            
            
        }
        //memeber methods(CAN DO)
        public void DisplayChoices()
        {

        }

    }
}
