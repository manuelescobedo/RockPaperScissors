using System;
using System.Collections.Generic;
using RockPaperScissors.Core;

namespace RockPaperScissors
{
    class Program
    {        static void Main(string[] args)
        {
            Player p1 = new Player("P1");
            Player cpu = new Player("CPU");
            MatchService matchService = new MatchService();

            Game game = new Game(matchService);
            game.Resume();

            GameResult result = GameResult.Tie;

            while (!game.IsOver) {
                p1.SelectedOption = ReadOption();
                cpu.SelectedOption = GetRandomOption();

                game.Match(p1, cpu);
            
                PrintMatchHistory(matchService.Matches);

                result = game.DecideWinner();
                if (result  != GameResult.Tie)
                {
                    game.Over();
                }
            }

            PrintGameWinner(result);

            Console.Read();
        }

        static void PrintGameWinner(GameResult result) {
            string winner = result == GameResult.Win ? "P1": "CPU";
            Console.WriteLine($"Winner is: {winner}");
        }

        static void PrintMatchHistory(List<Match> matches) {
            Console.WriteLine("\nMatches history:");
            
            int p1Wins = 0, p2Wins = 0;
            foreach(Match m in matches) {
                GameResult result = m.DecideWinner();
                if (result == GameResult.Tie) {
                    Console.WriteLine("Tie");
                } else {
                    string winner = (result==GameResult.Win) ? "P1" : "CPU";
                    if (result == GameResult.Win) p1Wins += 1;
                    if (result == GameResult.Lost) p2Wins += 1;
                    Console.WriteLine($"{winner} won");
                }
            }
            
            Console.WriteLine($"P1: {p1Wins}, P2: {p2Wins}");
        }

        static GameOption GetRandomOption() {
            var random = new Random();
            return (GameOption) random.Next(1, 4);
           
        }

        static GameOption ReadOption() {
           
            Console.WriteLine($"Input an option: (x) Scissors, (o) Rock, (p or default) Paper");
            var input = Console.ReadKey();
            if (input.Key == ConsoleKey.X ) return GameOption.Scissors;
            if (input.Key == ConsoleKey.O ) return GameOption.Rock;
            return GameOption.Paper;

        }

    }
}
