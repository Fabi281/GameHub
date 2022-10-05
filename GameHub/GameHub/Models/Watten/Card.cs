namespace GameHub.Models.Watten
{
    public class Card
    {
        public string Name { get; set; }
        public string Identifier { get; set; }
        public string Image { get; set; }

        public string Tooltip { get; set; } = "Opponents Card";

        public int points { get; set; }
    }
}
