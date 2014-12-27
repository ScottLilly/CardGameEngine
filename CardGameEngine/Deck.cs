using System.Collections.Generic;

namespace CardGameEngine
{
    public class Deck
    {
        private readonly List<Card> _cards = new List<Card>();

        public int RemainingCards { get { return _cards.Count; } }

        internal void AddCard(Card card)
        {
            _cards.Add(card);
        }

        public Card TakeNextCard()
        {
            return TakeCardAtPosition(0);
        }

        internal Card TakeCardAtPosition(int position)
        {
            Card card = _cards[position];

            _cards.RemoveAt(position);

            return card;
        }
    }
}
