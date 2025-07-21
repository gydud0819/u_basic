using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private BoxCollider2D boxCollider2D;
    [SerializeField] private Rigidbody2D rigidbody2D;

    [SerializeField] private float moveSpeed = 5.0f;
    private Vector2 moveVector;

    // Start is called before the first frame update
    private void Start()
    {
        //boxCollider2D.size = new Vector2(1, 1);
       // boxCollider2D.enabled = false;
        rigidbody2D.velocity = moveVector.normalized;
    }

    // Update is called once per frame
    private void Update()
    {
        // w키를 입력했으면 x=0, y=1 moveVector가 되어라
        // a키를 입력했으면 x=-1, y=0 moveVector가 되어라

        if(Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            moveVector = new Vector2(0, 1);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            moveVector = new Vector2(-1, 0);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            moveVector = new Vector2(0, -1);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            moveVector = new Vector2(1, 0);

        }

        rigidbody2D.velocity = moveVector * moveSpeed;
    }
}
