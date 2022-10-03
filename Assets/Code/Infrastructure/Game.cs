using Code.Services.Input;

namespace Code.Infrastructure
{
    public sealed class Game
    {
        public static IInputService InputService;

        public Game()
        {
            RegisterInputService();
        }

        private void RegisterInputService()
        {
            InputService = new InputService();
        }
    }
}