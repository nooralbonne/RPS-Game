using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    public class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }

        public Player(string name)
        {
            Name = name;
            Score = 0;
        }//

        public string ChooseMove()
        {
            while (true)
            {
                Console.WriteLine($"{Name}, choose your move (rock, paper, scissors): ");
                string move = Console.ReadLine().ToLower();

                if (move == "rock" || move == "paper" || move == "scissors")
                {
                    return move;
                }

                Console.WriteLine("Invalid move. Please choose again.");
            }
        }
    }
}
