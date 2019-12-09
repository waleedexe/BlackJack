using Domain;

namespace Service
{
    public interface IGameService
    {
        void NewGame();
        void Hit(PlayerTypes playerType);
        void Stick();
        Score GetScore();
    }
}