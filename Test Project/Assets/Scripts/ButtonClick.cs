using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClick : MonoBehaviour
{
    public CountdownTimer Timer;
    public void goAway()
    {
        Debug.Log("Go away");
        Timer.currentTime = 30f;
    }

    public void comeIn()
    {
        Debug.Log("Come in");
        Timer.currentTime = 30f;
    }
}

