using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{

    public GameObject GameOverText;
    public static GameObject GamerOverStatic;

    void Start()
    {
        GameOver.GamerOverStatic = GameOverText;
        GameOver.GamerOverStatic.gameObject.SetActive (false);
    }

    void Update()
    {
        
    }

    public static void show()
    {
        GameOver.GamerOverStatic.gameObject.SetActive (true);
    }
}
