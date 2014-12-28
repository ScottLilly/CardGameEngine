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
                if(HasRoyalFlush(_hearts) || 
                    HasRoyalFlush(_clubs) || 
                    HasRoyalFlush(_diamonds) ||
                    HasRoyalFlush(_spades)) // Royal flush (Ace/King/Queen/Jack/10, of the same suit)
                {
                    return PokerHandValues.RoyalFlush;
                }

                if(false) // Straight flush (five cards of the same suit, in a row - excluding 10 -> Ace)
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

                if(false) // Straight (five cards in a row)
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

        private bool HasRoyalFlush(CardValueList cardValueList)
        {
            if(cardValueList.HasCard(CardValues.Ace) && 
                cardValueList.HasCard(CardValues.King) && 
                cardValueList.HasCard(CardValues.Queen) && 
                cardValueList.HasCard(CardValues.Jack) &&
                cardValueList.HasCard(CardValues.Ten))
            {
                return true;
            }

            return false;
        }
    }
}
