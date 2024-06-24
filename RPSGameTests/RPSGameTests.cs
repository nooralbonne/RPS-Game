using Xunit;
using Rock_Paper_Scissors;

namespace RPSGameTests
{
    public class RPSGameTests
    {
        [Theory]
        [InlineData("rock", "scissors", "Player")]
        [InlineData("scissors", "paper", "Player")]
        [InlineData("paper", "rock", "Player")]
        [InlineData("scissors", "rock", "AI")]
        [InlineData("paper", "scissors", "AI")]
        [InlineData("rock", "paper", "AI")]
        [InlineData("rock", "rock", "Tie")]
        [InlineData("paper", "paper", "Tie")]
        [InlineData("scissors", "scissors", "Tie")]
        public void DetermineWinner_ShouldCorrectlyDetermineWinner(string playerMove, string aiMove, string expectedWinner)
        {
            var game = new RPSGame();
            string winner = game.TestDetermineWinner(playerMove, aiMove);
            Assert.Equal(expectedWinner, winner);
        }
    }
}
