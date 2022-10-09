using UnityEngine;

namespace Code.Infrastructure.Factory
{
    public interface IGameFactory
    {
        GameObject CreateHero(Vector3 at);
        GameObject CreateHUD();
    }
}