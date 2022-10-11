using Code.Data;
using Code.Infrastructure.Services;
using Code.Infrastructure.Services.Input;
using Code.Infrastructure.Services.PersistentProgress;
using UnityEngine;

namespace Code.Hero
{
    public sealed class HeroMove :
        MonoBehaviour,
        ISavedProgressReader,
        ISavedProgressWriter
    {
        [SerializeField] private CharacterController _characterController;
        [SerializeField] private float _movementSpeed;

        private Camera _camera;

        private IInputService _inputService;

        private void Awake()
        {
            _inputService = ServiceLocator.Container.Single<IInputService>();
        }

        private void Start()
        {
            _camera = Camera.allCameras[0];
        }

        private void Update()
        {
            var movementVector = Vector3.zero;

            if (_inputService.Axis.sqrMagnitude > Constants.Epsilon)
            {
                movementVector = _camera.transform.TransformDirection(_inputService.Axis);
                movementVector.y = 0;
                movementVector.Normalize();

                transform.forward = movementVector;
            }

            movementVector += Physics.gravity;

            _characterController.Move(_movementSpeed * movementVector * Time.deltaTime);
        }

        public void ReadProgress(PlayerProgress progress)
        {
            transform.position = progress.worldData.playerPosition.AsVector3();
        }

        public void WriteProgress(PlayerProgress progress)
        {
            progress.worldData.playerPosition = transform.position.AsVector3Data();
        }
    }
}