using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClick : MonoBehaviour
{
    //creates a variable based on the CountdownTimer class
    public CountdownTimer Timer;
    public bool buttonClicked = false;

    /*When the no buttron is clicked, tells the player to go away, resets the time limit abck to 30 seconds,
    sets the boolean state of buttonClicked to true, which will then be accessed in the CharacterSpawner class function
    within the DestroyCharacter function
    */
    public void GoAway()
    {
        Debug.Log("Go away");
        Timer.currentTime = 30f;
        buttonClicked = true;
    }

    //does the same as the GoAway function but just tells the character to come in
    public void ComeIn()
    {
        Debug.Log("Come in");
        Timer.currentTime = 30f;
        buttonClicked = true;
    }
}
    //both the GoAway and ComeIn function will be accessed from the YES and NO On Click() function
