using UnityEngine;

namespace Code.Extensions
{
    public static partial class Extensions
    {
        public static void Enable(this CharacterController component) => component.enabled = true;
        public static void Disable(this CharacterController component) => component.enabled = false;
    }
}