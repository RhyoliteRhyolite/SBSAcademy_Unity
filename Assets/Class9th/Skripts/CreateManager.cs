using System.Collections;
using UnityEngine;

public class CreateManager : MonoBehaviour
{
    [SerializeField] GameObject[] foods;
    [SerializeField] GameObject clone;
    [SerializeField] int count;

    WaitForSeconds waitForSeconds = new WaitForSeconds(3.0f);



    private void Start()
    {
        StartCoroutine(Create());


    }

    IEnumerator Create() //Todo - Fix bug
    {
        while (count < foods.Length)
        {
            if (clone == null)
            {
                clone = Instantiate(foods[count++]);
            }

            yield return waitForSeconds;
        }
    }
}
