using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHandler : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rigidbody2d;

    [SerializeField] private float moveSpeed = 2.0f;

    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private float groundDistance = 1.2f;

    // Start is called before the first frame update


    private void Awake()
    {
        rigidbody2d.GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        Setup();
        rigidbody2d.velocity = new Vector2(0, 0);
    }

    private void Update()
    {
        Move();
    }
    private void Setup()
    {
        rigidbody2d.freezeRotation = true;
    }

    private void Move()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");


        Vector2 moveVector = new Vector2(horizontal, vertical) * moveSpeed;
        rigidbody2d.velocity = moveVector; 
    }

}
