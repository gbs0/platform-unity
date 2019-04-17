using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public LayerMask groundLayer;
    Rigidbody2D rb;

    BoxCollider2D groundCheck;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        groundCheck = transform.find("groundCheck").GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
      Vector2 groundCenter = (Vector2)groundCheck.transform.position + groundCheck.offset;
    	groundCollision = Physics2D.OverlapBox(groundCenter, groundCheck.size, float 0, groundLayer);

      if (groundCollision != null) {

      } else { }

      Vector2 mov = rb.velocity;


      // if (Input.GetKey(KeyCode.RightArrow)) {
      //   mov.x = 5;                        
      // } else {
      // 	mov.x = 0;
      // }

      // if (Input.GetKey(KeyCode.LeftArrow)) {
      //   mov.x = -5;  
      // } else {
      // 	mov.x = 0;	
      // }

      mov.x = Input.GetAxis("Horizontal") * 5;
      
      if (Input.GetAxis("Jump") > 0) {
        mov.y = 10;
      } 

      rb.velocity = mov;
    }
}
