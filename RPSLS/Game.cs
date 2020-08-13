using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Game
    {
        //member variables(HAS A)

        Random random;
        public AI ;
        public Human player1;
        //constructor(SPAWNER)
        public Game()
        {
            player1 = new Human();

            random = new Random();
        }
        //memeber methods(CAN DO)
        public void RunGame()
        {
            Welcome();
            DisplayRules();

        }
        public void Welcome()
        {
            Console.WriteLine("Welcome to Rock Paper Scissors Lizard Spock");
            Console.WriteLine("--------------------------------------------");
            
        }
        public void DisplayRules()
        {
            Console.WriteLine("This is a best of three game");
        }
        public void DetermineOpponent()
        {
            Console.WriteLine("Do you want a 1 player game or 2 player game?");
            string response = Console.ReadLine()
            if (response == "1" )
            {
                player2 = new Human();
            }
            else
            {
                player2 = new AI
            }
        }
        public void CompareChoices()
        {

        }
        public void DisplayChoices()
        {
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("--------------------    (0) Rock      ------------------");
            Console.WriteLine("--------------------     (1) Paper      ----------------");
            Console.WriteLine("--------------------      (2) Scissors      ------------");
            Console.WriteLine("--------------------     (3) Lizard      ---------------");
            Console.WriteLine("--------------------    (4) Spock      -----------------");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------");

        }
    }
}
