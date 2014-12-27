using System.Collections.Generic;

namespace CardGameEngine
{
    public class Hand
    {
        public List<Card> Cards { get; private set; }

        protected Hand()
        {
            Cards = new List<Card>();
        }
    }
}
