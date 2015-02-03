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
            PokerHand kingHighStraightFlush = new PokerHand("");
            PokerHand queenHighStraightFlush = new PokerHand("");
            PokerHand jackHighStraightFlush = new PokerHand("");
            PokerHand tenHighStraightFlush = new PokerHand("");
            PokerHand nineHighStraightFlush = new PokerHand("");
            PokerHand eightHighStraightFlush = new PokerHand("");
            PokerHand sevenHighStraightFlush = new PokerHand("");
            PokerHand sixHighStraightFlush = new PokerHand("");
            PokerHand fiveHighStraightFlush = new PokerHand("");

            kingHighStraightFlush.AddCard(CardValues.King, Suits.Hearts);
            kingHighStraightFlush.AddCard(CardValues.Queen, Suits.Hearts);
            kingHighStraightFlush.AddCard(CardValues.Jack, Suits.Hearts);
            kingHighStraightFlush.AddCard(CardValues.Ten, Suits.Hearts);
            kingHighStraightFlush.AddCard(CardValues.Nine, Suits.Hearts);

            queenHighStraightFlush.AddCard(CardValues.Queen, Suits.Hearts);
            queenHighStraightFlush.AddCard(CardValues.Jack, Suits.Hearts);
            queenHighStraightFlush.AddCard(CardValues.Ten, Suits.Hearts);
            queenHighStraightFlush.AddCard(CardValues.Nine, Suits.Hearts);
            queenHighStraightFlush.AddCard(CardValues.Eight, Suits.Hearts);

            jackHighStraightFlush.AddCard(CardValues.Jack, Suits.Hearts);
            jackHighStraightFlush.AddCard(CardValues.Ten, Suits.Hearts);
            jackHighStraightFlush.AddCard(CardValues.Nine, Suits.Hearts);
            jackHighStraightFlush.AddCard(CardValues.Eight, Suits.Hearts);
            jackHighStraightFlush.AddCard(CardValues.Seven, Suits.Hearts);

            tenHighStraightFlush.AddCard(CardValues.Ten, Suits.Hearts);
            tenHighStraightFlush.AddCard(CardValues.Nine, Suits.Hearts);
            tenHighStraightFlush.AddCard(CardValues.Eight, Suits.Hearts);
            tenHighStraightFlush.AddCard(CardValues.Seven, Suits.Hearts);
            tenHighStraightFlush.AddCard(CardValues.Six, Suits.Hearts);

            nineHighStraightFlush.AddCard(CardValues.Nine, Suits.Hearts);
            nineHighStraightFlush.AddCard(CardValues.Eight, Suits.Hearts);
            nineHighStraightFlush.AddCard(CardValues.Seven, Suits.Hearts);
            nineHighStraightFlush.AddCard(CardValues.Six, Suits.Hearts);
            nineHighStraightFlush.AddCard(CardValues.Five, Suits.Hearts);

            eightHighStraightFlush.AddCard(CardValues.Eight, Suits.Hearts);
            eightHighStraightFlush.AddCard(CardValues.Seven, Suits.Hearts);
            eightHighStraightFlush.AddCard(CardValues.Six, Suits.Hearts);
            eightHighStraightFlush.AddCard(CardValues.Five, Suits.Hearts);
            eightHighStraightFlush.AddCard(CardValues.Four, Suits.Hearts);

            sevenHighStraightFlush.AddCard(CardValues.Seven, Suits.Hearts);
            sevenHighStraightFlush.AddCard(CardValues.Six, Suits.Hearts);
            sevenHighStraightFlush.AddCard(CardValues.Five, Suits.Hearts);
            sevenHighStraightFlush.AddCard(CardValues.Four, Suits.Hearts);
            sevenHighStraightFlush.AddCard(CardValues.Three, Suits.Hearts);

            sixHighStraightFlush.AddCard(CardValues.Six, Suits.Hearts);
            sixHighStraightFlush.AddCard(CardValues.Five, Suits.Hearts);
            sixHighStraightFlush.AddCard(CardValues.Four, Suits.Hearts);
            sixHighStraightFlush.AddCard(CardValues.Three, Suits.Hearts);
            sixHighStraightFlush.AddCard(CardValues.Two, Suits.Hearts);

            fiveHighStraightFlush.AddCard(CardValues.Five, Suits.Hearts);
            fiveHighStraightFlush.AddCard(CardValues.Four, Suits.Hearts);
            fiveHighStraightFlush.AddCard(CardValues.Three, Suits.Hearts);
            fiveHighStraightFlush.AddCard(CardValues.Two, Suits.Hearts);
            fiveHighStraightFlush.AddCard(CardValues.Ace, Suits.Hearts);

            Assert.AreEqual(PokerHandValues.StraightFlush, kingHighStraightFlush.Value);
            Assert.AreEqual(PokerHandValues.StraightFlush, queenHighStraightFlush.Value);
            Assert.AreEqual(PokerHandValues.StraightFlush, jackHighStraightFlush.Value);
            Assert.AreEqual(PokerHandValues.StraightFlush, tenHighStraightFlush.Value);
            Assert.AreEqual(PokerHandValues.StraightFlush, nineHighStraightFlush.Value);
            Assert.AreEqual(PokerHandValues.StraightFlush, eightHighStraightFlush.Value);
            Assert.AreEqual(PokerHandValues.StraightFlush, sevenHighStraightFlush.Value);
            Assert.AreEqual(PokerHandValues.StraightFlush, sixHighStraightFlush.Value);
            Assert.AreEqual(PokerHandValues.StraightFlush, fiveHighStraightFlush.Value);
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
            PokerHand kingHighStraight = new PokerHand("");
            PokerHand queenHighStraight = new PokerHand("");
            PokerHand jackHighStraight = new PokerHand("");
            PokerHand tenHighStraight = new PokerHand("");
            PokerHand nineHighStraight = new PokerHand("");
            PokerHand eightHighStraight = new PokerHand("");
            PokerHand sevenHighStraight = new PokerHand("");
            PokerHand sixHighStraight = new PokerHand("");
            PokerHand fiveHighStraight = new PokerHand("");

            kingHighStraight.AddCard(CardValues.King, Suits.Hearts);
            kingHighStraight.AddCard(CardValues.Queen, Suits.Clubs);
            kingHighStraight.AddCard(CardValues.Jack, Suits.Hearts);
            kingHighStraight.AddCard(CardValues.Ten, Suits.Hearts);
            kingHighStraight.AddCard(CardValues.Nine, Suits.Hearts);

            queenHighStraight.AddCard(CardValues.Queen, Suits.Hearts);
            queenHighStraight.AddCard(CardValues.Jack, Suits.Clubs);
            queenHighStraight.AddCard(CardValues.Ten, Suits.Hearts);
            queenHighStraight.AddCard(CardValues.Nine, Suits.Hearts);
            queenHighStraight.AddCard(CardValues.Eight, Suits.Hearts);

            jackHighStraight.AddCard(CardValues.Jack, Suits.Hearts);
            jackHighStraight.AddCard(CardValues.Ten, Suits.Clubs);
            jackHighStraight.AddCard(CardValues.Nine, Suits.Hearts);
            jackHighStraight.AddCard(CardValues.Eight, Suits.Hearts);
            jackHighStraight.AddCard(CardValues.Seven, Suits.Hearts);

            tenHighStraight.AddCard(CardValues.Ten, Suits.Hearts);
            tenHighStraight.AddCard(CardValues.Nine, Suits.Clubs);
            tenHighStraight.AddCard(CardValues.Eight, Suits.Hearts);
            tenHighStraight.AddCard(CardValues.Seven, Suits.Hearts);
            tenHighStraight.AddCard(CardValues.Six, Suits.Hearts);

            nineHighStraight.AddCard(CardValues.Nine, Suits.Hearts);
            nineHighStraight.AddCard(CardValues.Eight, Suits.Clubs);
            nineHighStraight.AddCard(CardValues.Seven, Suits.Hearts);
            nineHighStraight.AddCard(CardValues.Six, Suits.Hearts);
            nineHighStraight.AddCard(CardValues.Five, Suits.Hearts);

            eightHighStraight.AddCard(CardValues.Eight, Suits.Hearts);
            eightHighStraight.AddCard(CardValues.Seven, Suits.Clubs);
            eightHighStraight.AddCard(CardValues.Six, Suits.Hearts);
            eightHighStraight.AddCard(CardValues.Five, Suits.Hearts);
            eightHighStraight.AddCard(CardValues.Four, Suits.Hearts);

            sevenHighStraight.AddCard(CardValues.Seven, Suits.Hearts);
            sevenHighStraight.AddCard(CardValues.Six, Suits.Clubs);
            sevenHighStraight.AddCard(CardValues.Five, Suits.Hearts);
            sevenHighStraight.AddCard(CardValues.Four, Suits.Hearts);
            sevenHighStraight.AddCard(CardValues.Three, Suits.Hearts);

            sixHighStraight.AddCard(CardValues.Six, Suits.Hearts);
            sixHighStraight.AddCard(CardValues.Five, Suits.Clubs);
            sixHighStraight.AddCard(CardValues.Four, Suits.Hearts);
            sixHighStraight.AddCard(CardValues.Three, Suits.Hearts);
            sixHighStraight.AddCard(CardValues.Two, Suits.Hearts);

            fiveHighStraight.AddCard(CardValues.Five, Suits.Hearts);
            fiveHighStraight.AddCard(CardValues.Four, Suits.Clubs);
            fiveHighStraight.AddCard(CardValues.Three, Suits.Hearts);
            fiveHighStraight.AddCard(CardValues.Two, Suits.Hearts);
            fiveHighStraight.AddCard(CardValues.Ace, Suits.Hearts);

            Assert.AreEqual(PokerHandValues.Straight, kingHighStraight.Value);
            Assert.AreEqual(PokerHandValues.Straight, queenHighStraight.Value);
            Assert.AreEqual(PokerHandValues.Straight, jackHighStraight.Value);
            Assert.AreEqual(PokerHandValues.Straight, tenHighStraight.Value);
            Assert.AreEqual(PokerHandValues.Straight, nineHighStraight.Value);
            Assert.AreEqual(PokerHandValues.Straight, eightHighStraight.Value);
            Assert.AreEqual(PokerHandValues.Straight, sevenHighStraight.Value);
            Assert.AreEqual(PokerHandValues.Straight, sixHighStraight.Value);
            Assert.AreEqual(PokerHandValues.Straight, fiveHighStraight.Value);
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
