using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class BombController : MonoBehaviour
{
    private Animator anim;
    public int damage = 25;
    public AudioSource explodeSound;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag== "Player")
        {
            anim.SetTrigger("explosion");
            StartCoroutine("Destroy");
        }

        if(collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Mage>().TakeDamage(damage);
        }

        explodeSound.Play();
    }

    private IEnumerator Destroy()
    {
        yield return new WaitForSeconds(0.4f);
        Destroy(gameObject);
    }
}
