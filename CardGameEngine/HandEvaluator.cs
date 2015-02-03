using System.Collections.Generic;
using System.Linq;

using CardGameEngine.Hands;

namespace CardGameEngine
{
    public static class HandEvaluator
    {
        // This method returns a list of hands, because it is possible for hands to be tied in value.
        public static List<PokerHand> WinningPokerHands(List<PokerHand> pokerHands)
        {
            int bestHandNumericValue = pokerHands.Max(x => (int)x.Value);

            List<PokerHand> allHandsWithHighestValue = pokerHands.Where(x => (int)x.Value == bestHandNumericValue).ToList();

            // There is only one hand with the highest-ranking value, so return it.
            if(allHandsWithHighestValue.Count == 1)
            {
                return allHandsWithHighestValue;
            }

            // Check for royal flushes
            if(bestHandNumericValue == (int)PokerHandValues.RoyalFlush)
            {
                // All royal flushes are of equal value, so return them all
                return allHandsWithHighestValue;
            }
            
            // Check for straight flushes

            // Check for four-of-a-kinds

            // Check for full houses

            // Check for flushes

            // Check for straights

            // Check for three-of-a-kinds

            // Check for two pairs

            // Check for one pair

            // Check highest cards

            
            
            
            
            return allHandsWithHighestValue;
        }
    }
}
