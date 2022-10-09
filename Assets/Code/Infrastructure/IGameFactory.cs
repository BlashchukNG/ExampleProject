using UnityEngine;

namespace Code.Infrastructure
{
    public interface IGameFactory
    {
        GameObject CreateHero(Vector3 at);
        GameObject CreateHUD();
    }
}