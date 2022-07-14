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
//move to script
        private void Start()
        {
            transform.DORotate(new Vector3(0f, 180f, 0f), 2f).SetEase(Ease.Linear).SetLoops(-1);
        }
    }
}