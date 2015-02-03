using System.Collections.Generic;

namespace CardGameEngine
{
    public class Deck
    {
        private readonly List<Card> _cards = new List<Card>();

        public int RemainingCards { get { return _cards.Count; } }

        internal void AddCard(CardValues value, Suits suit)
        {
            _cards.Add(new Card(value, suit));
        }

        public Card TakeNextCard()
        {
            return TakeCardAtPosition(0);
        }

        public void BurnCard()
        {
            if(RemainingCards > 0)
            {
                _cards.RemoveAt(0);
            }
        }

        internal Card TakeCardAtPosition(int position)
        {
            Card card = _cards[position];

            _cards.RemoveAt(position);

            return card;
        }
    }
}
