using UnityEngine;

namespace Code.Infrastructure
{
    public sealed class GameBootstrapper :
        MonoBehaviour,
        ICoroutineRunner
    {
        private Game _game;

        private void Awake()
        {
            _game = new Game(coroutineRunner: this);
            _game.stateMachine.Enter<BootstrapState>();

            DontDestroyOnLoad(this);
        }

        public Coroutine StartCoroutine(Coroutine coroutine) => StartCoroutine(coroutine);
    }
}