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

        public Random random;
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
            while (player1.score < 3 && player2.score < 3)
            {

                player1.ChooseGesture();
                player2.ChooseGesture();
                CompareGestures();

            }
            DisplayWinner();

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
            if (response == "1")
            {
                player2 = new AI();
            }
            else if (response == "2")
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
            if (player1.gestureChoice == "Rock" && player2.gestureChoice == "Scissors")
            {
                Console.WriteLine("Player 1 wins the round!");
                Console.WriteLine("------------------------");
                player1.score++;
            }
            else if (player1.gestureChoice == "Rock" && player2.gestureChoice == "Lizard")
            {
                Console.WriteLine("Player 1 wins the round!");
                Console.WriteLine("------------------------");
                player1.score++;
            }
            else if (player1.gestureChoice == "Scissors" && player2.gestureChoice == "Paper")
            {
                Console.WriteLine("Player 1 wins the round!");
                Console.WriteLine("------------------------");
                player1.score++;
            }
            else if (player1.gestureChoice == "Scissors" && player2.gestureChoice == "Lizard")
            {
                Console.WriteLine("Player 1 wins the round!");
                Console.WriteLine("------------------------");
                player1.score++;
            }
            else if (player1.gestureChoice == "Paper" && player2.gestureChoice == "Rock")
            {
                Console.WriteLine("Player 1 wins the round!");
                Console.WriteLine("------------------------");
                player1.score++;
            }
            else if (player1.gestureChoice == "Paper" && player2.gestureChoice == "Spock")
            {
                Console.WriteLine("Player 1 wins the round!");
                Console.WriteLine("------------------------");
                player1.score++;
            }
            else if (player1.gestureChoice == "Lizard" && player2.gestureChoice == "Paper")
            {
                Console.WriteLine("Player 1 wins the round!");
                Console.WriteLine("------------------------");
                player1.score++;
            }
            else if (player1.gestureChoice == "Lizard" && player2.gestureChoice == "Spock")
            {
                Console.WriteLine("Player 1 wins the round!");
                Console.WriteLine("------------------------");
                player1.score++;
            }
            else if (player1.gestureChoice == "Spock" && player2.gestureChoice == "Scissors")
            {
                Console.WriteLine("Player 1 wins the round!");
                Console.WriteLine("------------------------");
                player1.score++;
            }
            else if (player1.gestureChoice == "Spock" && player2.gestureChoice == "Rock")
            {
                Console.WriteLine("Player 1 wins the round!");
                Console.WriteLine("------------------------");
                player1.score++;
            }
            else if (player2.gestureChoice == "Rock" && player1.gestureChoice == "Scissors")
            {
                Console.WriteLine("Player 2 wins the round!");
                Console.WriteLine("------------------------");
                player2.score++;
            }
            else if (player2.gestureChoice == "Rock" && player1.gestureChoice == "Lizard")
            {
                Console.WriteLine("Player 2 wins the round!");
                Console.WriteLine("------------------------");
                player2.score++;
            }
            else if (player2.gestureChoice == "Scissors" && player1.gestureChoice == "Paper")
            {
                Console.WriteLine("Player 2 wins the round!");
                Console.WriteLine("------------------------");
                player2.score++;
            }
            else if (player2.gestureChoice == "Scissors" && player1.gestureChoice == "Lizard")
            {
                Console.WriteLine("Player 2 wins the round!");
                Console.WriteLine("------------------------");
                player2.score++;
            }
            else if (player2.gestureChoice == "Paper" && player1.gestureChoice == "Rock")
            {
                Console.WriteLine("Player 2 wins the round!");
                Console.WriteLine("------------------------");
                player2.score++;
            }
            else if (player2.gestureChoice == "Paper" && player1.gestureChoice == "Spock")
            {
                Console.WriteLine("Player 2 wins the round!");
                Console.WriteLine("------------------------");
                player2.score++;
            }
            else if (player2.gestureChoice == "Lizard" && player1.gestureChoice == "Paper")
            {
                Console.WriteLine("Player 2 wins the round!");
                Console.WriteLine("------------------------");
                player2.score++;
            }
            else if (player2.gestureChoice == "Lizard" && player1.gestureChoice == "Spock")
            {
                Console.WriteLine("Player 2 wins the round!");
                Console.WriteLine("------------------------");
                player2.score++;
            }
            else if (player2.gestureChoice == "Spock" && player1.gestureChoice == "Scissors")
            {
                Console.WriteLine("Player 2 wins the round!");
                Console.WriteLine("------------------------");
                player2.score++;
            }
            else if (player2.gestureChoice == "Spock" && player1.gestureChoice == "Rock")
            {
                Console.WriteLine("Player 1 wins the round!");
                Console.WriteLine("------------------------");
                player2.score++;
            }
            else
            {
                Console.WriteLine("The Round is a draw!");
                Console.WriteLine("--------------------");
            }

        }
        public void DisplayWinner()
        {
            if (player1.score == 2)
            {
                Console.WriteLine("Player 1 Wins.");
                Console.WriteLine("--------------------------------");
            }
            else if (player2.score == 2)
            {
                Console.WriteLine("Player 2 Wins.");
                Console.WriteLine("--------------------------------");
            }
        }
    }
}
