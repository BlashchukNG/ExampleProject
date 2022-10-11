using System;

namespace Code.Data
{
    [Serializable]
    public sealed class PlayerProgress
    {
        public WorldData worldData;

        public PlayerProgress(string initialLevel)
        {
        }
    }
}