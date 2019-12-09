using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Game
    {
        public Dealer Dealer { get; } = new Dealer();
        public Player Player { get; } = new Player();

        public Game()
        {
        }

        public Score GetScore()
        {
            var score = new Score(Player.Hand.CardTotal, Dealer.Hand.CardTotal);

            if (score.PlayerScore >= 21)
            {
                score.Winner = Winners.Dealer;
                return score;
            }
            if (score.DealerScore >= 21)
            {
                score.Winner = Winners.Player;
                return score;
            }
            if (score.DealerScore < 17)
            { 
                return score; 
            }

                // TODO: what if score is equal?
            if (score.DealerScore == score.PlayerScore)
            {
                score.Winner = Winners.Draw;
                return score;
            }

            score.Winner = score.DealerScore > score.PlayerScore
                ? Winners.Dealer
                : Winners.Player;

            return score;
        }
    }
}
