using BelieveOrNot.Models.IModels;

namespace BelieveOrNot.Models
{
	public class Card : ICard
	{
		public required string Value { get; set; }
		public required string Suit {  get; set; }
	}
}
