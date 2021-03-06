namespace RockPaperScissors.Core
{
    public class Match
    {
        private readonly Player _player1;

        private readonly Player _player2;

        public Match(
            Player player1,
            Player player2
        )
        {
            _player1 = player1;
            _player2 = player2;
        }
        
        public GameResult DecideWinner()
        {
            if (_player1.SelectedOption == _player2.SelectedOption) return GameResult.Tie;
            
            if (_player1.SelectedOption == GameOption.Rock && _player2.SelectedOption == GameOption.Scissors) return GameResult.Win;
            if (_player1.SelectedOption == GameOption.Paper && _player2.SelectedOption == GameOption.Rock) return GameResult.Win;
            if (_player1.SelectedOption == GameOption.Scissors && _player2.SelectedOption == GameOption.Paper) return GameResult.Win;

            
            return GameResult.Lost;
        }
    }
}