using BelieveOrNot.Models.IModels;

namespace BelieveOrNot.Logic
{
	public class CardDeck : CardCollection
	{
		public CardDeck() : base()
		{
			Deck = [];
		}

		public void FillDeck()
		{
			SD.Card_SD.FillDeck(Deck);
		}
	}
}
