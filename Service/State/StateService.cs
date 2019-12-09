using Service.State;

namespace Service.State
{
    public class StateService : IStateService
    {
        private static GameState State = null;

        public GameState GetState()
        {
            return State;
        }

        public void SaveState(GameState state)
        {
            State = state;
        }
    }
}
