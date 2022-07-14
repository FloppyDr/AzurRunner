using UnityEngine;
using UnityEngine.Events;

public class PermitedAction : MonoBehaviour
{
    [SerializeField]
    private Filter _filter;

    [SerializeField]
    private UnityEvent _permittedEvent;

    [SerializeField]
    private UnityEvent _notPermittedEvent;

    public void DoAction()
    {
        if (_filter.IsPermitted())
        {
            _permittedEvent?.Invoke();
        }
        else
        {
            _notPermittedEvent?.Invoke();
        }
    }
}
