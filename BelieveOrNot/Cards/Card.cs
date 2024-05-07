using BelieveOrNot.Cards.ICards;
namespace BelieveOrNot.Cards
{
	public class Card : ICard
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public string Suit {  get; set; }

        public Card(string value, string suit)
        {
            Value = value;
            Suit = suit;
        }
    }
}
