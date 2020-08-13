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
        public Player player1;
        public Player player2;
        //constructor(SPAWNER)
        public Game()
        {
            random = new Random();
            player1 = new Human();
        }
        //memeber methods(CAN DO)
        public void RunGame()
        {
            Welcome();
            DisplayRules();
            DetermineOpponent();
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
            string response = Console.ReadLine();
            if(response == "1" )
            {
                player2 = new Human();
            }
            else
            {
                player2 = new AI();
            }
            Console.WriteLine("Let the game begin!");
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
