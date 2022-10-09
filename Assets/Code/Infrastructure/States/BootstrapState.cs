using Code.Infrastructure.AssetManagement;
using Code.Infrastructure.Factory;
using Code.Infrastructure.Services;
using Code.Services.Input;

namespace Code.Infrastructure.States
{
    public sealed class BootstrapState :
        IState
    {
        private const string Initial = "Initial";

        private readonly GameStateMachine _gameStateMachine;
        private readonly SceneLoader _sceneLoader;
        private readonly ServiceLocator _services;

        public BootstrapState(GameStateMachine gameStateMachine, SceneLoader sceneLoader, ServiceLocator services)
        {
            _gameStateMachine = gameStateMachine;
            _sceneLoader = sceneLoader;
            _services = services;
            
            RegisterServices();
        }

        public void Enter()
        {
            _sceneLoader.Load(Initial, onLoaded: EnterLoadScene);
        }

        public void Exit()
        {
        }

        private void EnterLoadScene() => _gameStateMachine.Enter<LoadLevelState, string>("Main");

        private void RegisterServices()
        {
            _services.RegisterSingle<IInputService>(new InputService());
            _services.RegisterSingle<IAssetProvider>(new AssetProvider());
            _services.RegisterSingle<IGameFactory>(new GameFactory(_services.Single<IAssetProvider>()));
        }
    }
}