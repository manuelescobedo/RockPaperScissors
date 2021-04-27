using System;
using System.Collections.Generic;
using System.Linq;

namespace RockPaperScissors.Core
{

    public class MatchService
    {
        public GameResult DecideWinner(GameOption player1SelectedOption, GameOption player2SelectedOption)
        {

            if (player1SelectedOption == player2SelectedOption) return GameResult.Tie;

            if (player1SelectedOption == GameOption.Rock && player2SelectedOption == GameOption.Scissors) return GameResult.Win;
            if (player1SelectedOption == GameOption.Paper && player2SelectedOption == GameOption.Rock) return GameResult.Win;
            if (player1SelectedOption == GameOption.Scissors && player2SelectedOption == GameOption.Paper) return GameResult.Win;


            return GameResult.Lost;
        }

    }
}