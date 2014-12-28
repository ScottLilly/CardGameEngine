using Microsoft.VisualStudio.TestTools.UnitTesting;

using CardGameEngine;
using CardGameEngine.Hands;

namespace TestCardGameEngine.Hands
{
    [TestClass]
    public class TestPokerHand
    {
        [TestMethod]
        public void TestRoyalFlushIsFound()
        {
            PokerHand heartHand = new PokerHand("");
            PokerHand clubHand = new PokerHand("");
            PokerHand diamondHand = new PokerHand("");
            PokerHand spadeHand = new PokerHand("");

            heartHand.AddCard(CardValues.Ace, Suits.Hearts);
            heartHand.AddCard(CardValues.King, Suits.Hearts);
            heartHand.AddCard(CardValues.Queen, Suits.Hearts);
            heartHand.AddCard(CardValues.Jack, Suits.Hearts);
            heartHand.AddCard(CardValues.Ten, Suits.Hearts);

            clubHand.AddCard(CardValues.Ace, Suits.Clubs);
            clubHand.AddCard(CardValues.King, Suits.Clubs);
            clubHand.AddCard(CardValues.Queen, Suits.Clubs);
            clubHand.AddCard(CardValues.Jack, Suits.Clubs);
            clubHand.AddCard(CardValues.Ten, Suits.Clubs);

            diamondHand.AddCard(CardValues.Ace, Suits.Diamonds);
            diamondHand.AddCard(CardValues.King, Suits.Diamonds);
            diamondHand.AddCard(CardValues.Queen, Suits.Diamonds);
            diamondHand.AddCard(CardValues.Jack, Suits.Diamonds);
            diamondHand.AddCard(CardValues.Ten, Suits.Diamonds);

            spadeHand.AddCard(CardValues.Ace, Suits.Spades);
            spadeHand.AddCard(CardValues.King, Suits.Spades);
            spadeHand.AddCard(CardValues.Queen, Suits.Spades);
            spadeHand.AddCard(CardValues.Jack, Suits.Spades);
            spadeHand.AddCard(CardValues.Ten, Suits.Spades);

            Assert.AreEqual(PokerHandValues.RoyalFlush, heartHand.Value);
            Assert.AreEqual(PokerHandValues.RoyalFlush, clubHand.Value);
            Assert.AreEqual(PokerHandValues.RoyalFlush, diamondHand.Value);
            Assert.AreEqual(PokerHandValues.RoyalFlush, spadeHand.Value);
        }

        [TestMethod]
        public void TestStraightFlushIsFound()
        {
        }

        [TestMethod]
        public void TestFourOfAKindIsFound()
        {
            PokerHand hand = new PokerHand("");

            hand.AddCard(CardValues.Five, Suits.Hearts);
            hand.AddCard(CardValues.Five, Suits.Clubs);
            hand.AddCard(CardValues.Five, Suits.Diamonds);
            hand.AddCard(CardValues.Five, Suits.Spades);

            hand.AddCard(CardValues.Four, Suits.Spades);

            Assert.AreEqual(PokerHandValues.FourOfAKind, hand.Value);
        }

        [TestMethod]
        public void TestFullHouseIsFound()
        {
            PokerHand hand = new PokerHand("");

            hand.AddCard(CardValues.Five, Suits.Hearts);
            hand.AddCard(CardValues.Five, Suits.Clubs);
            hand.AddCard(CardValues.Five, Suits.Diamonds);

            hand.AddCard(CardValues.Four, Suits.Hearts);
            hand.AddCard(CardValues.Four, Suits.Clubs);

            Assert.AreEqual(PokerHandValues.FullHouse, hand.Value);
        }

