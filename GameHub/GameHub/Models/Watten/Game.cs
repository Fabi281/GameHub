namespace GameHub.Models.Watten
{
    public class Game
    {
        public Dictionary<string, Player> playerDict { get; set; } = new Dictionary<string, Player>();
        public Deck deck { get; set; } = new Deck();
        public Dictionary<string, Card> playedCards { get; set; } = new Dictionary<string, Card>();
        public string farbe { get; set; }
        public string stich { get; set; }   
    }
}
