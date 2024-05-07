namespace BelieveOrNot.Cards.ICards
{
	public interface ICardDeck
	{
		public List<ICard> Deck { get; }
		public void AddCard(ICard card);
		public void PassCards(ICardDeck target, ICardDeck cardToPass);
	}
}
