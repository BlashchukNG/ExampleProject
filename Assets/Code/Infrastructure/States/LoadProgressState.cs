using Code.Data;
using Code.Infrastructure.Services.PersistentProgress;
using Code.Infrastructure.Services.SaveLoad;

namespace Code.Infrastructure.States
{
    public sealed class LoadProgressState :
        IState
    {
        private readonly GameStateMachine _gameStateMachine;
        private readonly IPersistentProgressService _persistentProgressService;
        private readonly ISaveLoadService _saveLoadService;

        public LoadProgressState(GameStateMachine gameStateMachine, IPersistentProgressService persistentProgressService, ISaveLoadService saveLoadService)
        {
            _gameStateMachine = gameStateMachine;
            _persistentProgressService = persistentProgressService;
            _saveLoadService = saveLoadService;
        }

        public void Exit()
        {
        }

        public void Enter()
        {
            LoadProgressOrInitProgress();
            _gameStateMachine.Enter<LoadLevelState, string>(_persistentProgressService.Progress.worldData.playerPositionOnLevel.level);
        }

        private void LoadProgressOrInitProgress() => _persistentProgressService.Progress = _saveLoadService.ReadProgress() ?? NewProgress();

        private PlayerProgress NewProgress() => new PlayerProgress(initialLevel: "Main");
    }
}