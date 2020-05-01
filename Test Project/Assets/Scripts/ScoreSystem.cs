using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSystem : MonoBehaviour
{ 

    public GameObject strike1;
    public GameObject strike2;
    public GameObject strike3;
    public AudioSource wrongBuzz;

    private int strikes = 0;
    private int letIn = 0;
    public CharacterSpawner good;
    public ButtonClick _comeIn;
    public GameObject gameOverCanvas;
    public GameObject winCanvas;

    private void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        switch (strikes)
        {
            case 1:
                strike1.SetActive(true);
                break;
            case 2:
                strike2.SetActive(true);
                break;
            case 3:
                strike3.SetActive(true);
                gameOverCanvas.SetActive(true);
                Time.timeScale = 0;
                break;
            default:
                strike1.SetActive(false);
                strike2.SetActive(false);
                strike3.SetActive(false);
                break;
               
        }

        if (letIn == 10)
        {
            winCanvas.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void WrongChoice()
    {
        if ((good.isGood == true && _comeIn.comeIn == false) || (good.isGood == false && _comeIn.comeIn == true))
        {
            strikes++;
            wrongBuzz.Play();
        }
        else
        {
            letIn++;
        }

    }

}
