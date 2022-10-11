using UnityEngine;

namespace Code.Data
{
    public static class DataExtensions
    {
        public static Vector3Data AsVector3Data(this Vector3 vector) => new Vector3Data(vector.x, vector.y, vector.z);
        public static Vector3 AsVector3(this Vector3Data vector) => new Vector3(vector.x, vector.y, vector.z);
    }
}