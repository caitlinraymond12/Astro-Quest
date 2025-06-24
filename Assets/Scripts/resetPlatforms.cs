using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetPlatforms : MonoBehaviour
{
    public bool reset = false;

    public List<GameObject> platforms;

    // Update is called once per frame
    void Update()
    {
        if(reset)
        {
            for(int i = 0; i < platforms.Count; i++)
            {
                moveDown md = platforms[i].GetComponent<moveDown>();
                md.restart = true;
            }
        }
        reset = false;
    }
}
