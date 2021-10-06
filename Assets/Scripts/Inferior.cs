using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inferior : MonoBehaviour
{
    public int damage = 100;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Mage>().TakeDamage(damage);
        }
    }
}
