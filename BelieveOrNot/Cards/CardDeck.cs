using BelieveOrNot.Cards.ICards;

namespace BelieveOrNot.Cards
{
	public class CardDeck : ICardDeck
	{
		public List<ICard> Deck { get; set; }

		public void AddCard(ICard card)
		{
			Deck.Add(card);
		}
		public void PassCards(ICardDeck target, ICardDeck cardToPass)
		{
			foreach(var card in cardToPass.Deck)
			{
				Deck.Remove(card);
				target.AddCard(card);
			}
		}
	}
}
