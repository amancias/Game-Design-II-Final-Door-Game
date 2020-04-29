using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ButtonClick : MonoBehaviour
{
    //creates a variable based on the CountdownTimer class
    public Timer currentTime;
    public bool buttonClicked = false;
    public TriggerStop _canvas;

    public void Start()
    {

    }
    /*When the no buttron is clicked, tells the player to go away, resets the time limit abck to 30 seconds,
    sets the boolean state of buttonClicked to true, which will then be accessed in the CharacterSpawner class function
    within the DestroyCharacter function
    */
    public void GoAway()
    {
        Debug.Log("Go away");
        buttonClicked = true;
        currentTime.timeRemaining = 10f;
        _canvas.canvas.SetActive(false);
    }

    //does the same as the GoAway function but just tells the character to come in
    public void ComeIn()
    {
        Debug.Log("Come in");
        buttonClicked = true;
        currentTime.timeRemaining = 10f;
        _canvas.canvas.SetActive(false);
    }
}
    //both the GoAway and ComeIn function will be accessed from the YES and NO On Click() function
