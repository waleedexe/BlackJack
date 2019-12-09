using Domain;
using Service.State;
using System;

namespace Service
{
    public class GameService : IGameService
    {
        private readonly IStateService _stateService;

        public GameService(IStateService stateService)
        {
            _stateService = stateService;
        }

        public void NewGame()
        {
            var gameState = new GameState() { Game = new Game() };
            gameState.Game.Dealer.DealCardToPerson(gameState.Game.Player);
            gameState.Game.Dealer.DealCardToPerson(gameState.Game.Player);
            gameState.Game.Dealer.DealCardToPerson(gameState.Game.Dealer);
            gameState.Game.Dealer.DealCardToPerson(gameState.Game.Dealer);

            _stateService.SaveState(gameState);
        }

        public void Hit(PlayerTypes playerType) 
        {
            var gameState = _stateService.GetState();
            PersonWithHand player = null; 

            switch (playerType)
            {
                case PlayerTypes.Dealer:
                    player = gameState.Game.Dealer;
                    break;
                case PlayerTypes.Player:
                    player = gameState.Game.Player;
                    break;
            }

            gameState.Game.Dealer.DealCardToPerson(player);
            _stateService.SaveState(gameState);
        }

        public void Stick()
        {
            var gameState = _stateService.GetState();
            var dealer = gameState.Game.Dealer;

            while (gameState.Game.Dealer.Hand.CardTotal < 17)
            {
                gameState.Game.Dealer.DealCardToPerson(dealer);
                _stateService.SaveState(gameState);
            }
        }

        public Score GetScore()
        {
            var gameState = _stateService.GetState();
            return gameState.Game.GetScore();
        }
    }
}
