using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CardGameEngine.Hands
{
    public class Hand
    {
        private readonly List<Card> _cards = new List<Card>(); 

        public object ID { get; private set; }

        public ReadOnlyCollection<Card> Cards 
        { 
            get { return _cards.AsReadOnly(); }
        }

        protected Hand(object id)
        {
            ID = id;
        }

        protected void AddCard(CardValues value, Suits suit)
        {
            _cards.Add(new Card(value, suit));
        }
    }
}
