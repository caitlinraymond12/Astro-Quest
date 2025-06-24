using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autoDrop : MonoBehaviour
{
    public GameObject[] positions;
    public float wait;
    public GameObject spike;

    void Start()
    {
        StartCoroutine(drop());
    }

    private IEnumerator drop()
    {
        for(int i = 0; i < positions.Length; i++)
        {
            GameObject pos = positions[i];
            Instantiate(spike, pos.transform.position, pos.transform.rotation);
        }
        
        yield return new WaitForSeconds(wait);
        StartCoroutine(drop());

    }
}
