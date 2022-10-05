namespace GameHub.Models.Watten
{
    public class Deck
    {
        public List<Card> Cards { get; set; }

        public Deck()
        {
            Cards = new List<Card>();
            Cards.Add(new Card() { Name = "herz7", Identifier = "", Image = "Data/Cards/row-1-column-1.jpg", Tooltip="Herz 7", points= 7 });
            Cards.Add(new Card() { Name = "herz8", Identifier = "", Image = "Data/Cards/row-1-column-2.jpg", Tooltip = "Herz 8", points = 8 });
            Cards.Add(new Card() { Name = "herz9", Identifier = "", Image = "Data/Cards/row-1-column-3.jpg", Tooltip = "Herz 9", points = 9 });
            Cards.Add(new Card() { Name = "herz10", Identifier = "", Image = "Data/Cards/row-1-column-4.jpg", Tooltip = "Herz 10", points = 10 });
            Cards.Add(new Card() { Name = "herz11", Identifier = "", Image = "Data/Cards/row-1-column-5.jpg", Tooltip = "Herz Unter", points = 11 });
            Cards.Add(new Card() { Name = "herz12", Identifier = "", Image = "Data/Cards/row-1-column-6.jpg", Tooltip = "Herz Ober", points = 12 });
            Cards.Add(new Card() { Name = "Max", Identifier = "", Image = "Data/Cards/row-1-column-7.jpg", Tooltip = "Max", points = 1500 });
            Cards.Add(new Card() { Name = "herz14", Identifier = "", Image = "Data/Cards/row-1-column-8.jpg", Tooltip = "Herz Sau", points = 14 });
            Cards.Add(new Card() { Name = "Welle", Identifier = "", Image = "Data/Cards/row-2-column-1.jpg", Tooltip = "Welle", points = 1400 });
            Cards.Add(new Card() { Name = "schellen8", Identifier = "", Image = "Data/Cards/row-2-column-2.jpg", Tooltip = "Schellen 8", points = 8 });
            Cards.Add(new Card() { Name = "schellen9", Identifier = "", Image = "Data/Cards/row-2-column-3.jpg", Tooltip = "Schellen 9", points = 9 });
            Cards.Add(new Card() { Name = "schellen10", Identifier = "", Image = "Data/Cards/row-2-column-4.jpg", Tooltip = "Schellen 10", points = 10 });
            Cards.Add(new Card() { Name = "schellen11", Identifier = "", Image = "Data/Cards/row-2-column-5.jpg", Tooltip = "Schellen Unter", points = 11 });
            Cards.Add(new Card() { Name = "schellen12", Identifier = "", Image = "Data/Cards/row-2-column-6.jpg", Tooltip = "Schellen Ober", points = 12 });
            Cards.Add(new Card() { Name = "schellen13", Identifier = "", Image = "Data/Cards/row-2-column-7.jpg", Tooltip = "Schellen Koenig", points = 13 });
            Cards.Add(new Card() { Name = "schellen14" , Identifier = "", Image = "Data/Cards/row-1-column-8.jpg", Tooltip = "Schellen Sau", points = 14 });
            Cards.Add(new Card() { Name = "gras7", Identifier = "", Image = "Data/Cards/row-3-column-1.jpg", Tooltip = "Gras 7", points = 7 });
            Cards.Add(new Card() { Name = "gras8", Identifier = "", Image = "Data/Cards/row-3-column-2.jpg", Tooltip = "Gras 8", points = 8 });
            Cards.Add(new Card() { Name = "gras9", Identifier = "", Image = "Data/Cards/row-3-column-3.jpg", Tooltip = "Gras 9", points = 9 });
            Cards.Add(new Card() { Name = "gras10", Identifier = "", Image = "Data/Cards/row-3-column-4.jpg", Tooltip = "Gras 10", points = 10 });
            Cards.Add(new Card() { Name = "gras11", Identifier = "", Image = "Data/Cards/row-3-column-5.jpg", Tooltip = "Gras Unter", points = 11 });
            Cards.Add(new Card() { Name = "gras12", Identifier = "", Image = "Data/Cards/row-3-column-6.jpg", Tooltip = "Gras Ober", points = 12 });
            Cards.Add(new Card() { Name = "gras13", Identifier = "", Image = "Data/Cards/row-3-column-7.jpg", Tooltip = "Gras Koenig", points = 13 });
            Cards.Add(new Card() { Name = "gras14", Identifier = "", Image = "Data/Cards/row-3-column-8.jpg", Tooltip = "Gras Sau", points = 14 });
            Cards.Add(new Card() { Name = "Spitze", Identifier = "", Image = "Data/Cards/row-4-column-1.jpg", Tooltip = "Spitze", points = 1300 });
            Cards.Add(new Card() { Name = "eichel8", Identifier = "", Image = "Data/Cards/row-4-column-2.jpg", Tooltip = "Eichel 8", points = 8 });
            Cards.Add(new Card() { Name = "eichel9", Identifier = "", Image = "Data/Cards/row-4-column-3.jpg", Tooltip = "Eichel 9", points = 9 });
            Cards.Add(new Card() { Name = "eichel10", Identifier = "", Image = "Data/Cards/row-4-column-4.jpg", Tooltip = "Eichel 10", points = 10 });
            Cards.Add(new Card() { Name = "eichel11", Identifier = "", Image = "Data/Cards/row-4-column-5.jpg", Tooltip = "Eichel Unter", points = 11 });
            Cards.Add(new Card() { Name = "eichel12", Identifier = "", Image = "Data/Cards/row-4-column-6.jpg", Tooltip = "Eichel Ober", points = 12 });
            Cards.Add(new Card() { Name = "eichel13", Identifier = "", Image = "Data/Cards/row-4-column-7.jpg", Tooltip = "Eichel Koenig", points = 13 });
            Cards.Add(new Card() { Name = "eichel14", Identifier = "", Image = "Data/Cards/row-4-column-8.jpg", Tooltip = "Eichel Sau", points = 14 });
        }
    }
}
