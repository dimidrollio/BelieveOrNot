using BelieveOrNot.Models.IModels;

namespace BelieveOrNot.Logic
{
	public class CardCollection
	{
		public List<ICard> Deck { get; set; }

		public bool PassCards(List<ICard> target, ICard cardToAdd)
		{
			if (!Deck.Remove(cardToAdd))
			{
				return false;
			}
			target.Add(cardToAdd);
			return true;
		}
		public bool PassCards(List<ICard> target, List<ICard> cardsToAdd)
		{
			foreach(var card in cardsToAdd) 
			{
				if (Deck.FirstOrDefault(c => c == card) == null)
				{
					return false;
				}
			}
			target.AddRange(cardsToAdd);
			return true;
		}
		public CardCollection(List<ICard> deck) 
		{
			Deck = deck;
		}
        public CardCollection()
        {
			Deck = [];
        }
    }
}
