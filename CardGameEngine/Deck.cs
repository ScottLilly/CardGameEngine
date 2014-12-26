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
            Card nextCard = _cards[0];

            _cards.RemoveAt(0);

            return nextCard;
        }
    }
}
