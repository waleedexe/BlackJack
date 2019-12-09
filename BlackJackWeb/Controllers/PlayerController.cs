using Microsoft.AspNetCore.Mvc;
using Service;

namespace BlackJackWeb.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlayerController : ControllerBase
    {
        private readonly IGameService _gameService;

        public PlayerController(IGameService gameService)
        {
            _gameService = gameService;
        }

        [HttpPost]
        [Route("hit")]
        public void Hit()
        {
            _gameService.Hit(Domain.PlayerTypes.Player);
        }

        [HttpPost]
        [Route("stick")]
        public void Stick()
        {
            _gameService.Stick();
        }
    }
}
