using System.Linq;

namespace CardGameEngine.Hands
{
    public class PokerHand : Hand
    {
        private readonly CardValueList _hearts = new CardValueList();
        private readonly CardValueList _clubs = new CardValueList();
        private readonly CardValueList _diamonds = new CardValueList();
        private readonly CardValueList _spades = new CardValueList();

        private readonly CardValueList _allSuits = new CardValueList();

        public PokerHandValues Value
        {
            get
            {
                // Keep these checks in this order, from highest hand value to lowest, so you always return the highest hand value.
                //
                // For example, TwoPair would also pass the test for OnePair.

                if(HasRoyalFlush(_hearts) || 
                    HasRoyalFlush(_clubs) || 
                    HasRoyalFlush(_diamonds) ||
                    HasRoyalFlush(_spades)) // Royal flush (Ace/King/Queen/Jack/10, of the same suit)
                {
                    return PokerHandValues.RoyalFlush;
                }

                if(HasStraight(_hearts) ||
                    HasStraight(_clubs) || 
                    HasStraight(_diamonds) || 
                    HasStraight(_spades)) // Straight flush (five cards of the same suit, in a row - excluding 10 -> Ace)
                {
                    return PokerHandValues.StraightFlush;
                }

                if(_allSuits.Values.Contains(4)) // Four of a kind
                {
                    return PokerHandValues.FourOfAKind;
                }

                if(_allSuits.Values.Contains(3) && _allSuits.Values.Contains(2)) // Full house
                {
                    return PokerHandValues.FullHouse;
                }

                if((_hearts.Values.Count(x => x == 1) >= 5) ||
                    (_clubs.Values.Count(x => x == 1) >= 5) ||
                    (_diamonds.Values.Count(x => x == 1) >= 5) ||
                    (_spades.Values.Count(x => x == 1) >= 5)) // Flush (five cards of the same suit)
                {
                    return PokerHandValues.Flush;
                }

                if(HasStraight(_allSuits)) // Straight (five cards in a row, any suit combination)
                {
                    return PokerHandValues.Straight;
                }

                if(_allSuits.Values.Contains(3)) // Three of a kind
                {
                    return PokerHandValues.ThreeOfAKind;
                }

                if(_allSuits.Values.Count(x => x == 2) == 2) // Two pairs
                {
                    return PokerHandValues.TwoPairs;
                }

                if(_allSuits.Values.Count(x => x == 2) == 1) // One pair
                {
                    return PokerHandValues.OnePair;
                }

                return PokerHandValues.HighCard;
            }
        }

        public PokerHand(object id) : base(id)
        {
        }

        public new void AddCard(CardValues value, Suits suit)
        {
            base.AddCard(value, suit);

            switch(suit)
            {
                case Suits.Hearts:
                    _hearts.IncrementCounterFor(value);
                    break;
                case Suits.Clubs:
                    _clubs.IncrementCounterFor(value);
                    break;
                case Suits.Diamonds:
                    _diamonds.IncrementCounterFor(value);
                    break;
                case Suits.Spades:
                    _spades.IncrementCounterFor(value);
                    break;
            }

            _allSuits.IncrementCounterFor(value);
        }

        private static bool HasRoyalFlush(CardValueList suitCardValueList)
        {
            return suitCardValueList.HasCard(CardValues.Ace) && 
                   suitCardValueList.HasCard(CardValues.King) && 
                   suitCardValueList.HasCard(CardValues.Queen) && 
                   suitCardValueList.HasCard(CardValues.Jack) &&
                   suitCardValueList.HasCard(CardValues.Ten);
        }

        private static bool HasStraight(CardValueList suitCardValueList)
        {
            // Don't check for an Ace-high straight-flush, since that would be found as a Royal Flush

            if(suitCardValueList.HasCard(CardValues.King) &&
               suitCardValueList.HasCard(CardValues.Queen) &&
               suitCardValueList.HasCard(CardValues.Jack) &&
               suitCardValueList.HasCard(CardValues.Ten) &&
               suitCardValueList.HasCard(CardValues.Nine))
            {
                return true;
            }

            if(suitCardValueList.HasCard(CardValues.Queen) &&
               suitCardValueList.HasCard(CardValues.Jack) &&
               suitCardValueList.HasCard(CardValues.Ten) &&
               suitCardValueList.HasCard(CardValues.Nine) &&
               suitCardValueList.HasCard(CardValues.Eight))
            {
                return true;
            }

            if(suitCardValueList.HasCard(CardValues.Jack) &&
               suitCardValueList.HasCard(CardValues.Ten) &&
               suitCardValueList.HasCard(CardValues.Nine) &&
               suitCardValueList.HasCard(CardValues.Eight) &&
               suitCardValueList.HasCard(CardValues.Seven))
            {
                return true;
            }

            if(suitCardValueList.HasCard(CardValues.Ten) &&
               suitCardValueList.HasCard(CardValues.Nine) &&
               suitCardValueList.HasCard(CardValues.Eight) &&
               suitCardValueList.HasCard(CardValues.Seven) &&
               suitCardValueList.HasCard(CardValues.Six))
            {
                return true;
            }

            if(suitCardValueList.HasCard(CardValues.Nine) &&
               suitCardValueList.HasCard(CardValues.Eight) &&
               suitCardValueList.HasCard(CardValues.Seven) &&
               suitCardValueList.HasCard(CardValues.Six) &&
               suitCardValueList.HasCard(CardValues.Five))
            {
                return true;
            }

            if(suitCardValueList.HasCard(CardValues.Eight) &&
               suitCardValueList.HasCard(CardValues.Seven) &&
               suitCardValueList.HasCard(CardValues.Six) &&
               suitCardValueList.HasCard(CardValues.Five) &&
               suitCardValueList.HasCard(CardValues.Four))
            {
                return true;
            }

            if(suitCardValueList.HasCard(CardValues.Seven) &&
               suitCardValueList.HasCard(CardValues.Six) &&
               suitCardValueList.HasCard(CardValues.Five) &&
               suitCardValueList.HasCard(CardValues.Four) &&
               suitCardValueList.HasCard(CardValues.Three))
            {
                return true;
            }

            if(suitCardValueList.HasCard(CardValues.Six) &&
               suitCardValueList.HasCard(CardValues.Five) &&
               suitCardValueList.HasCard(CardValues.Four) &&
               suitCardValueList.HasCard(CardValues.Three) &&
               suitCardValueList.HasCard(CardValues.Two))
            {
                return true;
            }

            // Check for a straight, using the Ace as a one
            if(suitCardValueList.HasCard(CardValues.Five) &&
               suitCardValueList.HasCard(CardValues.Four) &&
               suitCardValueList.HasCard(CardValues.Three) &&
               suitCardValueList.HasCard(CardValues.Two) &&
               suitCardValueList.HasCard(CardValues.Ace))
            {
                return true;
            }

            return false;
        }
    }
}
