using UnityEngine;

namespace Runner.Utils
{
    public class CameraFollow : MonoBehaviour
    {
        [SerializeField] private Transform _target;
        [SerializeField] private Camera _camera;
        [SerializeField] private float _horizontalFollowSpeed = 1f;

        private float _deltaZ;

        private void Awake()
        {
            _deltaZ = transform.position.z - _target.position.z;
        }

        private void FixedUpdate()
        {
            var currentCameraPosition = _camera.transform.position;
        
            var horizontalOffset = (_target.transform.position.x - currentCameraPosition.x) * Time.deltaTime * _horizontalFollowSpeed;
        
            var newCameraPosition = new Vector3(currentCameraPosition.x + horizontalOffset, currentCameraPosition.y, _target.position.z + _deltaZ);
        
            _camera.transform.position = newCameraPosition;
        }
    }
}