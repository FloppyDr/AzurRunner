using System.Collections.Generic;

using UnityEngine;
using UnityEngine.Events;

using Runner.Data;

namespace Runner
{
    public class RoadBuilder : MonoBehaviour
    {
        [SerializeField] private UnityEvent<List<GameObject>> _roadBuilt;
    
        [SerializeField] private RoadData _roadData;
        [SerializeField] private Transform _initPosition;
        [SerializeField] private Transform _parent;

        private readonly List<GameObject> _road = new List<GameObject>();
        private Vector3 _spawnPosition;

        private void Start()
        {
            _road.Clear();
            _spawnPosition = _initPosition.position;
            Build();
        }

        private void Build()
        {
            for (int i = 0; i < _roadData.RoadPrefabs.Length; i++)
            {
                _spawnPosition = new Vector3(_spawnPosition.x,_spawnPosition.y,_initPosition.position.z + i * _roadData.RoadPrefabs[i].transform.localScale.z);
                Debug.Log(_spawnPosition);
                var spawned = Instantiate(_roadData.RoadPrefabs[i], _spawnPosition, Quaternion.identity,_parent);
                _road.Add(spawned);
            }
            _roadBuilt?.Invoke(_road);
        }
    }
}
//подписка на финиш тут??