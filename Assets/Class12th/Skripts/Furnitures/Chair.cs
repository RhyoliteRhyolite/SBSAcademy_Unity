using UnityEngine;

public class Chair : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        Debug.Log("It's the Chair :)");
    }
}