using UnityEngine;

namespace Code.Extensions
{
    public static partial class Extensions
    {
        public static string ToJson(this object data) => JsonUtility.ToJson(data, true);
        public static T FromJson<T>(this string json) => JsonUtility.FromJson<T>(json);
    }
}