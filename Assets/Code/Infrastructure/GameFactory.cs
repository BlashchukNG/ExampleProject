using UnityEngine;

namespace Code.Infrastructure
{
    public sealed class GameFactory : IGameFactory
    {
        private const string HERO_PATH = "Hero/Hero";
        private const string HUD_PATH = "HUD/HUD";
        
        public GameObject CreateHero(Vector3 at) => Instantiate(HERO_PATH, at);
        public GameObject CreateHUD() => Instantiate(HUD_PATH);
        
        private GameObject Instantiate(string path) => Object.Instantiate(Resources.Load<GameObject>(path));
        private GameObject Instantiate(string path, Vector3 at) => Object.Instantiate(Resources.Load<GameObject>(path), at, Quaternion.identity);
    }
}