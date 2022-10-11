using Code.Data;
using Code.Extensions;
using Code.Infrastructure.Factory;
using Code.Infrastructure.Services.PersistentProgress;
using UnityEngine;

namespace Code.Infrastructure.Services.SaveLoad
{
    public sealed class SaveLoadService :
        ISaveLoadService
    {
        private const string KEY_PROGRESS = "Progress";

        private readonly IPersistentProgressService _persistentProgressService;
        private readonly IGameFactory _gameFactory;

        public SaveLoadService(IPersistentProgressService persistentProgressService, IGameFactory gameFactory)
        {
            _persistentProgressService = persistentProgressService;
            _gameFactory = gameFactory;
        }

        public void WriteProgress()
        {
            foreach (var writer in _gameFactory.ProgressWriters) writer.WriteProgress(_persistentProgressService.Progress);
            PlayerPrefs.SetString(KEY_PROGRESS, _persistentProgressService.Progress.ToJson());
        }

        public PlayerProgress ReadProgress() => PlayerPrefs.GetString(KEY_PROGRESS)?.FromJson<PlayerProgress>();
    }
}