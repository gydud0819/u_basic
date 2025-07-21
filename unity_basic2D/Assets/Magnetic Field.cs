using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MagneticField : MonoBehaviour
{
    public bool isSafe;

    public GameObject player;

    public float currentSize = 40f;
    public float speed = 1f;

    private void Update()
    {
        currentSize -= Time.deltaTime;
        if (currentSize <= 1)
        {
            currentSize = 1;
        }
        transform.localScale = Vector3.one * currentSize;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            isSafe = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            isSafe = false;
            Destroy(player);
        }
    }
}
   
