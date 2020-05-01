using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountdownTimer : MonoBehaviour
{
    public float currentTime = 0f;
    public float startTime = 30f;

    public Text CountDownText;
    void Start()
    {
        currentTime = startTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentTime > 0)
        {
            currentTime -= 1 * Time.deltaTime;
            print(currentTime); //will not work without this line
            CountDownText.text = currentTime.ToString("0");
        }

        if (currentTime <= 0)
        { 

        }
    }
}
