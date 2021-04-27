using System;
using System.Collections.Generic;
using RockPaperScissors.Core;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            MatchService matchService = new MatchService();


            var p1SelectedOption = GetRandomOption();
            var cpuSelectedOption = GetRandomOption();

            var result = matchService.DecideWinner(p1SelectedOption, cpuSelectedOption);



            if (result != GameResult.Tie)
            {
                PrintGameWinner(result);
            }

        }

        static void PrintGameWinner(GameResult result)
        {
            string winner = result == GameResult.Win ? "P1" : "CPU";
            Console.WriteLine($"Winner is: {winner}");
        }


        static GameOption GetRandomOption()
        {
            var random = new Random();
            return (GameOption)random.Next(1, 4);

        }


    }
}
