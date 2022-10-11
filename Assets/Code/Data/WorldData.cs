using System;

namespace Code.Data
{
    [Serializable]
    public sealed class WorldData
    {
        public PositionOnLevel playerPositionOnLevel;

        public WorldData(string initialLevel)
        {
            playerPositionOnLevel = new PositionOnLevel(initialLevel);
        }
    }
}