using UnityEngine;

public class autoMove : MonoBehaviour
{

    public float dist;
    public float max;
    public float min;
    public bool right;

    void FixedUpdate()
    {

        if(right)
        {
            if(transform.position.x < max)
                transform.position += new Vector3(dist, 0, 0);
            else
                right = false;
        }
        else
        {
            if(transform.position.x > min)
                transform.position -= new Vector3(dist, 0, 0);
            else
                right = true;
        }
    }
}
