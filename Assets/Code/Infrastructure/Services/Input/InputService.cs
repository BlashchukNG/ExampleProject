using UnityEngine;

namespace Code.Infrastructure.Services.Input
{
    public sealed class InputService :
        IInputService
    {
        private const string Horizontal = "Horizontal";
        private const string Vertical = "Vertical";
        private const string Button = "Fire";

        public Vector2 Axis
        {
            get
            {
                var axis = SimpleInputAxis();
                if (axis == Vector2.zero)
                    axis = UnityAxis();

                return axis;
            }
        }

        private Vector2 UnityAxis() => new(UnityEngine.Input.GetAxis(Horizontal), UnityEngine.Input.GetAxis(Vertical));

        private Vector2 SimpleInputAxis() => new(SimpleInput.GetAxis(Horizontal), SimpleInput.GetAxis(Vertical));

        public bool IsAttackButtonUp() => SimpleInput.GetButtonUp(Button);
    }
}