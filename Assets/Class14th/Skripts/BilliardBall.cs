using UnityEngine;
using UnityEngine.Events;

public class BilliardBall : MonoBehaviour
{
    [SerializeField] UnityEvent callback;

    private void Start()
    {
        if (callback != null)
        {
            callback.Invoke();
        }
    }
}
