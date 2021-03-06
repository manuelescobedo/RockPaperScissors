using System;
using System.Collections.Generic;

namespace RockPaperScissors.Core
{
    public class Game
    {
        private bool _isOver;
        public bool IsOver { get { return _isOver; } }
        
        public readonly int MaxVictories;
        
        private readonly IMatchService _matchService;

        public Game(IMatchService matchService, int maxVictories = 3)
        {
            _isOver = true;
            MaxVictories = maxVictories;
            _matchService = matchService;

        }

        public void Over()
        {
            _isOver = true;
        }

        public void Resume()
        {
            _isOver = false;
            _matchService.Clear();
        }

        public void Match(Player p1, Player p2)
        {
            _matchService.Add(new Match(p1, p2));
        }

        public GameResult DecideWinner()
        {
            int p1Wins = _matchService.GetWins(), p2Wins = _matchService.GetLosts();

            if (p1Wins == MaxVictories) return GameResult.Win;
            if (p2Wins == MaxVictories) return GameResult.Lost;

            return GameResult.Tie;
        }

    }
}