using Microsoft.VisualStudio.TestTools.UnitTesting;

using CardGameEngine;

namespace TestCardGameEngine
{
    [TestClass]
    public class TestShuffler
    {
        [TestMethod]
        public void TestGetSingleDeck()
        {
            Deck deck = Shuffler.GetShuffledDeck();

            Assert.AreEqual(52, deck.RemainingCards);
        }

        [TestMethod]
        public void TestGetTwoDecks()
        {
            Deck deck = Shuffler.GetShuffledDecks(2);

            Assert.AreEqual(104, deck.RemainingCards);
        }
    }
}
