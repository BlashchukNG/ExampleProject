using Code.Services.Input;

namespace Code.Infrastructure
{
    public sealed class Game
    {
        public static IInputService InputService;

        public readonly GameStateMachine stateMachine;

        public Game(ICoroutineRunner coroutineRunner)
        {
            stateMachine = new GameStateMachine(new SceneLoader(coroutineRunner));
        }
    }
}