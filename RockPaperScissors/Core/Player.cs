namespace RockPaperScissors.Core
{
    public struct Player
    {
        public readonly string Alias;
        public GameOption SelectedOption { get; set; }
        public Player(string alias, GameOption selectedOption = GameOption.Paper)
        {
            Alias = alias;
            SelectedOption = selectedOption;
        }
    }
}