﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float timeRemaining;
    public const float timeMax = 10f;
    public Slider slider;
    public bool destroy = false;
    public CharacterSpawner _destroy;
    public ScoreSystem _strikes;
    public GoodDialogue _nextSentence;

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
            destroy = true;

            if (destroy == true)
            {
                _destroy._DestroyCharacter();
                _strikes.strikes++;
                destroy = false;
                timeRemaining = timeMax;
            }


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
