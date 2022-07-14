using UnityEngine;

namespace Runner.Data
{
   [CreateAssetMenu(fileName = "LevelData", menuName = "Runner/RoadData")]
   public class RoadData : ScriptableObject
   {
      public GameObject[] RoadPrefabs => _roadPrefabs;

      [SerializeField] private GameObject[] _roadPrefabs;
   }
}
