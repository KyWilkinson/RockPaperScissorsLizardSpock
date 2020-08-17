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
            if(gestureChoice.ToUpper() == "ROCK" )
            {
                gestureChoice = "Rock";
            }
            else if(gestureChoice.ToUpper() == "SCISSORS")
            {
                gestureChoice = "Scissors";
            }
            else if(gestureChoice.ToUpper() == "PAPER")
            {
                gestureChoice = "Paper";
            }
            else if (gestureChoice.ToUpper() == "LIZARD")
            {
                gestureChoice = "Lizard";
            }
            else if (gestureChoice.ToUpper() == "SPOCK")
            {
                gestureChoice = "Spock";
            }
            else
            {
                ChooseGesture();
            }


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
