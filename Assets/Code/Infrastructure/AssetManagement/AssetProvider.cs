using UnityEngine;

namespace Code.Infrastructure.AssetManagement
{
    public sealed class AssetProvider : 
        IAssetProvider
    {
        public GameObject Instantiate(string path) => Object.Instantiate(Resources.Load<GameObject>(path));
        public GameObject Instantiate(string path, Vector3 at) => Object.Instantiate(Resources.Load<GameObject>(path), at, Quaternion.identity);
    }
}