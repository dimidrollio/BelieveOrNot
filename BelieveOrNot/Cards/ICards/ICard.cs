namespace BelieveOrNot.Cards.ICards
{
	public interface ICard
	{
		public int Id { get; set; }
		public string Value { get; set; }
		public string Suit {  get; set; }
	}
}
