using UnityEngine;

namespace Code.Infrastructure
{
    public sealed class GameRunner :
        MonoBehaviour
    {
        [SerializeField] private GameBootstrapper _bootstrapper;

        private void Awake()
        {
            var bootstrapper = FindObjectOfType<GameBootstrapper>();

            if (bootstrapper == null) Instantiate(_bootstrapper);
        }
    }
}