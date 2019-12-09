namespace Domain
{
    public enum Suits
    {
        Hearts, Diamonds, Spades, Clubs
    }

    public enum Faces
    {
        Ace = 1, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King
    }

    public enum PlayerTypes
    { 
        Dealer, Player 
    }

    public enum Winners
    {
        None, Draw, Dealer, Player
    }
}
