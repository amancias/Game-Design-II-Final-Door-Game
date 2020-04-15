using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClick : MonoBehaviour
{
    public CountdownTimer Timer;
    public bool buttonClicked = false;
    public void GoAway()
    {
        Debug.Log("Go away");
        Timer.currentTime = 30f;
        buttonClicked = true;
    }

    public void ComeIn()
    {
        Debug.Log("Come in");
        Timer.currentTime = 30f;
        buttonClicked = true;
    }
}

