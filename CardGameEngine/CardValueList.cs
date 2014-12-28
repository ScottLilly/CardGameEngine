using System.Collections.Generic;

namespace CardGameEngine
{
    internal class CardValueList
    {
        internal List<int> Values { get; set; }

        internal CardValueList()
        {
            Values = new List<int>();

            for(int i = 0; i < 14; i++)
            {
                Values.Add(0);
            }
        }
    }
}
