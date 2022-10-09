using Code.Infrastructure.AssetManagement;
using UnityEngine;

namespace Code.Infrastructure.Factory
{
    public sealed class GameFactory :
        IGameFactory
    {
        private readonly IAssetProvider _assets;

        public GameFactory(IAssetProvider assets)
        {
            _assets = assets;
        }

        public GameObject CreateHero(Vector3 at) => _assets.Instantiate(AssetsPath.HERO_PATH, at);
        public GameObject CreateHUD() => _assets.Instantiate(AssetsPath.HUD_PATH);
    }
}