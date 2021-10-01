using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{

    public int lives;
    public Image heart3;
    public Image heart2;
    public Image heart1;
    public Image gameOverBox;

    

    public void Restart()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void LoseLive()
    {
        lives--;
        if (lives == 2)
        {
            heart1.enabled = false;
        }
        if (lives == 1)
        {
            heart2.enabled = false;
        }
        if (lives == 0)
        {
            heart3.enabled = false;
            //gameOverbox.enabled = true;
        }

    }

}
