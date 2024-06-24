# Rock-Paper-Scissors

# Rock, Paper, Scissors Game

This is a console application that allows a player to play Rock, Paper, Scissors against an AI opponent.

## How to Run

1. Open the project in your preferred IDE.
2. Run the `Program.cs` file.
3. Follow the prompts to play the game.

## Unit Tests

Unit tests are located in the `RPSGameTests` folder. To run the tests, use the test runner integrated with your IDE or execute the tests via the command line using the Xunit framework.

## Game Rules

- Players choose between "rock", "paper", or "scissors".
- The AI randomly chooses a move.
- The winner is determined based on the following rules:
  - Rock beats Scissors
  - Scissors beats Paper
  - Paper beats Rock
  - If both players choose the same move, it's a tie.
- The game continues until one player reaches a score of 3.
