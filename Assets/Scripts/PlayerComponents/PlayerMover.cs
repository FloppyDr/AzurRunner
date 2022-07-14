using UnityEngine;

namespace Runner.PlayerComponents
{
    public class PlayerMover : MonoBehaviour
    {
        [SerializeField] private float _speed = 10f;
        [SerializeField] private float _minValidPosition;
        [SerializeField] private float _maxValidPosition;
  
        private Rigidbody _rigidbody;

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        public void Move(Vector3 horizontalDirection)
        {
            var offset = (horizontalDirection + Vector3.forward) * _speed * Time.fixedDeltaTime;

            _rigidbody.MovePosition(transform.position + offset);
        
            _rigidbody.position = new Vector3(Mathf.Clamp(_rigidbody.position.x, _minValidPosition, _maxValidPosition), 
                _rigidbody.position.y, _rigidbody.position.z);
        }
    }
}