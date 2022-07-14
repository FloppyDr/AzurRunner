using UnityEngine;

public class Filter : MonoBehaviour
{
    [SerializeField] private bool _permissionState = true;

    public bool IsPermitted()
    {
        return _permissionState;
    }

    public void SetState(bool state)
    {
        _permissionState = state;
    }
}