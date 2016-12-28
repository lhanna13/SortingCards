using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingCards
{
   public class Card : IComparable<Card>
    {
        private CardSuit suit;
       private CardValue value;

        public Card(CardValue value, CardSuit suit)
        {
            
            this.value = value;
            this.suit = suit;
        }


        public CardSuit Suit
        {
            get
            {
                return suit;
            }
        }

        public CardValue Value
        {
            get
            {
                return value;
            }
        }

        public int CompareTo(Card otherCard)
        {
            CardValue CV1 = value;
            CardValue CV2 = otherCard.value;
            if (CV1 > CV2)
            {
                return 2;
            }
            else if (CV1 == CV2)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }

        public string toString(Card card)
        {
            return card.ToString();
        }


        public static readonly Card TwoOfClubs = new Card(CardValue.Two, CardSuit.Clubs);
        public static readonly Card ThreeOfClubs = new Card(CardValue.Three, CardSuit.Clubs);
        public static readonly Card FourOfClubs = new Card(CardValue.Four, CardSuit.Clubs);
        public static readonly Card FiveOfClubs = new Card(CardValue.Five, CardSuit.Clubs);
        public static readonly Card SixOfClubs = new Card(CardValue.Six, CardSuit.Clubs);
        public static readonly Card SevenOfClubs = new Card(CardValue.Seven, CardSuit.Clubs);
        public static readonly Card EightOfClubs = new Card(CardValue.Eight, CardSuit.Clubs);
        public static readonly Card NineOfClubs = new Card(CardValue.Nine, CardSuit.Clubs);
        public static readonly Card TenOfClubs = new Card(CardValue.Ten, CardSuit.Clubs);
        public static readonly Card JackOfClubs = new Card(CardValue.Jack, CardSuit.Clubs);
        public static readonly Card QueenOfClubs = new Card(CardValue.Queen, CardSuit.Clubs);
        public static readonly Card KingOfClubs = new Card(CardValue.King, CardSuit.Clubs);
        public static readonly Card AceOfClubs = new Card(CardValue.Ace, CardSuit.Clubs);

        public static readonly Card TwoOfDiamonds = new Card(CardValue.Two, CardSuit.Diamonds);
        public static readonly Card ThreeOfDiamonds = new Card(CardValue.Three, CardSuit.Diamonds);
        public static readonly Card FourOfDiamonds = new Card(CardValue.Four, CardSuit.Diamonds);
        public static readonly Card FiveOfDiamonds = new Card(CardValue.Five, CardSuit.Diamonds);
        public static readonly Card SixOfDiamonds = new Card(CardValue.Six, CardSuit.Diamonds);
        public static readonly Card SevenOfDiamonds = new Card(CardValue.Seven, CardSuit.Diamonds);
        public static readonly Card EightOfDiamonds = new Card(CardValue.Eight, CardSuit.Diamonds);
        public static readonly Card NineOfDiamonds = new Card(CardValue.Nine, CardSuit.Diamonds);
        public static readonly Card TenOfDiamonds = new Card(CardValue.Ten, CardSuit.Diamonds);
        public static readonly Card JackOfDiamonds = new Card(CardValue.Jack, CardSuit.Diamonds);
        public static readonly Card QueenOfDiamonds = new Card(CardValue.Queen, CardSuit.Diamonds);
        public static readonly Card KingOfDiamonds = new Card(CardValue.King, CardSuit.Diamonds);
        public static readonly Card AceOfDiamonds = new Card(CardValue.Ace, CardSuit.Diamonds);

        public static readonly Card TwoOfHearts = new Card(CardValue.Two, CardSuit.Hearts);
        public static readonly Card ThreeOfHearts = new Card(CardValue.Three, CardSuit.Hearts);
        public static readonly Card FourOfHearts = new Card(CardValue.Four, CardSuit.Hearts);
        public static readonly Card FiveOfHearts = new Card(CardValue.Five, CardSuit.Hearts);
        public static readonly Card SixOfHearts = new Card(CardValue.Six, CardSuit.Hearts);
        public static readonly Card SevenOfHearts = new Card(CardValue.Seven, CardSuit.Hearts);
        public static readonly Card EightOfHearts = new Card(CardValue.Eight, CardSuit.Hearts);
        public static readonly Card NineOfHearts = new Card(CardValue.Nine, CardSuit.Hearts);
        public static readonly Card TenOfHearts = new Card(CardValue.Ten, CardSuit.Hearts);
        public static readonly Card JackOfHearts = new Card(CardValue.Jack, CardSuit.Hearts);
        public static readonly Card QueenOfHearts = new Card(CardValue.Queen, CardSuit.Hearts);
        public static readonly Card KingOfHearts = new Card(CardValue.King, CardSuit.Hearts);
        public static readonly Card AceOfHearts = new Card(CardValue.Ace, CardSuit.Hearts);

        public static readonly Card TwoOfSpades = new Card(CardValue.Two, CardSuit.Spades);
        public static readonly Card ThreeOfSpades = new Card(CardValue.Three, CardSuit.Spades);
        public static readonly Card FourOfSpades = new Card(CardValue.Four, CardSuit.Spades);
        public static readonly Card FiveOfSpades = new Card(CardValue.Five, CardSuit.Spades);
        public static readonly Card SixOfSpades = new Card(CardValue.Six, CardSuit.Spades);
        public static readonly Card SevenOfSpades = new Card(CardValue.Seven, CardSuit.Spades);
        public static readonly Card EightOfSpades = new Card(CardValue.Eight, CardSuit.Spades);
        public static readonly Card NineOfSpades = new Card(CardValue.Nine, CardSuit.Spades);
        public static readonly Card TenOfSpades = new Card(CardValue.Ten, CardSuit.Spades);
        public static readonly Card JackOfSpades = new Card(CardValue.Jack, CardSuit.Spades);
        public static readonly Card QueenOfSpades = new Card(CardValue.Queen, CardSuit.Spades);
        public static readonly Card KingOfSpades = new Card(CardValue.King, CardSuit.Spades);
        public static readonly Card AceOfSpades = new Card(CardValue.Ace, CardSuit.Spades);

        public static readonly Card Joker = new Card(CardValue.Joker, CardSuit.Joker);
     
    }
}
