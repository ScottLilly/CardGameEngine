using System.Collections.Generic;
using System.Linq;

namespace CardGameEngine.Hands
{
    public class PokerHand : Hand
    {
        private readonly List<Card> _cardsUsedInHand = new List<Card>();
        private readonly List<Card> _cardsNotUsedInHand = new List<Card>();

        public PokerHandValues Value
        {
            get
            {
                // Keep the checks in this order, from highest hand value to lowest.
                // This way, you always return the highest hand value.

                if(HasRoyalFlush())
                {
                    return PokerHandValues.RoyalFlush;
                }

                if(HasStraightFlush())
                {
                    return PokerHandValues.StraightFlush;
                }

                if(CardsForAllSuits.Contains(4))
                {
                    return PokerHandValues.FourOfAKind;
                }

                if(CardsForAllSuits.Contains(3) && CardsForAllSuits.Contains(2))
                {
                    return PokerHandValues.FullHouse;
                }

                if(HasFlush())
                {
                    return PokerHandValues.Flush;
                }

                if(HasStraight())
                {
                    return PokerHandValues.Straight;
                }

                if(CardsForAllSuits.Contains(3))
                {
                    return PokerHandValues.ThreeOfAKind;
                }

                if(CardsForAllSuits.Count(x => x == 2) == 2)
                {
                    return PokerHandValues.TwoPairs;
                }

                if(CardsForAllSuits.Count(x => x == 2) == 1)
                {
                    return PokerHandValues.OnePair;
                }

                return PokerHandValues.HighCard;
            }
        }

        public PokerHand(object id) : base(id)
        {
        }

        public void AddCard(CardValues value, Suits suit)
        {
            base.AddCard(new Card(value, suit));
        }

        private bool HasRoyalFlush()
        {
            // Ace/King/Queen/Jack/10, of the same suit

            return CardsForEachSuit.Values.Any(cards => 
                ArrayPositions(CardValues.Ace).All(x => cards[x] > 0) && 
                ArrayPositions(CardValues.King).All(x => cards[x] > 0) && 
                ArrayPositions(CardValues.Queen).All(x => cards[x] > 0) && 
                ArrayPositions(CardValues.Jack).All(x => cards[x] > 0) && 
                ArrayPositions(CardValues.Ten).All(x => cards[x] > 0));
        }

        private bool HasStraightFlush()
        {
            // Five cards of the same suit, in a row - excluding Ace -> 10 [Royal Flush]

            return CardsForEachSuit.Values.Any(StraightExists);
        }

        private bool HasFlush()
        {
            // Five cards of the same suit

            foreach(int[] cards in CardsForEachSuit.Values)
            {
                int cardsForSuit = 0;

                // Need to offset by one, so we don't count the ace twice (since it's in two positions, for high and low card)
                for(int i = 1; i < cards.Length; i++)
                {
                    if(cards[i] == 1)
                    {
                        cardsForSuit++;
                    }
                }

                if(cardsForSuit >= 5)
                {
                    return true;
                }
            }

            return false;
        }

        private bool HasStraight()
        {
            // Five cards in a row, any suit combination

            return StraightExists(CardsForAllSuits);
        }

        private static bool StraightExists(int[] cards)
        {
            bool hasKing = ArrayPositions(CardValues.King).All(x => cards[x] > 0);
            bool hasQueen = ArrayPositions(CardValues.Queen).All(x => cards[x] > 0);
            bool hasJack = ArrayPositions(CardValues.Jack).All(x => cards[x] > 0);
            bool hasTen = ArrayPositions(CardValues.Ten).All(x => cards[x] > 0);
            bool hasNine = ArrayPositions(CardValues.Nine).All(x => cards[x] > 0);
            bool hasEight = ArrayPositions(CardValues.Eight).All(x => cards[x] > 0);
            bool hasSeven = ArrayPositions(CardValues.Seven).All(x => cards[x] > 0);
            bool hasSix = ArrayPositions(CardValues.Six).All(x => cards[x] > 0);
            bool hasFive = ArrayPositions(CardValues.Five).All(x => cards[x] > 0);
            bool hasFour = ArrayPositions(CardValues.Four).All(x => cards[x] > 0);
            bool hasThree = ArrayPositions(CardValues.Three).All(x => cards[x] > 0);
            bool hasTwo = ArrayPositions(CardValues.Two).All(x => cards[x] > 0);
            bool hasAce = ArrayPositions(CardValues.Ace).All(x => cards[x] > 0);

            // Don't check for an Ace-high straight-flush, since that would be a Royal Flush

            if(hasKing && hasQueen && hasJack && hasTen && hasNine)
            {
                return true;
            }

            if(hasQueen && hasJack && hasTen && hasNine && hasEight)
            {
                return true;
            }

            if(hasJack && hasTen && hasNine && hasEight && hasSeven)
            {
                return true;
            }

            if(hasTen && hasNine && hasEight && hasSeven && hasSix)
            {
                return true;
            }

            if(hasNine && hasEight && hasSeven && hasSix && hasFive)
            {
                return true;
            }

            if(hasEight && hasSeven && hasSix && hasFive && hasFour)
            {
                return true;
            }

            if(hasSeven && hasSix && hasFive && hasFour && hasThree)
            {
                return true;
            }

            if(hasSix && hasFive && hasFour && hasThree && hasTwo)
            {
                return true;
            }

            // Use the Ace as a one
            if(hasFive && hasFour && hasThree && hasTwo && hasAce)
            {
                return true;
            }

            return false;
        }
    }
}
