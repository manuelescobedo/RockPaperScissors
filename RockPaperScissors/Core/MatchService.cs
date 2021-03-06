using System;
using System.Collections.Generic;
using System.Linq;

namespace RockPaperScissors.Core
{
    public interface IMatchService
    {
        void Clear();
        void Add(Match match);

        int GetWins();
        int GetTies();
        int GetLosts();

        List<Match> Matches { get; }
    }
    public class MatchService : IMatchService
    {
        private List<Match> _matches = new List<Match>();
        public List<Match> Matches { get { return _matches; } }

        public void Clear()
        {
            _matches.Clear();
        }

        public void Add(Match match)
        {
            _matches.Add(match);
        }

        public int GetWins()
        {
            return _matches.Count(m => m.DecideWinner() == GameResult.Win);
        }
        public int GetTies()
        {
            return _matches.Count(m => m.DecideWinner() == GameResult.Tie);
        }
        public int GetLosts()
        {
            return _matches.Count(m => m.DecideWinner() == GameResult.Lost);
        }
    }
}