using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Dealer: PersonWithHand
    {
        public Deck Deck { get; } = new Deck();

        public Dealer()
        {
            Deck.Shuffle();
        }

        public void DealCardToPerson(PersonWithHand person)
        {
            var card = Deck.GetCard();

            person.Hand.Cards.Add(card);
        }
    }
}
