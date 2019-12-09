using System.Collections.Generic;

namespace Domain
{
    public class Dictionaries
    {
        public static Dictionary<Faces, int> CardValues = new Dictionary<Faces, int>()
        {
            { Faces.Ace, 1 },
            { Faces.Two, 2 },
            { Faces.Three, 3 },
            { Faces.Four, 4 },
            { Faces.Five, 5 },
            { Faces.Six, 6 },
            { Faces.Seven, 7 },
            { Faces.Eight, 8 },
            { Faces.Nine, 9 },
            { Faces.Ten, 10 },
            { Faces.King, 10 },
            { Faces.Queen, 10 },
            { Faces.Jack, 10 },
        };
    }
}
