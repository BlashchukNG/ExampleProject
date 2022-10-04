using Code.Services.Input;

namespace Code.Infrastructure.States
{
    public sealed class BootstrapState :
        IState
    {
        private const string Initial = "Initial";

        private readonly GameStateMachine _gameStateMachine;
        private readonly SceneLoader _sceneLoader;

        public BootstrapState(GameStateMachine gameStateMachine, SceneLoader sceneLoader)
        {
            _gameStateMachine = gameStateMachine;
            _sceneLoader = sceneLoader;
        }

        public void Enter()
        {
            RegisterServices();
            _sceneLoader.Load(Initial, onLoaded: EnterLoadScene);
        }

        private void EnterLoadScene() => _gameStateMachine.Enter<LoadLevelState, string>("Main");

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