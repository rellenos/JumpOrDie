using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float fallDelay = 0.3f;
    public float shakeAmount = 5f;
    bool readyToShake = false;

    Rigidbody2D rb;

    Vector3 originalPos;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(readyToShake)
        {
            Vector3 newPos = originalPos + Random.insideUnitSphere * (Time.deltaTime * shakeAmount);
            newPos.y = transform.position.y;
            newPos.z = transform.position.z;

            transform.position = newPos;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(Falling(fallDelay));
        }
    }

    IEnumerator Falling(float delay)
    {
        originalPos = transform.position;

        yield return new WaitForSeconds(delay);

        readyToShake = true;

        yield return new
        WaitForSeconds(1.0f);

        GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
    }
}
