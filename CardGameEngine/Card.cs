namespace CardGameEngine
{
    public class Card
    {
        public CardValues Value { get; private set; }
        public Suits Suit { get; private set; }

        public Card(CardValues value, Suits suit)
        {
            Value = value;
            Suit = suit;
        }
    }
}
