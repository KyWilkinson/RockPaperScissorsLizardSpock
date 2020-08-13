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
            if(player2 = Human)
            {
                while(player1.score <3 && player2.score < 3)
                player1.ChooseGesture();
                player2.ChooseGesture();

            }
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
            Console.WriteLine("Do you want a 1 player game or 2 player game? Type 1 or 2");
            string response = Console.ReadLine();
            if(response == "1" )
            {
                player2 = new AI();
            }
            else if(response == "2")
            {
                player2 = new Human();
            }
            else
            {
                DetermineOpponent();
            }
            Console.WriteLine("Let the game begin!");
        }
        public void CompareGestures()
        {

        }
        public void WinnerOfRound()
        {

        }
        public void DisplayWinner()
        {
            if (player1.score == 2)
            {
                Console.WriteLine("Player 1 Wins.");
                Console.WriteLine("--------------------------------");
            }
            else if(player2.score == 2)
            {
                Console.WriteLine("Player 2 Wins.");
                Console.WriteLine("--------------------------------");
            }

        }
    }
}
