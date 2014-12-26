namespace CardGameEngine
{
    public class Shuffler
    {
        public static Deck GetDeck()
        {
            return GetDecks(1);
        }

        public static Deck GetDecks(int numberOfDecks)
        {
            Deck deck = new Deck();

            for(int i = 0; i < numberOfDecks; i++)
            {
                Deck unshuffledDeck = GetUnshuffledDeck();

                while(unshuffledDeck.RemainingCards > 0)
                {
                    deck.AddCard(unshuffledDeck.TakeNextCard());
                }
            }

            return deck;
        }

        private static Deck GetUnshuffledDeck()
        {
            Deck deck = new Deck();

            for(int i = 0; i < 4; i++) //Card suits
            {
                for(int j = 1; j < 14; j++) // Card values
                {
                    switch(i)
                    {
                        case 0:
                            deck.AddCard(new Card(j, Suits.Hearts));
                            break;
                        case 1:
                            deck.AddCard(new Card(j, Suits.Clubs));
                            break;
                        case 2:
                            deck.AddCard(new Card(j, Suits.Diamonds));
                            break;
                        case 3:
                            deck.AddCard(new Card(j, Suits.Spades));
                            break;
                    }
                }
            }

            return deck;
        }
    }
}
