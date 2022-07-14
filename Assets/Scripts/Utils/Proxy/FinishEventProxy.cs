using System.Collections.Generic;

using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.Events;

namespace Runner.Utils.Proxy
{
    public class FinishEventProxy : MonoBehaviour
    {
        [SerializeField] private UnityEvent _finishReached;
    
        public void SubscribeToFinishEvent(List<GameObject> road)
        {
            var finishRoad = road[road.Count - 1].GetComponent<Finish>();
            Assert.IsFalse(finishRoad == null);
       
            finishRoad._finishReached.AddListener(DispatchEvent);
        }

        private void DispatchEvent()
        {
            _finishReached?.Invoke();
        }
    }
}
