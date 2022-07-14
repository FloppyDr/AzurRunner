using UnityEngine;
using UnityEngine.Events;

namespace Runner.PlayerComponents
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private PlayerInput _input;
        [SerializeField] private UnityEvent<int> _coinsCountChanged;
   
        private int _coinsCount;
        private bool _isAbleToMove;

        private void Start()
        {
            _coinsCountChanged?.Invoke(_coinsCount);
        }

        public void AddCoin()
        {
            _coinsCount++;
            _coinsCountChanged?.Invoke(_coinsCount);
        }

        public void BlockInput()
        {
            _input.Stop();
        }
    }
}
