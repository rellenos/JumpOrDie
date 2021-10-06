using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickController : MonoBehaviour
{
    
    private float horizontalMove = 0f;
    private float verticalMove = 0f;

    public Joystick joystick;

    public float runSpeedHorizontal = 2;
    public float runSpeed = 1.25f;

    public bool canJump;
    public float jumpForce = 10f;
    public int hp = 100;
    public AudioSource deathSound;

    private float horizontal;
    private int costat;
    private Animator anim;
    private Rigidbody2D body;
    private int startHp;

    public float HpPercent
    {
        get {return (float) hp / startHp;}
    }

    void Start()
    {
        costat = 1;
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        startHp = hp;
    }

    void FixedUpdate()
    {
        horizontalMove = joystick.Horizontal * runSpeedHorizontal;
        transform.position += new Vector3 (horizontalMove, 0, 0) * Time.deltaTime * runSpeed;
    }
    
    void Update()
    {
        if (hp <= 0) return;
        
        if (horizontalMove>0)
        {
            costat = 1;
            anim.SetBool("walk", true);
        }

        else if (horizontalMove<0)
        {
            costat = -1;            
            anim.SetBool("walk", true);
        }

        else
        {
            anim.SetBool("walk", false);
        }
        transform.localScale = new Vector3(costat, 1, 1);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "ground")
        {
            canJump = true;
            anim.SetBool("jump", false);
        }

        if(collision.collider.tag == "chest")
        {
            Win.show ();
        }
    }

    public void TakeDamage(int damage)
    {
        if (hp <= 0) return;

        hp -= damage;

        if(hp <= 0)
        {
            GameOver.show ();
        }
    }

    public void Jump()
    {
        if (canJump)
        {
            canJump = false;
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 400f));
            anim.SetBool("jump", true);
        }
    }

}
