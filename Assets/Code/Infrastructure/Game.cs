using Code.Infrastructure.States;
using Code.Logic;
using Code.Services.Input;

namespace Code.Infrastructure
{
    public sealed class Game
    {
        public static IInputService InputService;

        public readonly GameStateMachine stateMachine;

        public Game(ICoroutineRunner coroutineRunner, LoadingCurtain loadingCurtain)
        {
            stateMachine = new GameStateMachine(new SceneLoader(coroutineRunner), loadingCurtain);
        }
    }
}