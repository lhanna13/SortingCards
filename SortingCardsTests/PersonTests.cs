using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortingCards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingCards.Tests
{
    [TestClass()]
    public class PersonTests
    {
        [TestMethod()]
        public void shuffleDeckTest()
        {
            Person person = new Person();
            Assert.AreEqual(person.myDeck, Deck.StandardDeck);
            person.shuffleDeck(person.myDeck);
            Assert.AreNotEqual(person.myDeck, Deck.StandardDeck);
        }

      
        [TestMethod()]
        public void sortInOrderBySuitTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void sortByNumberTest()
        {
            Assert.Fail();
        }

    
    }
}