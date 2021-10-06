using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{

    public GameObject winText;
    public static GameObject winStatic;

    void Start()
    {
        Win.winStatic = winText;
        Win.winStatic.gameObject.SetActive (false);
    }

    public static void show()
    {
        Win.winStatic.gameObject.SetActive (true);
    }
}