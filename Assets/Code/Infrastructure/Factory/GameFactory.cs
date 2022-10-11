using System.Collections.Generic;
using Code.Infrastructure.AssetManagement;
using Code.Infrastructure.Services.PersistentProgress;
using UnityEngine;

namespace Code.Infrastructure.Factory
{
    public sealed class GameFactory :
        IGameFactory
    {
        private readonly IAssetProvider _assets;

        public List<ISavedProgressReader> ProgressReaders { get; } = new();
        public List<ISavedProgressWriter> ProgressWriters { get; } = new();

        public GameFactory(IAssetProvider assets)
        {
            _assets = assets;
        }

        public GameObject CreateHero(Vector3 at) => InstantiateRegistered(AssetsPath.HERO_PATH, at);

        public GameObject CreateHUD() => InstantiateRegistered(AssetsPath.HUD_PATH);

        public void CleanUp()
        {
            ProgressReaders.Clear();
            ProgressWriters.Clear();
        }

        private GameObject InstantiateRegistered(string path, Vector3 at)
        {
            var obj = _assets.Instantiate(path, at);
            RegisterProgressWatchers(obj);
            return obj;
        }

        private GameObject InstantiateRegistered(string path)
        {
            var obj = _assets.Instantiate(path);
            RegisterProgressWatchers(obj);
            return obj;
        }

        private void RegisterProgressWatchers(GameObject obj)
        {
            foreach (var reader in obj.GetComponentsInChildren<ISavedProgressReader>()) ProgressReaders.Add(reader);
            foreach (var writer in obj.GetComponentsInChildren<ISavedProgressWriter>()) ProgressWriters.Add(writer);
        }
    }
}