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
        public void TestBurningCards()
        {
            Deck deck = Shuffler.GetShuffledDeck();

            Assert.AreEqual(52, deck.RemainingCards);

            deck.BurnCard();

            Assert.AreEqual(51, deck.RemainingCards);

            // This burns more cards than are remaining in the deck.
            // Make sure it doesn't error out, when burning cards that don't exist in the deck.
            for(int i = 0; i < 52; i++)
            {
                deck.BurnCard();
            }

            Assert.AreEqual(0, deck.RemainingCards);
        }
    }
}
