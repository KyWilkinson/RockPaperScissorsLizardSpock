using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Human : Player
    {
        //member variables(HAS A)
        


        //constructor(SPAWNER)
        public Human()
        {

        }
        //memeber methods(CAN DO)
        public override void ChooseGesture()
        {
            DisplayChoice();
            gestureChoice = Console.ReadLine();

        }
        public void DisplayChoice()
        {
            foreach (string choice in choice)
            {
                Console.WriteLine("Select your choice: " + choice);
            }
        }
    }
}
