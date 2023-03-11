namespace TicTacToeApi.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public bool TypeOfTurn { get; set; }
        public int PossitionX { get; set; }
        public int PossitionY { get; set; }
    }
}
