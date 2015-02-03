using System;
using System.Collections.Generic;
using System.Windows.Forms;

using CardGameEngine;
using CardGameEngine.Hands;

namespace Sandbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Use this method to confirm the random shuffler produces the expected hand distribution.

            rtbResults.Clear();

            SortedList<PokerHandValues, int> handsDealt = new SortedList<PokerHandValues, int>();

            int handsToDeal = Convert.ToInt32(txtHandsToDeal.Text);

            for(int i = 0; i < handsToDeal; i++)
            {
                Deck deck = Shuffler.GetShuffledDeck();

                PokerHand hand = new PokerHand("");

                for(int j = 0; j < 5; j++)
                {
                    Card card = deck.TakeNextCard();
                    hand.AddCard(card.Value, card.Suit);
                }

                if(!handsDealt.ContainsKey(hand.Value))
                {
                    handsDealt.Add(hand.Value, 0);
                }

                handsDealt[hand.Value]++;
            }

            rtbResults.Clear();

            foreach(KeyValuePair<PokerHandValues, int> keyValuePair in handsDealt)
            {
                rtbResults.Text += string.Format("{0}:\t {1}\t {2}",
                                                 keyValuePair.Key, keyValuePair.Value,
                                                 (Convert.ToDouble(keyValuePair.Value) / Convert.ToDouble(handsToDeal) * 100));
                rtbResults.Text += Environment.NewLine;
            }
        }
    }
}
