using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public abstract class Player
    {
        //member variables(HAS A)
        public int score;
        public List<string> choice;
        //constructor(SPAWNER)
        public Player()
        {
            score = 0;
            choice = new List<string>("Rock Paper Scissors Lizard Spock");
        }
        //memeber methods(CAN DO)
        public abstract void ChooseGesture()
        {

        }

    }
}
