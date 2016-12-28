using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingCards
{
   public class Person
    {
       public IEnumerable<Card> myDeck = Deck.StandardDeck;
       public static Card[] array;
        public  static int arraySize = 0;
        int rightPointer = arraySize;
        List<Card> clubsList = new List<Card>();
        List<Card> spadesList = new List<Card>();
        List<Card> heartsList = new List<Card>();
        List<Card> diamondsList = new List<Card>();
        List<Card> jokerList = new List<Card>();

        public Person()
        {
            array = myDeck.ToArray();
            arraySize = array.Length;
        }
        public void shuffleDeck(IEnumerable<Card> deck)
        {
            myDeck = deck;
            Random rand = new Random();

            Card[] shuffleArray = myDeck.ToArray();
            int num = shuffleArray.Length;
           
            for (int k = 0; k < 50; k++)
            {
                for (int firstCard = 0; firstCard < myDeck.Count(); firstCard++)
                {
                    int secondCard = rand.Next(num);
                    Card temp = shuffleArray[firstCard];
                    shuffleArray[firstCard] = shuffleArray[secondCard];
                    shuffleArray[secondCard] = temp;

                }
            }
            myDeck = shuffleArray;
            displayDeck();
            array = shuffleArray;

        }


        public void sortInOrderBySuit()
        {
            IEnumerable<Card> newDeck = new Card[53];
           foreach(Card card in myDeck)
            {
                if(card.Suit.Equals(CardSuit.Clubs))
                {
                    clubsList.Add(card);
                }
                if (card.Suit.Equals(CardSuit.Diamonds))
                {
                    diamondsList.Add(card);
                }
                if (card.Suit.Equals(CardSuit.Hearts))
                {
                    heartsList.Add(card);
                }
                if (card.Suit.Equals(CardSuit.Spades))
                {
                    spadesList.Add(card);
                }
                if (card.Suit.Equals(CardSuit.Joker))
                {
                    jokerList.Add(card);
                }
            }
           newDeck = clubsList.ToArray();
            displayList(newDeck.ToList());
            newDeck = diamondsList.ToArray();
            displayList(newDeck.ToList());
            newDeck = heartsList.ToArray();
            displayList(newDeck.ToList());
            newDeck = spadesList.ToArray();
            displayList(newDeck.ToList());


        }

       
        //QuickSort to Sort in ascending order by number, suit doesn't mater.
        public void sortByNumber(int left, int right)
        {
            if(right - left <= 0)//If everything in the subsections has been run through the sort
            {
                return;
            }
            else
            {
                int pivot = (int)array[right].Value;//Pivot is rightmost value

                int pivotLocation = partitionArray(right, left, pivot);

                sortByNumber(left, pivotLocation - 1); // Sorts the left side

                sortByNumber(pivotLocation + 1, right);
            }

        }
        //Partition the Array
        private int partitionArray(int right, int left, int pivot)
        {
            int leftPointer = left - 1;
            int rightPointer = right;
            while (true)
            {
                //break out of this when we hit a value that is greater than the pivot
                while ((int)array[++leftPointer].Value < pivot)
                                        ;

                //break out of this when we hit a value that is less than the pivot or less than 0.
                while (rightPointer > 0 && (int)array[--rightPointer].Value > pivot)
                                        ;
              
                if (leftPointer >= rightPointer)
                {
                    break;
                }
	            else {
                    swapValues(leftPointer, rightPointer);
                }
            }
            swapValues(leftPointer, right); //Putting the Pivot where it belongs
            return leftPointer; //New Pivot
        }

      
        private void swapValues(int leftPointer, int rightPointer)
        {
            Card tempCard = array[leftPointer];
            array[leftPointer] = array[rightPointer];
            array[rightPointer] = tempCard;
        }

        public void displayList(List<Card> list)
        {
            foreach (Card card in list)
            {
                Console.WriteLine(card.Value.ToString() + " " + card.Suit.ToString());
            }
        }
        public void displayDeck()
        {
            foreach(Card card in myDeck)
            {
                Console.WriteLine(card.Value.ToString() + " " + card.Suit.ToString());
            }
        }
	}
}

