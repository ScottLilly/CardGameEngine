namespace CardGameEngine
{

    public enum Suits
    {
        Hearts,
        Clubs,
        Diamonds,
        Spades
    }

    public enum CardValues
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }

    // Numbers are assigned to the enum values so we can determine which hand is the best (highest numeric value)
    public enum PokerHandValues
    {
        RoyalFlush = 10,
        StraightFlush = 9,
        FourOfAKind = 8,
        FullHouse = 7,
        Flush = 6,
        Straight = 5,
        ThreeOfAKind = 4,
        TwoPairs = 3,
        OnePair = 2,
        HighCard = 1
    }

}