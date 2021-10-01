using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mage : MonoBehaviour
{

    public bool canJump;
    public float jumpForce = 10f;

    private float horizontal;
    private int costat;
    private Animator anim;
    private Rigidbody2D body;

    void Start()
    {
        costat = 1;
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKey("a"))
        {
            costat = -1;
            anim.SetBool("walk", true);
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-800f * Time.deltaTime, 0));
        }

        else if (Input.GetKey("d"))
        {
            costat = 1;            
            anim.SetBool("walk", true);
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(800f * Time.deltaTime, 0));
        }

        else
        {
            body.velocity = new Vector2(0, body.velocity.y);
            anim.SetBool("walk", false);
        }
        transform.localScale = new Vector3(costat, 1, 1);

        if (Input.GetKeyDown("space") && canJump)
        {
            canJump = false;
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 400f));
            anim.SetBool("jump", true);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "ground")
        {
            canJump = true;
            anim.SetBool("jump", false);
        }
    }
}

