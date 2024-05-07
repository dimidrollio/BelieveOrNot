using BelieveOrNot.Cards;
using BelieveOrNot.Cards.ICards;
using BelieveOrNot.Players.IPlayers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelieveOrNot.Game
{
	public class Round
	{
		protected IPlayer _thisPlayer;
		protected IPlayer _nextPlayer;
		private int _movesInRound;
		public List<IPlayer> PlayerPool { get; set; }
		public ICardDeck CardPool { get; set; }
		public ICardDeck CardsToCheck { get; set; }
		public string SaidCardValue { get; set; }
        public Round(IPlayer thisPlayer, IPlayer nextPlayer, List<IPlayer> playerPool)
        {
            _thisPlayer = thisPlayer;
			_nextPlayer = nextPlayer;
			_movesInRound = 0;
			PlayerPool = playerPool;
        }
		public void Start()
		{

		}
		public void MoreCards(List<int> cardIndexes)
		{
			var cardsToPass = new CardDeck();

			foreach (var cardIndex in cardIndexes)
			{
				var cardToAdd = _thisPlayer.CardDeck.Deck[cardIndex];
				cardsToPass.AddCard(cardToAdd);
				_thisPlayer.CardDeck.Deck.Remove(cardToAdd);
			}
			_thisPlayer.CardDeck.PassCards(CardPool, cardsToPass);
			CardsToCheck = cardsToPass;
		}

		public void DontBelieve()
		{
			foreach(var card in CardsToCheck.Deck)
			{
				if(card.Value != SaidCardValue)
				{
					break
				}
			}
		}
    }
}
