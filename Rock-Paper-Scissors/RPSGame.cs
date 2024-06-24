using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    public class RPSGame
    {
        private Player player;
        private Player ai;
        private Random random;

        public RPSGame()
        {
            player = new Player("Player");
            ai = new Player("AI");
            random = new Random();
        }

        public void StartGame()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors Game!");
            int round = 0;

            while (player.Score < 3 && ai.Score < 3)
            {
                Console.WriteLine($"\nRound {++round}:");

                string playerMove = player.ChooseMove();
                string aiMove = GetAIMove();

                Console.WriteLine($"AI chose {aiMove}");
                DetermineWinner(playerMove, aiMove);

                Console.WriteLine($"\nScores: {player.Name} - {player.Score}, {ai.Name} - {ai.Score}");
            }

            if (player.Score == 3)
            {
                Console.WriteLine("\nCongratulations! You won the game.");
            }
            else
            {
                Console.WriteLine("\nAI wins the game. Better luck next time!");
            }
        }

        private string GetAIMove()
        {
            string[] moves = { "rock", "paper", "scissors" };
            return moves[random.Next(moves.Length)];
        }

        private void DetermineWinner(string playerMove, string aiMove)
        {
            if (playerMove == aiMove)
            {
                Console.WriteLine("It's a tie!");
            }
            else if ((playerMove == "rock" && aiMove == "scissors") ||
                     (playerMove == "paper" && aiMove == "rock") ||
                     (playerMove == "scissors" && aiMove == "paper"))
            {
                Console.WriteLine($"{player.Name} wins this round!");
                player.Score++;
            }
            else
            {
                Console.WriteLine($"{ai.Name} wins this round!");
                ai.Score++;
            }
        }

        // For unit testing
        public string TestDetermineWinner(string playerMove, string aiMove)
        {
            if (playerMove == aiMove) return "Tie";
            if ((playerMove == "rock" && aiMove == "scissors") ||
                (playerMove == "paper" && aiMove == "rock") ||
                (playerMove == "scissors" && aiMove == "paper")) return "Player";
            return "AI";
        }

        public void TestUpdateScore(Player player, Player ai, string winner)
        {
            if (winner == "Player") player.Score++;
            else if (winner == "AI") ai.Score++;
        }
    }
}

