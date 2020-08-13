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
        int playerOneScore;
        int playerTwoScore;
        Random random;
        AI computer;
        Human human;
        //constructor(SPAWNER)
        public Game()
        {
            playerOneScore = 0;
            playerTwoScore = 0;
            random = new Random();
        }
        //memeber methods(CAN DO)
        public void RunGame()
        {
            Welcome();
        }
        public void Welcome()
        {
            Console.WriteLine("Welcome to Rock Paper Scissors Lizard Spock");
            Console.WriteLine("--------------------------------------------");
        }
        public void DisplayRules()
        {
            Console.WriteLine("Would you like to play a game?");

        }
        public void ChooseOpponent()
        {

        }
    }
}
