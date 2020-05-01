using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenubutton : MonoBehaviour
{
    public GameObject credits;
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Credits()
    {
        credits.SetActive(true);

    }

    public void CloseCredits()
    {
        credits.SetActive(false);
    }
}