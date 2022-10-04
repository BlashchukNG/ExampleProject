using Code.Logic;
using UnityEngine;

namespace Code.Infrastructure.States
{
    public sealed class LoadLevelState :
        IPayloadedState<string>
    {
        private const string HERO_PATH = "Hero/Hero";
        private const string HUD_PATH = "HUD/HUD";

        private readonly GameStateMachine _gameStateMachine;
        private readonly SceneLoader _sceneLoader;
        private readonly LoadingCurtain _loadingCurtain;

        public LoadLevelState(GameStateMachine gameStateMachine, SceneLoader sceneLoader, LoadingCurtain loadingCurtain)
        {
            _gameStateMachine = gameStateMachine;
            _sceneLoader = sceneLoader;
            _loadingCurtain = loadingCurtain;
        }

        public void Enter(string sceneName)
        {
            _loadingCurtain.Show();
            _sceneLoader.Load(sceneName, onLoaded: OnLoaded);
        }

        public void Exit()
        {
            _loadingCurtain.Hide();
        }

        private void OnLoaded()
        {
            var hero = Instantiate(HERO_PATH);
            var hud = Instantiate(HUD_PATH);

            _gameStateMachine.Enter<GameLoopState>();
        }

        private GameObject Instantiate(string path) => Object.Instantiate(Resources.Load<GameObject>(path));
        private GameObject Instantiate(string path, Vector3 at) => Object.Instantiate(Resources.Load<GameObject>(path), at, Quaternion.identity);
    }
}