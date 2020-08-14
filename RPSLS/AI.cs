using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RPSLS
{
    public class AI : Player
    {
        //member variables(HAS A)
        public string computerPlayer;
        public Random rand;
        //constructor(SPAWNER)
        public AI()
        {

        }
        //memeber methods(CAN DO)
        public override void ChooseGesture()
        {
            int number = rand.Next(5);
            gestureChoice = choice[number];
        }
    }
}
