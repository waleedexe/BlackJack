using System;

namespace Domain
{
    public class Card
    {
        public Suits Suit { get; }
        public Faces Face { get; }

        public Card(Suits suit, Faces face)
        {
            Suit = suit;
            Face = face;
        }
    }
}
