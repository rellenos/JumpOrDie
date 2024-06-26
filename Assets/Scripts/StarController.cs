using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class StarController : MonoBehaviour
{
    private int score;
    public AudioSource coinSound;

    private void Start()
    {
        score = 0;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "star")
        {
            score++;
        }

        Destroy(gameObject);
        
        coinSound.Play();
    }
}