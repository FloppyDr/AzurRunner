using UnityEngine;

using DG.Tweening;

namespace Runner.UI
{
    public class UIMover : MonoBehaviour
    {
        [SerializeField] private RectTransform _rectTransform;
        [SerializeField] private Vector2 _hidePosition;
        [SerializeField] private Vector2 _showPosition;
        [SerializeField] private float _moveDuration = 0.5f;
    
        private Sequence _moveSequence;
    
        public void Show()
        {
            Move(_showPosition, _moveDuration);
        }
    
        public void Hide()
        {
            Move(_hidePosition, _moveDuration);
        }

        public void EndMove()
        {
            _moveSequence?.Kill();
        }

        private void Move(Vector2 toPosition, float moveDuration)
        {
            EndMove();

            _moveSequence = DOTween.Sequence()
                .Append(_rectTransform.DOAnchorPos(toPosition, moveDuration));
        }

        private void OnDisable()
        {
            EndMove();
        }
    }
}
