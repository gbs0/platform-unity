using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;


    Vector2 mov = rb.velocity;

    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<>(Type type);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow)) {
            Transform.Translate(0.1f, 0, 0);                        // Add new translates for x axis
        }

        if (Input.GetKey(KeyCode.LeftArrow)) {
            Transform.Translate(-0.1f, 0, 0);
        }

        if (Input.GetKey(KeyCode.UpArrow)) {
            Transform.Translate(0, 0.1f, 0);
        }

        if (Input.GetKey(KeyCode.DownArrow)) {
            Transform.Translate(0, -0.1f, 0);
        }

    }
}
