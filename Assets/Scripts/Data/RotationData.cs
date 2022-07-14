using UnityEngine;

using DG.Tweening;

namespace Runner.Data
{
    [CreateAssetMenu(fileName = "RotationData", menuName = "Runner/RotationData")]
    public class RotationData : ScriptableObject
    {
        public Vector3[] Rotation => _rotation;
        public float Duration => _duration;
        public Ease EaseType => _easeType;
        public int LoopCount => _loopCount;
        public LoopType LoopType => loopType;

        [SerializeField] private Vector3[] _rotation;
        [SerializeField, Min(0f)] private float _duration;
        [SerializeField] private Ease _easeType;
        [SerializeField] private int _loopCount;
        [SerializeField] private LoopType loopType;
    }
}