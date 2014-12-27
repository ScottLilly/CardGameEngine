using System.Collections.Generic;
using System.Linq;

namespace CardGameEngine
{
    public class PokerHand : Hand
    {
        private readonly List<int> _hearts = new List<int>();
        private readonly List<int> _clubs = new List<int>();
        private readonly List<int> _diamonds = new List<int>();
        private readonly List<int> _spades = new List<int>();

        private readonly List<int> _allSuits = new List<int>();

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

                if(_allSuits.Contains(4)) // Four of a kind
                {
                    return PokerHandValues.FourOfAKind;
                }

                if(_allSuits.Contains(3) && _allSuits.Contains(2)) // Full house
                {
                    return PokerHandValues.FullHouse;
                }

                if((_hearts.Count(x => x == 1) >= 5) ||
                    (_clubs.Count(x => x == 1) >= 5) ||
                    (_diamonds.Count(x => x == 1) >= 5) ||
                    (_spades.Count(x => x == 1) >= 5)) // Flush
                {
                    return PokerHandValues.Flush;
                }

                if(false) // Straight
                {
                    return PokerHandValues.Straight;
                }

                if(_allSuits.Contains(3)) // Three of a kind
                {
                    return PokerHandValues.ThreeOfAKind;
                }

                if(_allSuits.Count(x => x == 2) == 2) // Two pairs
                {
                    return PokerHandValues.TwoPairs;
                }

                if(_allSuits.Count(x => x == 2) == 1) // One pair
                {
                    return PokerHandValues.OnePair;
                }

                return PokerHandValues.HighCard;
            }
        }

        public PokerHand()
        {
            for(int i = 0; i <= 13; i++)
            {
                _hearts.Add(0);
                _clubs.Add(0);
                _diamonds.Add(0);
                _spades.Add(0);

                _allSuits.Add(0);
            }
        }

        public void AddCard(Card card)
        {
            Cards.Add(card);

            int cardValueIndex = (card.Value - 2);

            switch(card.Suit)
            {
                case Suits.Hearts:
                    _hearts[cardValueIndex]++;
                    break;
                case Suits.Clubs:
                    _clubs[cardValueIndex]++;
                    break;
                case Suits.Diamonds:
                    _diamonds[cardValueIndex]++;
                    break;
                case Suits.Spades:
                    _spades[cardValueIndex]++;
                    break;
            }

            _allSuits[cardValueIndex]++;
        }
    }
}
