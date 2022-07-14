using UnityEngine;

using DG.Tweening;

using Runner.Data;

namespace Runner.Utils.Visualization
{
    public class Rotator : MonoBehaviour
    {
        [SerializeField] private Transform _target;
        [SerializeField] private RotationData _rotationData;

        private Sequence _rotationSequence;

        private void Start()
        {
            SetRotation();
        }

        public void EndRotation()
        {
            _rotationSequence?.Kill();
        }

        private void SetRotation()
        {
            EndRotation();
            
            var rotationLength = _rotationData.Rotation.Length;
            var stepDuration = _rotationData.Duration / rotationLength;

            _rotationSequence = DOTween.Sequence();

            for (var i = 0; i < rotationLength; i++)
            {
                _rotationSequence.Append(_target.DORotate(_rotationData.Rotation[i], stepDuration).SetEase(_rotationData.EaseType));
            }
            
            _rotationSequence.SetLoops(_rotationData.LoopCount, _rotationData.LoopType);
        }

        private void OnDisable()
        {
            EndRotation();
        }
    }
}