using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterMove : MonoBehaviour
{
    BuoyancyEffector2D effector;

    private void Awake()
    {
        effector = GetComponent<BuoyancyEffector2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            effector.density = 0;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            effector.density = 2;
        }
    }
}
