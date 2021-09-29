using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    
    public float speed = 0.1f;
    
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        transform.position = new Vector2(transform.position.x + speed, transform.position.y);
        if (transform.position.x > 1f)
        {
            speed = speed * -1;
        }
        if (transform.position.x < 1f)
        {
            speed = speed * -1;
        }
    }
}
