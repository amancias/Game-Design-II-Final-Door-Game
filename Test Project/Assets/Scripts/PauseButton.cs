using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseButton : MonoBehaviour
{

    public GameObject pauseMenu;
    public GameObject dialogueCanvas;
    public GameObject mainCanvas;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PauseMenu()
    {
        Time.timeScale = 0;
        AudioListener.pause = true;
        pauseMenu.SetActive(true);
        dialogueCanvas.SetActive(false);
        mainCanvas.SetActive(false);
    }

    public void CloseMenu()
    {
        Time.timeScale = 1;
        AudioListener.pause = false;
        pauseMenu.SetActive(false);
        dialogueCanvas.SetActive(true);
        mainCanvas.SetActive(true);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Restart()
    {
        SceneManager.LoadScene(1);
    }
}
