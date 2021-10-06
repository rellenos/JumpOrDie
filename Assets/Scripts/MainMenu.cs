using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void EsceneGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void SceneMainMenu()
    {
        SceneManager.LoadScene("MainMenuScene");
    }

    public void CharacterSelection()
    {
        SceneManager.LoadScene("CharacterSelector");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
