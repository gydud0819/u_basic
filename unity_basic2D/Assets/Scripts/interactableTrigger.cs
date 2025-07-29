using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class interactableTrigger : MonoBehaviour
{
   [SerializeField] JumpPlatform jumpPlatform;
    // �̺�Ʈ �浹 �Լ� �����ϱ� ONTriggerEnter2D ����ؼ� 

    private void OnTriggerEnter2D(Collider2D collision)
    {
                 // �̰� �ƤӤ��ѰŰ����� 
        if (collision.CompareTag("Player"))     
        {
            // jumpPlatform�� �մ� PlayTriggerAnimation �Լ� �����ϱ� 
            jumpPlatform.PlayTriggerAnimation("Trigger");
        }
    }

  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
