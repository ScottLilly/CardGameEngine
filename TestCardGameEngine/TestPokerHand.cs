using Microsoft.VisualStudio.TestTools.UnitTesting;

using CardGameEngine;

namespace TestCardGameEngine
{
    [TestClass]
    public class TestPokerHand
    {
        [TestMethod]
        public void TestRoyalFlushIsFound()
        {
        }

        [TestMethod]
        public void TestStraightFlushIsFound()
        {
        }

        [TestMethod]
        public void TestFourOfAKindIsFound()
        {
            PokerHand hand = new PokerHand();

            hand.AddCard(new Card(5, Suits.Hearts));
            hand.AddCard(new Card(5, Suits.Clubs));
            hand.AddCard(new Card(5, Suits.Diamonds));
            hand.AddCard(new Card(5, Suits.Spades));

            hand.AddCard(new Card(4, Suits.Spades));

            Assert.AreEqual(PokerHandValues.FourOfAKind, hand.Value);
        }

        [TestMethod]
        public void TestFullHouseIsFound()
        {
            PokerHand hand = new PokerHand();

            hand.AddCard(new Card(5, Suits.Hearts));
            hand.AddCard(new Card(5, Suits.Clubs));
            hand.AddCard(new Card(5, Suits.Diamonds));

            hand.AddCard(new Card(4, Suits.Hearts));
            hand.AddCard(new Card(4, Suits.Clubs));

            Assert.AreEqual(PokerHandValues.FullHouse, hand.Value);
        }

        [TestMethod]
        public void TestFlushIsFound()
        {
            PokerHand heartsHand = new PokerHand();
            PokerHand clubsHand = new PokerHand();
            PokerHand diamondsHand = new PokerHand();
            PokerHand spadesHand = new PokerHand();

            heartsHand.AddCard(new Card(7, Suits.Hearts));
            heartsHand.AddCard(new Card(5, Suits.Hearts));
            heartsHand.AddCard(new Card(4, Suits.Hearts));
            heartsHand.AddCard(new Card(3, Suits.Hearts));
            heartsHand.AddCard(new Card(2, Suits.Hearts));

            clubsHand.AddCard(new Card(7, Suits.Clubs));
            clubsHand.AddCard(new Card(5, Suits.Clubs));
            clubsHand.AddCard(new Card(4, Suits.Clubs));
            clubsHand.AddCard(new Card(3, Suits.Clubs));
            clubsHand.AddCard(new Card(2, Suits.Clubs));

            diamondsHand.AddCard(new Card(7, Suits.Diamonds));
            diamondsHand.AddCard(new Card(5, Suits.Diamonds));
            diamondsHand.AddCard(new Card(4, Suits.Diamonds));
            diamondsHand.AddCard(new Card(3, Suits.Diamonds));
            diamondsHand.AddCard(new Card(2, Suits.Diamonds));

            spadesHand.AddCard(new Card(7, Suits.Spades));
            spadesHand.AddCard(new Card(5, Suits.Spades));
            spadesHand.AddCard(new Card(4, Suits.Spades));
            spadesHand.AddCard(new Card(3, Suits.Spades));
            spadesHand.AddCard(new Card(2, Suits.Spades));

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
            PokerHand hand = new PokerHand();

            hand.AddCard(new Card(5, Suits.Hearts));
            hand.AddCard(new Card(5, Suits.Clubs));
            hand.AddCard(new Card(5, Suits.Diamonds));

            hand.AddCard(new Card(4, Suits.Hearts));
            hand.AddCard(new Card(3, Suits.Hearts));

            Assert.AreEqual(PokerHandValues.ThreeOfAKind, hand.Value);
        }

        [TestMethod]
        public void TestTwoPairsIsFound()
        {
            PokerHand hand = new PokerHand();

            hand.AddCard(new Card(5, Suits.Hearts));
            hand.AddCard(new Card(5, Suits.Clubs));

            hand.AddCard(new Card(4, Suits.Hearts));
            hand.AddCard(new Card(4, Suits.Clubs));

            hand.AddCard(new Card(3, Suits.Diamonds));

            Assert.AreEqual(PokerHandValues.TwoPairs, hand.Value);
        }

        [TestMethod]
        public void TestOnePairIsFound()
        {
            PokerHand hand = new PokerHand();

            hand.AddCard(new Card(5, Suits.Hearts));
            hand.AddCard(new Card(5, Suits.Clubs));

            hand.AddCard(new Card(4, Suits.Hearts));
            hand.AddCard(new Card(3, Suits.Hearts));
            hand.AddCard(new Card(2, Suits.Hearts));

            Assert.AreEqual(PokerHandValues.OnePair, hand.Value);
        }

        [TestMethod]
        public void TestHighCardIsFound()
        {
            PokerHand hand = new PokerHand();

            hand.AddCard(new Card(6, Suits.Hearts));
            hand.AddCard(new Card(5, Suits.Clubs));
            hand.AddCard(new Card(4, Suits.Hearts));
            hand.AddCard(new Card(3, Suits.Hearts));
            hand.AddCard(new Card(2, Suits.Hearts));

            Assert.AreEqual(PokerHandValues.HighCard, hand.Value);
        }

    }
}
