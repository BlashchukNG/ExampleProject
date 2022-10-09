using Code.Infrastructure.Services;
using UnityEngine;

namespace Code.Infrastructure.Factory
{
    public interface IGameFactory : 
        IService
    {
        GameObject CreateHero(Vector3 at);
        GameObject CreateHUD();
    }
}