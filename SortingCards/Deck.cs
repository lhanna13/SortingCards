using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingCards
{
   public class Deck
    {
        public static readonly IEnumerable<Card> StandardDeck = new Card[]
       
      {
            Card.TwoOfClubs,
            Card.ThreeOfClubs,
            Card.FourOfClubs,
            Card.FiveOfClubs,
            Card.SixOfClubs,
            Card.SevenOfClubs,
            Card.EightOfClubs,
            Card.NineOfClubs,
            Card.TenOfClubs,
            Card.JackOfClubs,
            Card.QueenOfClubs,
            Card.KingOfClubs,
            Card.AceOfClubs,

            Card.TwoOfDiamonds,
            Card.ThreeOfDiamonds,
            Card.FourOfDiamonds,
            Card.FiveOfDiamonds,
            Card.SixOfDiamonds,
            Card.SevenOfDiamonds,
            Card.EightOfDiamonds,
            Card.NineOfDiamonds,
            Card.TenOfDiamonds,
            Card.JackOfDiamonds,
            Card.QueenOfDiamonds,
            Card.KingOfDiamonds,
            Card.AceOfDiamonds,

            Card.TwoOfHearts,
            Card.ThreeOfHearts,
            Card.FourOfHearts,
            Card.FiveOfHearts,
            Card.SixOfHearts,
            Card.SevenOfHearts,
            Card.EightOfHearts,
            Card.NineOfHearts,
            Card.TenOfHearts,
            Card.JackOfHearts,
            Card.QueenOfHearts,
            Card.KingOfHearts,
            Card.AceOfHearts,

            Card.TwoOfSpades,
            Card.ThreeOfSpades,
            Card.FourOfSpades,
            Card.FiveOfSpades,
            Card.SixOfSpades,
            Card.SevenOfSpades,
            Card.EightOfSpades,
            Card.NineOfSpades,
            Card.TenOfSpades,
            Card.JackOfSpades,
            Card.QueenOfSpades,
            Card.KingOfSpades,
           Card.AceOfSpades
      };
        private IEnumerable<Card> standardDeck;

        public Deck(IEnumerable<Card> standardDeck)
        {
            this.standardDeck = standardDeck;
        }
    }
}