        [TestMethod]
        public void TestFlushIsFound()
        {
            PokerHand heartsHand = new PokerHand("");
            PokerHand clubsHand = new PokerHand("");
            PokerHand diamondsHand = new PokerHand("");
            PokerHand spadesHand = new PokerHand("");

            heartsHand.AddCard(CardValues.Seven, Suits.Hearts);
            heartsHand.AddCard(CardValues.Five, Suits.Hearts);
            heartsHand.AddCard(CardValues.Four, Suits.Hearts);
            heartsHand.AddCard(CardValues.Three, Suits.Hearts);
            heartsHand.AddCard(CardValues.Two, Suits.Hearts);

            clubsHand.AddCard(CardValues.Seven, Suits.Clubs);
            clubsHand.AddCard(CardValues.Five, Suits.Clubs);
            clubsHand.AddCard(CardValues.Four, Suits.Clubs);
            clubsHand.AddCard(CardValues.Three, Suits.Clubs);
            clubsHand.AddCard(CardValues.Two, Suits.Clubs);

            diamondsHand.AddCard(CardValues.Seven, Suits.Diamonds);
            diamondsHand.AddCard(CardValues.Five, Suits.Diamonds);
            diamondsHand.AddCard(CardValues.Four, Suits.Diamonds);
            diamondsHand.AddCard(CardValues.Three, Suits.Diamonds);
            diamondsHand.AddCard(CardValues.Two, Suits.Diamonds);

            spadesHand.AddCard(CardValues.Seven, Suits.Spades);
            spadesHand.AddCard(CardValues.Five, Suits.Spades);
            spadesHand.AddCard(CardValues.Four, Suits.Spades);
            spadesHand.AddCard(CardValues.Three, Suits.Spades);
            spadesHand.AddCard(CardValues.Two, Suits.Spades);


            Assert.AreEqual(PokerHandValues.Flush, heartsHand.Value);
            Assert.AreEqual(PokerHandValues.Flush, clubsHand.Value);
            Assert.AreEqual(PokerHandValues.Flush, diamondsHand.Value);
            Assert.AreEqual(PokerHandValues.Flush, spadesHand.Value);
        }

        [TestMethod]
        public void TestStraightIsFound()
        {
        }

        [TestMethod]
        public void TestThreeOfAKindIsFound()
        {
            PokerHand hand = new PokerHand("");

            hand.AddCard(CardValues.Five, Suits.Hearts);
            hand.AddCard(CardValues.Five, Suits.Clubs);
            hand.AddCard(CardValues.Five, Suits.Diamonds);

            hand.AddCard(CardValues.Four, Suits.Hearts);
            hand.AddCard(CardValues.Three, Suits.Hearts);

            Assert.AreEqual(PokerHandValues.ThreeOfAKind, hand.Value);
        }

        [TestMethod]
        public void TestTwoPairsIsFound()
        {
            PokerHand hand = new PokerHand("");

            hand.AddCard(CardValues.Five, Suits.Hearts);
            hand.AddCard(CardValues.Five, Suits.Clubs);

            hand.AddCard(CardValues.Four, Suits.Hearts);
            hand.AddCard(CardValues.Four, Suits.Clubs);

            hand.AddCard(CardValues.Three, Suits.Diamonds);

            Assert.AreEqual(PokerHandValues.TwoPairs, hand.Value);
        }

        [TestMethod]
        public void TestOnePairIsFound()
        {
            PokerHand hand = new PokerHand("");

            hand.AddCard(CardValues.Five, Suits.Hearts);
            hand.AddCard(CardValues.Five, Suits.Clubs);

            hand.AddCard(CardValues.Four, Suits.Hearts);
            hand.AddCard(CardValues.Three, Suits.Hearts);
            hand.AddCard(CardValues.Two, Suits.Hearts);

            Assert.AreEqual(PokerHandValues.OnePair, hand.Value);
        }

        [TestMethod]
        public void TestHighCardIsFound()
        {
            PokerHand hand = new PokerHand("");

            hand.AddCard(CardValues.Seven, Suits.Hearts);
            hand.AddCard(CardValues.Five, Suits.Clubs);
            hand.AddCard(CardValues.Four, Suits.Hearts);
            hand.AddCard(CardValues.Three, Suits.Hearts);
            hand.AddCard(CardValues.Two, Suits.Hearts);

            Assert.AreEqual(PokerHandValues.HighCard, hand.Value);
        }

    }
}
