using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float timeRemaining;
    public const float timeMax = 10f;
    public Slider slider;

    private void Start()
    {
        timeRemaining = timeMax;
    }
    private void Update()
    {
       
        slider.value = CalculateSliderValue();

        if (timeRemaining <= 0)
        {
            timeRemaining = 0;
            SceneManager.LoadScene(2);

        }
        else if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            
        }
       
    }

    float CalculateSliderValue()
    {
        return (timeRemaining / timeMax);
    }
}
