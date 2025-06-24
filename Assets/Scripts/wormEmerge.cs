using UnityEngine;
using System.Collections;

public class wormEmerge : MonoBehaviour
{
    public float startPos;
    public float endPos;
    public float visible;
    public float interval;
    public float speed;
    public float distance;
    public bool up;

    void Start()
    {
        if(up)
            StartCoroutine(emerge());
        else
            StartCoroutine(down());
    }

    private IEnumerator emerge()
    {
        if(transform.position.y < endPos)
        {
            transform.position += new Vector3(0, distance, 0);
            yield return new WaitForSeconds(speed);
            StartCoroutine(emerge());
        }
        else
        {
            yield return new WaitForSeconds(visible);
            StartCoroutine(down());
        }
    }

    private IEnumerator down()
    {
        if(transform.position.y > startPos)
        {
            transform.position -= new Vector3(0, distance, 0);
            yield return new WaitForSeconds(speed);
            StartCoroutine(down());
        }
        else
        {
            yield return new WaitForSeconds(interval);
            StartCoroutine(emerge());
        }
    }

}






  