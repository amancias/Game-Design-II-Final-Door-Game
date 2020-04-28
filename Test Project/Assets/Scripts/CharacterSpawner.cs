using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CharacterSpawner : MonoBehaviour
{
    //creates two GameObject character variables that will be assigned later in the SapwnCharacter function 
    public GameObject goodCharacter;
    public GameObject badCharacter;
    private GameObject _character;

    //pulls variable from the ButtonClick class
    public ButtonClick buttonClick;
    public bool isGood;

    //Gets a random true or false boolean that will check if the upcoming character will be good or bad
    public bool GoodOrBad()
    {

        if (Random.value >= 0.5)
        {
            return isGood = true;
        }
        return isGood = false;

    }
    //spawms the character based on what moral compass it lies under 
    private void SpawnCharacter()
    {
        //spawns a good or bad character game object 
        if (isGood == true)
        {
            //instantiates a goodCharacter game object and sets it to the goodCharacter variable
            _character = Instantiate(goodCharacter, transform.position, Quaternion.identity);
            //adds the dialogue script as a component
            _character.AddComponent<GoodDialogue>();
            _character.AddComponent<MoveCharacter>();
        }
        else
        {
            //instantiates a badCharacter game object and sets it to the badCharacter variable
            _character = Instantiate(badCharacter, transform.position, Quaternion.identity);
            //adds in the Dialogue script as a component
            _character.AddComponent<BadDialogue>();
            _character.AddComponent<MoveCharacter>();

        }
    }

    //when yes or no button are clicked, destroy the character game objects, randomize the good or bad boolean,
    //then spawn a new character, and set the buttonClicked boolean back to false
    private void DestroyCharacter()
    {
        if (buttonClick.buttonClicked == true)
        {
            Debug.Log("Destroyed character");
            Destroy(_character);
            GoodOrBad();
            SpawnCharacter();
            buttonClick.buttonClicked = false;
            
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        //calls the functions that decide and spawn the type of character 
        GoodOrBad();
        SpawnCharacter();
       
    }

    // Update is called once per frame
    void Update()
    {
        DestroyCharacter();
    }
}
