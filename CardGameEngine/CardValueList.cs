using System;
using System.Collections.Generic;

namespace CardGameEngine
{
    // This class is used to hold a count of the number of cards, and their values.
    // For this library, the lowest value is 2 (we deal with treating Ace as 1 in other places).
    // So, remember to subtract 2 from the card's value, to find its index in the list.
    
    internal class CardValueList
    {
        internal List<int> Values { get; set; }

        internal CardValueList()
        {
            Values = new List<int>();

            for(int i = 0; i < 13; i++)
            {
                Values.Add(0);
            }
        }

        internal bool HasCard(CardValues value)
        {
            return Values[IndexForCardValue(value)] > 0;
        }

        internal void IncrementCounterFor(CardValues value)
        {
            Values[IndexForCardValue(value)]++;
        }

        private static int IndexForCardValue(CardValues value)
        {
            switch(value)
            {
                case (CardValues.Ace):
                    return 12;
                case (CardValues.King):
                    return 11;
                case (CardValues.Queen):
                    return 10;
                case (CardValues.Jack):
                    return 9;
                case (CardValues.Ten):
                    return 8;
                case (CardValues.Nine):
                    return 7;
                case (CardValues.Eight):
                    return 6;
                case (CardValues.Seven):
                    return 5;
                case (CardValues.Six):
                    return 4;
                case (CardValues.Five):
                    return 3;
                case (CardValues.Four):
                    return 2;
                case (CardValues.Three):
                    return 1;
                case (CardValues.Two):
                    return 0;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
