using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class lavaControll : MonoBehaviour
{

    private Rigidbody2D rb;
    public GameObject[] allDrops;
    public float[] shootForces;
    public float deleteWait;
    public float respawnWait;
    
    void Start()
    {
        StartCoroutine(Fire());
    }

    private IEnumerator Fire()
    {
        for(int i = 0; i < allDrops.Length; i++)
        {
            GameObject drop = allDrops[i];
            drop.SetActive(true);
            rb = drop.GetComponent<Rigidbody2D>();
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, 1 * shootForces[i]);
        }


        yield return new WaitForSeconds(deleteWait);
        for(int i = 0; i < allDrops.Length; i++)
        {
            GameObject drop = allDrops[i];
            drop.SetActive(false);
        }
        yield return new WaitForSeconds(respawnWait);

        StartCoroutine(Fire());
    }

}


