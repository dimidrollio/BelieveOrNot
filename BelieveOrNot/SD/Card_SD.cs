using BelieveOrNot.Models;
using BelieveOrNot.Models.IModels;

namespace BelieveOrNot.SD
{
	public static class Card_SD
	{
		//Suits Constants
		public const string SuitDiamonds = "Diamonds";
		public const string SuitHearts = "Hearts";
		public const string SuitClubs = "Clubs";
		public const string SuitSpades = "Spades";
		//Values Constants
		public const string ValueAce = "A";
		public const string ValueTwo = "2";
		public const string ValueThree = "3";
		public const string ValueFour = "4";
		public const string ValueFive = "5";
		public const string ValueSix = "6";
		public const string ValueSeven = "7";
		public const string ValueEight = "8";
		public const string ValueNine = "9";
		public const string ValueTen = "T";
		public const string ValueJack = "J";
		public const string ValueQueen = "Q";
		public const string ValueKing = "K";

		public static void FillDeck(List<ICard> deck)
		{
			List<string> suits =
			[
				SuitClubs,
				SuitDiamonds,
				SuitHearts,
				SuitSpades
			];

			List<string> values =
			[
				ValueAce,
				ValueTwo,
				ValueThree,
				ValueFour,
				ValueFive,
				ValueSix,
				ValueSeven,
				ValueEight,
				ValueNine,
				ValueTen,
				ValueJack,
				ValueQueen,
				ValueKing
			];
			foreach(var s in suits)
			{
				foreach(var v in values)
				{
					deck.Add(new Card() { Suit = s, Value = v});
				}
			}

			//badly hardcoded
			/*
			deck.AddRange(new List<ICard>()
			{

				//Diamonds cards fill

				new Card(){
					Suit = SuitDiamonds,
					Value = ValueAce
				},
				new Card(){
					Suit = SuitDiamonds,
					Value = ValueTwo
				},
				new Card(){
					Suit = SuitDiamonds,
					Value = ValueThree
				},
				new Card(){
					Suit = SuitDiamonds,
					Value = ValueFour
				},
				new Card(){
					Suit = SuitDiamonds,
					Value = ValueFive
				},
				new Card(){
					Suit = SuitDiamonds,
					Value = ValueSix
				},
				new Card(){
					Suit = SuitDiamonds,
					Value = ValueSeven
				},
				new Card(){
					Suit = SuitDiamonds,
					Value = ValueEight
				},
				new Card(){
					Suit = SuitDiamonds,
					Value = ValueNine
				},
				new Card(){
					Suit = SuitDiamonds,
					Value = ValueTen
				},
				new Card(){
					Suit = SuitDiamonds,
					Value = ValueJack
				},
				new Card(){
					Suit = SuitDiamonds,
					Value = ValueQueen
				},
				new Card(){
					Suit = SuitDiamonds,
					Value = ValueKing
				},

				//Clubs cards fill

				new Card(){
					Suit = SuitClubs,
					Value = ValueAce
				},
				new Card(){
					Suit = SuitClubs,
					Value = ValueTwo
				},
				new Card(){
					Suit = SuitClubs,
					Value = ValueThree
				},
				new Card(){
					Suit = SuitClubs,
					Value = ValueFour
				},
				new Card(){
					Suit = SuitClubs,
					Value = ValueFive
				},
				new Card(){
					Suit = SuitClubs,
					Value = ValueSix
				},
				new Card(){
					Suit = SuitClubs,
					Value = ValueSeven
				},
				new Card(){
					Suit = SuitClubs,
					Value = ValueEight
				},
				new Card(){
					Suit = SuitClubs,
					Value = ValueNine
				},
				new Card(){
					Suit = SuitClubs,
					Value = ValueTen
				},
				new Card(){
					Suit = SuitClubs,
					Value = ValueJack
				},
				new Card(){
					Suit = SuitClubs,
					Value = ValueQueen
				},
				new Card(){
					Suit = SuitClubs,
					Value = ValueKing
				},

				//Hearts cards fill
				
				new Card(){
					Suit = SuitHearts,
					Value = ValueAce
				},
				new Card(){
					Suit = SuitHearts,
					Value = ValueTwo
				},
				new Card(){
					Suit = SuitHearts,
					Value = ValueThree
				},
				new Card(){
					Suit = SuitHearts,
					Value = ValueFour
				},
				new Card(){
					Suit = SuitHearts,
					Value = ValueFive
				},
				new Card(){
					Suit = SuitHearts,
					Value = ValueSix
				},
				new Card(){
					Suit = SuitHearts,
					Value = ValueSeven
				},
				new Card(){
					Suit = SuitHearts,
					Value = ValueEight
				},
				new Card(){
					Suit = SuitHearts,
					Value = ValueNine
				},
				new Card(){
					Suit = SuitHearts,
					Value = ValueTen
				},
				new Card(){
					Suit = SuitHearts,
					Value = ValueJack
				},
				new Card(){
					Suit = SuitHearts,
					Value = ValueQueen
				},
				new Card(){
					Suit = SuitHearts,
					Value = ValueKing
				},
				
				// Spades cards fill
				
				new Card(){
					Suit = SuitSpades,
					Value = ValueAce
				},
				new Card(){
					Suit = SuitSpades,
					Value = ValueTwo
				},
				new Card(){
					Suit = SuitSpades,
					Value = ValueThree
				},
				new Card(){
					Suit = SuitSpades,
					Value = ValueFour
				},
				new Card(){
					Suit = SuitSpades,
					Value = ValueFive
				},
				new Card(){
					Suit = SuitSpades,
					Value = ValueSix
				},
				new Card(){
					Suit = SuitSpades,
					Value = ValueSeven
				},
				new Card(){
					Suit = SuitSpades,
					Value = ValueEight
				},
				new Card(){
					Suit = SuitSpades,
					Value = ValueNine
				},
				new Card(){
					Suit = SuitSpades,
					Value = ValueTen
				},
				new Card(){
					Suit = SuitSpades,
					Value = ValueJack
				},
				new Card(){
					Suit = SuitSpades,
					Value = ValueQueen
				},
				new Card(){
					Suit = SuitSpades,
					Value = ValueKing
				},
			}); */
		}
	}
}
