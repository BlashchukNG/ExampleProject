using Code.Services.Input;

namespace Code.Infrastructure
{
    public sealed class BootstrapState :
        IState
    {
        private readonly GameStateMachine _gameStateMachine;

        public BootstrapState(GameStateMachine gameStateMachine)
        {
            _gameStateMachine = gameStateMachine;
        }

        public void Enter()
        {
            RegisterServices();
        }

        public void Exit()
        {
        }

        private void RegisterServices()
        {
            RegisterInputService();
        }

        private void RegisterInputService()
        {
            Game.InputService = new InputService();
        }
    }
}