using BelieveOrNot.Cards.ICards;
using BelieveOrNot.Players.IPlayers;

namespace BelieveOrNot.Players
{
	public class Player : IPlayer
	{
		public string Name { get; set; }
        public ICardDeck CardDeck { get; set; }

        public Player(string name)
        {
            Name = name;
        }
    }
}
