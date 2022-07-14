using UnityEngine;
using UnityEngine.Events;

namespace Runner.PlayerComponents
{
    public class PlayerInput : MonoBehaviour
    {
        [SerializeField] private UnityEvent<Vector3> _mouseButtonHold;
        [SerializeField] private UnityEvent _mouseButtonReleased;
    
        private Camera _camera;
        private Vector3 _startTouchPos;
        private Vector3 _direction;

        private bool _canReadInput = true;
    
        private void Start()
        {
            _camera = Camera.main;
        }

        private void Update()
        {
            if (_canReadInput)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    _startTouchPos = _camera.ScreenToViewportPoint(Input.mousePosition);
                }

                if (Input.GetMouseButton(0))
                {
                    _direction = _camera.ScreenToViewportPoint(Input.mousePosition) - _startTouchPos;
                    _mouseButtonHold?.Invoke(new Vector3(_direction.x, 0, 0));
                }

                if (Input.GetMouseButtonUp(0))
                {
                    _direction = Vector3.zero;
                    _mouseButtonReleased?.Invoke();
                }
            }
        }


        public void Stop()
        {
            _direction = Vector3.zero;
            _mouseButtonReleased?.Invoke();
            _canReadInput = false;
        }

        public void ChangeInputState(bool state)
        {
            _canReadInput = state;
        }
    }
}