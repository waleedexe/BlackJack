namespace Service.State
{
    public interface IStateService
    {
        GameState GetState();
        void SaveState(GameState state);
    }
}