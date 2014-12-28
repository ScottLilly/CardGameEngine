using System.Collections.Generic;
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
                if(false) // Royal flush
                {
                    return PokerHandValues.RoyalFlush;
                }

                if(false) // Straight flush
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
                    (_spades.Values.Count(x => x == 1) >= 5)) // Flush
                {
                    return PokerHandValues.Flush;
                }

                if(false) // Straight
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

        public new void AddCard(Card card)
        {
            base.AddCard(card);

            int cardValueIndex = (card.Value - 2);

            switch(card.Suit)
            {
                case Suits.Hearts:
                    _hearts.Values[cardValueIndex]++;
                    break;
                case Suits.Clubs:
                    _clubs.Values[cardValueIndex]++;
                    break;
                case Suits.Diamonds:
                    _diamonds.Values[cardValueIndex]++;
                    break;
                case Suits.Spades:
                    _spades.Values[cardValueIndex]++;
                    break;
            }

            _allSuits.Values[cardValueIndex]++;
        }
    }
}
