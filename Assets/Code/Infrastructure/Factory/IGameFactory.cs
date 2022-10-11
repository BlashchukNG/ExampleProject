using System.Collections.Generic;
using Code.Infrastructure.Services;
using Code.Infrastructure.Services.PersistentProgress;
using UnityEngine;

namespace Code.Infrastructure.Factory
{
    public interface IGameFactory : 
        IService
    {
        List<ISavedProgressReader> ProgressReaders { get; }
        List<ISavedProgressWriter> ProgressWriters { get; }
        
        GameObject CreateHero(Vector3 at);
        GameObject CreateHUD();
        void CleanUp();
    }
}