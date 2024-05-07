using BelieveOrNot.Models.IModels;

namespace BelieveOrNot.Logic
{
	public class CardHand : CardCollection
	{
		public CardHand(List<ICard> deck) : base(deck)
		{
			Deck = deck;
		}
		public int AddCards(ICard cardToAdd)
		{
			Deck.Add(cardToAdd);
			return Deck.Count;
		}
		public int AddCards(IEnumerable<ICard> cardsToAdd)
		{
			Deck.AddRange(cardsToAdd);
			return Deck.Count;
		}
	}
}
