using Xunit;
using Rock_Paper_Scissors; // Adjusted namespace to match your project

namespace RPSGameTests
{
    public class RPSGameTests
    {
        [Fact]
        public void Test_PlayerWinsWithRock()
        {
            // Arrange
            var game = new RPSGame();
            string playerMove = "rock";
            string aiMove = "scissors";

            // Act
            string winner = game.TestDetermineWinner(playerMove, aiMove);

            // Assert
            Assert.Equal("Player", winner);
        }

        [Fact]
        public void Test_AIWinsWithPaper()
        {
            // Arrange
            var game = new RPSGame();
            string playerMove = "rock";
            string aiMove = "paper";

            // Act
            string winner = game.TestDetermineWinner(playerMove, aiMove);

            // Assert
            Assert.Equal("AI", winner);
        }

        [Fact]
        public void Test_Tie()
        {
            // Arrange
            var game = new RPSGame();
            string playerMove = "paper";
            string aiMove = "paper";

            // Act
            string winner = game.TestDetermineWinner(playerMove, aiMove);

            // Assert
            Assert.Equal("Tie", winner);
        }

        [Fact]
        public void Test_PlayerScoreIncrement()
        {
            // Arrange
            var game = new RPSGame();
            var player = new Player("Player");
            var ai = new Player("AI");
            string winner = "Player";

            // Act
            game.TestUpdateScore(player, ai, winner);

            // Assert
            Assert.Equal(1, player.Score);
        }

        [Fact]
        public void Test_AIScoreIncrement()
        {
            // Arrange
            var game = new RPSGame();
            var player = new Player("Player");
            var ai = new Player("AI");
            string winner = "AI";

            // Act
            game.TestUpdateScore(player, ai, winner);

            // Assert
            Assert.Equal(1, ai.Score);
        }
        //
    }
}
