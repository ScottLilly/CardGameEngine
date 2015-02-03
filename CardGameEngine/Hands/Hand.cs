using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CardGameEngine.Hands
{
    public class Hand
    {
        private readonly List<Card> _cards = new List<Card>();

        protected readonly SortedList<Suits, int[]> CardsForEachSuit = new SortedList<Suits, int[]>();
        protected readonly int[] CardsForAllSuits = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public object ID { get; private set; }

        public ReadOnlyCollection<Card> Cards 
        { 
            get { return _cards.AsReadOnly(); }
        }

        protected Hand(object id)
        {
            ID = id;

            CardsForEachSuit.Add(Suits.Hearts, new[]{ 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 });
            CardsForEachSuit.Add(Suits.Clubs, new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 });
            CardsForEachSuit.Add(Suits.Diamonds, new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 });
            CardsForEachSuit.Add(Suits.Spades, new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 });
        }

        public void AddCard(Card card)
        {
            _cards.Add(card);

            foreach(int arrayPosition in ArrayPositions(card.Value))
            {
                CardsForEachSuit[card.Suit][arrayPosition]++;

                CardsForAllSuits[arrayPosition]++;
            }
        }

        public void RemoveCard(Card card)
        {
            foreach(int arrayPosition in ArrayPositions(card.Value))
            {
                if(CardsForEachSuit[card.Suit][arrayPosition] > 0)
                {
                    CardsForEachSuit[card.Suit][arrayPosition]--;
                }

                if(CardsForAllSuits[arrayPosition] > 0)
                {
                    CardsForAllSuits[arrayPosition]--;
                }
            }
        }

        protected static IEnumerable<int> ArrayPositions(CardValues cardValue)
        {
            // This returns multiple positions, because aces are treated as low cards and high cards
            // This is to allow for an Ace-2-3-4-5 poker straight

            List<int> positions = new List<int>();

            switch(cardValue)
            {
                case CardValues.Ace:
                    positions.Add(0);
                    positions.Add(13);
                    break;
                case CardValues.Two:
                    positions.Add(1);
                    break;
                case CardValues.Three:
                    positions.Add(2);
                    break;
                case CardValues.Four:
                    positions.Add(3);
                    break;
                case CardValues.Five:
                    positions.Add(4);
                    break;
                case CardValues.Six:
                    positions.Add(5);
                    break;
                case CardValues.Seven:
                    positions.Add(6);
                    break;
                case CardValues.Eight:
                    positions.Add(7);
                    break;
                case CardValues.Nine:
                    positions.Add(8);
                    break;
                case CardValues.Ten:
                    positions.Add(9);
                    break;
                case CardValues.Jack:
                    positions.Add(10);
                    break;
                case CardValues.Queen:
                    positions.Add(11);
                    break;
                case CardValues.King:
                    positions.Add(12);
                    break;
            }

            return positions;
        }
    }
}
