using UnityEngine;

public class CreateManager : MonoBehaviour
{
    [SerializeField] GameObject food;
    [SerializeField] GameObject clone;
    [SerializeField] float time;

    void Update()
    {
        time += Time.deltaTime;
        if (time >= 3.0f)
        {
            clone = Instantiate(food);
            time = 0.0f;
        }
    }
}
