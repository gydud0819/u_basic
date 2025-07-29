using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class interactableTrigger : MonoBehaviour
{
   [SerializeField] JumpPlatform jumpPlatform;
    // 이벤트 충돌 함수 실행하기 ONTriggerEnter2D 사용해서 

    private void OnTriggerEnter2D(Collider2D collision)
    {
                 // 이게 아ㅣㄴ닌거같은데 
        if (collision.CompareTag("Player"))     
        {
            // jumpPlatform에 잇는 PlayTriggerAnimation 함수 실행하기 
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
