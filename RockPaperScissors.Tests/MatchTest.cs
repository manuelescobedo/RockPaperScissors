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
            var match = new Match(
                new Player("P1", GameOption.Rock), new Player("CPU", GameOption.Scissors)
            );

            var gameResult = match.DecideWinner();

            Assert.Equal(gameResult, GameResult.Win);
        }
        [Fact]
        public void When_UserPicksRock_Should_LostPaper()
        {
            var match = new Match(
                new Player("P1", GameOption.Rock), new Player("CPU", GameOption.Paper)
            );

            var gameResult = match.DecideWinner();

            Assert.Equal(gameResult, GameResult.Lost);
        }
        [Fact]
        public void When_UserPicksPaper_Should_WinRock()
        {
            var match = new Match(
                new Player("P1", GameOption.Paper), new Player("CPU", GameOption.Rock)
            );

            var gameResult = match.DecideWinner();

            Assert.Equal(gameResult, GameResult.Win);
        }
        [Fact]
        public void When_UserPicksPaper_Should_LostScissors()
        {
            var match = new Match(
                new Player("P1", GameOption.Paper), new Player("CPU", GameOption.Scissors)
            );

            var gameResult = match.DecideWinner();

            Assert.Equal(gameResult, GameResult.Lost);
        }
        [Fact]
        public void When_UserPicksScissors_Should_WinPaper()
        {
            var match = new Match(
                new Player("P1", GameOption.Scissors), new Player("CPU", GameOption.Paper)
            );

            var gameResult = match.DecideWinner();

            Assert.Equal(gameResult, GameResult.Win);
        }
        [Fact]
        public void When_UserPicksScissors_Should_LostRock()
        {
            var match = new Match(
                new Player("P1", GameOption.Scissors), new Player("CPU", GameOption.Rock)
            );

            var gameResult = match.DecideWinner();

            Assert.Equal(gameResult, GameResult.Lost);
        }
        [Theory]
        [InlineData(GameOption.Paper, GameOption.Paper)]
        [InlineData(GameOption.Rock, GameOption.Rock)]
        [InlineData(GameOption.Scissors, GameOption.Scissors)]
        public void When_UserPicksSameAsCPU_Should_Tie(GameOption p1, GameOption p2)
        {
            var match = new Match(
                new Player("P1", p1), new Player("CPU", p2)
            );

            var gameResult = match.DecideWinner();

            Assert.Equal(gameResult, GameResult.Tie);
        }
    }
}
