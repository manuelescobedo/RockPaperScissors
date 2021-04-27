using System;
using Xunit;
using RockPaperScissors.Core;

namespace RockPaperScissors.Tests
{
    public class MatchTest
    {
        [Fact]
        public void When_UserPicksRock_Should_WinScissors()
        {
            MatchService match = new MatchService();

            var gameResult = match.DecideWinner(GameOption.Rock, GameOption.Scissors);

            Assert.Equal( GameResult.Win,gameResult);
        }
        [Fact]
        public void When_UserPicksRock_Should_LostPaper()
        {
            MatchService match = new MatchService();

            var gameResult = match.DecideWinner(GameOption.Rock, GameOption.Paper);

            Assert.Equal(GameResult.Lost,gameResult);
        }
        [Fact]
        public void When_UserPicksPaper_Should_WinRock()
        {
            MatchService match = new MatchService();

            var gameResult = match.DecideWinner(GameOption.Paper, GameOption.Rock);

            Assert.Equal(GameResult.Win,gameResult);
        }
        [Fact]
        public void When_UserPicksPaper_Should_LostScissors()
        {
            MatchService match = new MatchService();

            var gameResult = match.DecideWinner(GameOption.Paper, GameOption.Scissors);

            Assert.Equal(GameResult.Lost, gameResult);
        }
        [Fact]
        public void When_UserPicksScissors_Should_WinPaper()
        {
            MatchService match = new MatchService();

            var gameResult = match.DecideWinner(GameOption.Scissors, GameOption.Paper);

            Assert.Equal(GameResult.Win,gameResult);
        }
        [Fact]
        public void When_UserPicksScissors_Should_LostRock()
        {
            MatchService match = new MatchService();

            var gameResult = match.DecideWinner(GameOption.Scissors, GameOption.Rock);

            Assert.Equal( GameResult.Lost, gameResult);
        }
        [Theory]
        [InlineData(GameOption.Paper, GameOption.Paper)]
        [InlineData(GameOption.Rock, GameOption.Rock)]
        [InlineData(GameOption.Scissors, GameOption.Scissors)]
        public void When_UserPicksSameAsCPU_Should_Tie(GameOption p1, GameOption p2)
        {
            MatchService match = new MatchService();

            var gameResult = match.DecideWinner(p1, p2);

            Assert.Equal(GameResult.Tie,gameResult);
        }
    }
}
