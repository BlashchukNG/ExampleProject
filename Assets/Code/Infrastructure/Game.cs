using Code.Services.Input;

namespace Code.Infrastructure
{
    public sealed class Game
    {
        public static IInputService inputService;

        public Game()
        {
            RegisterInputService();
        }

        private void RegisterInputService()
        {
            inputService = new InputService();
        }
    }
}