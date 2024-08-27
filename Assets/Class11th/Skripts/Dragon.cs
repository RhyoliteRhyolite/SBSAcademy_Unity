using UnityEngine;

public class Dragon : MonoBehaviour
{
    [SerializeField] AudioClip audioClip;
    public void Attack()
    {
        SoundManager.instance.Listen(audioClip);
    }
}
