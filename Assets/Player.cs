using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

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
      mov.y = Input.GetAxis("Vertical") * 5; 

      rb.velocity = mov;
    }
}
