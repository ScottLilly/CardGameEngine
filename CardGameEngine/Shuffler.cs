namespace CardGameEngine
{
    public class Shuffler
    {
        public static Deck GetShuffledDeck()
        {
            return GetShuffledDecks(1);
        }

        public static Deck GetShuffledDecks(int numberOfDecks)
        {
            Deck deck = new Deck();

            for(int i = 0; i < numberOfDecks; i++)
            {
                Deck unshuffledDeck = GetUnshuffledDeck();

                while(unshuffledDeck.RemainingCards > 0)
                {
                    Card card = unshuffledDeck.TakeCardAtPosition(RandomNumberGenerator.NumberBetween(0, (unshuffledDeck.RemainingCards - 1)));

                    deck.AddCard(card.Value, card.Suit);
                }
            }

            return deck;
        }

        private static Deck GetUnshuffledDeck()
        {
            Deck deck = new Deck();

            deck.AddCard(CardValues.Two, Suits.Hearts);
            deck.AddCard(CardValues.Three, Suits.Hearts);
            deck.AddCard(CardValues.Four, Suits.Hearts);
            deck.AddCard(CardValues.Five, Suits.Hearts);
            deck.AddCard(CardValues.Six, Suits.Hearts);
            deck.AddCard(CardValues.Seven, Suits.Hearts);
            deck.AddCard(CardValues.Eight, Suits.Hearts);
            deck.AddCard(CardValues.Nine, Suits.Hearts);
            deck.AddCard(CardValues.Ten, Suits.Hearts);
            deck.AddCard(CardValues.Jack, Suits.Hearts);
            deck.AddCard(CardValues.Queen, Suits.Hearts);
            deck.AddCard(CardValues.King, Suits.Hearts);
            deck.AddCard(CardValues.Ace, Suits.Hearts);

            deck.AddCard(CardValues.Two, Suits.Clubs);
            deck.AddCard(CardValues.Three, Suits.Clubs);
            deck.AddCard(CardValues.Four, Suits.Clubs);
            deck.AddCard(CardValues.Five, Suits.Clubs);
            deck.AddCard(CardValues.Six, Suits.Clubs);
            deck.AddCard(CardValues.Seven, Suits.Clubs);
            deck.AddCard(CardValues.Eight, Suits.Clubs);
            deck.AddCard(CardValues.Nine, Suits.Clubs);
            deck.AddCard(CardValues.Ten, Suits.Clubs);
            deck.AddCard(CardValues.Jack, Suits.Clubs);
            deck.AddCard(CardValues.Queen, Suits.Clubs);
            deck.AddCard(CardValues.King, Suits.Clubs);
            deck.AddCard(CardValues.Ace, Suits.Clubs);

            deck.AddCard(CardValues.Two, Suits.Diamonds);
            deck.AddCard(CardValues.Three, Suits.Diamonds);
            deck.AddCard(CardValues.Four, Suits.Diamonds);
            deck.AddCard(CardValues.Five, Suits.Diamonds);
            deck.AddCard(CardValues.Six, Suits.Diamonds);
            deck.AddCard(CardValues.Seven, Suits.Diamonds);
            deck.AddCard(CardValues.Eight, Suits.Diamonds);
            deck.AddCard(CardValues.Nine, Suits.Diamonds);
            deck.AddCard(CardValues.Ten, Suits.Diamonds);
            deck.AddCard(CardValues.Jack, Suits.Diamonds);
            deck.AddCard(CardValues.Queen, Suits.Diamonds);
            deck.AddCard(CardValues.King, Suits.Diamonds);
            deck.AddCard(CardValues.Ace, Suits.Diamonds);

            deck.AddCard(CardValues.Two, Suits.Spades);
            deck.AddCard(CardValues.Three, Suits.Spades);
            deck.AddCard(CardValues.Four, Suits.Spades);
            deck.AddCard(CardValues.Five, Suits.Spades);
            deck.AddCard(CardValues.Six, Suits.Spades);
            deck.AddCard(CardValues.Seven, Suits.Spades);
            deck.AddCard(CardValues.Eight, Suits.Spades);
            deck.AddCard(CardValues.Nine, Suits.Spades);
            deck.AddCard(CardValues.Ten, Suits.Spades);
            deck.AddCard(CardValues.Jack, Suits.Spades);
            deck.AddCard(CardValues.Queen, Suits.Spades);
            deck.AddCard(CardValues.King, Suits.Spades);
            deck.AddCard(CardValues.Ace, Suits.Spades);

            return deck;
        }
    }
}
