using UnityEngine;

public class AnimatorStateChanger : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private string _parameterName;

    public void SetState(bool condition)
    {
        _animator.SetBool(_parameterName, condition);
    }
}