using System;

namespace Code.Data
{
    [Serializable]
    public sealed class PositionOnLevel
    {
        public string level;
        public Vector3Data playerPosition;

        public PositionOnLevel(string level, Vector3Data playerPosition)
        {
            this.level = level;
            this.playerPosition = playerPosition;
        }
    }
}