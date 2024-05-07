using BelieveOrNot.Cards.ICards;

namespace BelieveOrNot.Players.IPlayers
{
    public interface IPlayer
    {
        public string Name { get; set; }
        public ICardDeck CardDeck { get; set; }
    }
}
