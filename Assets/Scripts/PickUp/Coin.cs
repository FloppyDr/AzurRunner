using UnityEngine;
using UnityEngine.Events;

using DG.Tweening;

using Runner.PlayerComponents;

namespace Runner.PickUp
{
    public class Coin : MonoBehaviour
    {
        [SerializeField] private UnityEvent _collected;
        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out Player player))
            {
                player.AddCoin();
                _collected?.Invoke();
            }
        }
    }
}