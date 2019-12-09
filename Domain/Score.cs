namespace Domain
{
    public class Score
    {
        public int PlayerScore { get; }
        public int DealerScore { get; }
        public Winners Winner { get; set; }

        public Score(int playerScore, int dealerScore )
        {
            PlayerScore = playerScore;
            DealerScore = dealerScore;
        }
    }
}
