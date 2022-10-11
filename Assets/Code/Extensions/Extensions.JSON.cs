using UnityEngine;

namespace Code.Extensions
{
    public static partial class Extensions
    {
        public static T FromJson<T>(this string json) => JsonUtility.FromJson<T>(json);
    }
}