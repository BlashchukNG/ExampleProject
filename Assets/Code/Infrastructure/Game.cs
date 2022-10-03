using Code.Services.Input;

namespace Code.Infrastructure
{
    public sealed class Game
    {
        public static IInputService InputService;

        public readonly GameStateMachine stateMachine;

        public Game()
        {
            stateMachine = new GameStateMachine();
        }
    }
}