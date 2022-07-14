using UnityEngine;
using UnityEngine.Events;

using Runner.PlayerComponents;

namespace Runner.Utils
{
    public class Finish : MonoBehaviour
    {
        [SerializeField] public UnityEvent _finishReached;

        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out Player player))
            {
                player.BlockInput();
                _finishReached?.Invoke();
            }
        }
    }
}