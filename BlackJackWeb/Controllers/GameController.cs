using Domain;
using Microsoft.AspNetCore.Mvc;
using Service;

namespace BlackJackWeb.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GameController : ControllerBase
    {
        private readonly IGameService _gameService;

        public GameController(IGameService gameService)
        {
            _gameService = gameService;
        }

        [HttpPost]
        [Route("new")]
        public void NewGame()
        {
            _gameService.NewGame();
        }

        [HttpGet]
        [Route("Score")]
        public Score GetScore()
        {
            return _gameService.GetScore();
        }
    }
}
