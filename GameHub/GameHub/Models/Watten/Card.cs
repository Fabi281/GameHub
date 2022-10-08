namespace GameHub.Models.Watten
{
    public class Card
    {
        public string Color { get; set; }

        public string Text { get; set; }
        public string Identifier { get; set; }
        public string Image { get; set; }

        public string Tooltip { get; set; } = "Opponents Card";

        public int points { get; set; }
    }
}
