using System.Collections.Generic;
using System.Linq;

namespace Domain
{
    public class Hand
    {
        public List<Card> Cards { get; } = new List<Card>();
        public int CardTotal
        {
            get
            {
                // TODO: it is not explained when the Ace is counted as 1 or 11.
                var sum = Cards.Sum(c => Dictionaries.CardValues[c.Face]);
                return sum;
            }
        }

        public void Deal(Card card)
        {
            Cards.Add(card);
        }
    }
}
