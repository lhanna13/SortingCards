using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingCards
{
    class Program
    {

        static void Main(string[] args)
        {
            Person person = new SortingCards.Person();
            Console.WriteLine("Inital Deck:");
            person.displayDeck();
            Console.WriteLine(" ");

            Console.WriteLine("Shuffled deck:");
            person.shuffleDeck(Deck.StandardDeck);
            Console.WriteLine(" ");
           
            Console.WriteLine("Sorted by suit:");
            person.sortInOrderBySuit();
           
            Console.WriteLine(" ");
          
           
            person.sortByNumber(0, person.myDeck.Count()-1);
            Console.WriteLine("Sorted by Number:(QuickSort)");
            person.displayDeck();
        }
    }
}
