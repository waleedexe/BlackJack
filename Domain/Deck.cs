using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain
{
    public class Deck
    {
        public List<Card> Cards { get; private set; }

        public Deck()
        {
            Cards = Enum.GetValues(typeof(Suits)).Cast<Suits>()
                .SelectMany(s => Enum.GetValues(typeof(Faces)).Cast<Faces>()
                .Select(f => new Card(s, f)))
                .ToList();
        }

        public Card GetCard()
        {
            var card = Cards.First();
            Cards.Remove(card);
            
            return card;
        }

        public void Shuffle()
        {
            var rand = new Random();
            Cards = Cards.OrderBy(c => rand.Next()).ToList();
        }
    }
}
