﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSpawner : MonoBehaviour
{
    public GameObject goodCharacter;
    public GameObject badCharacter;

    //pulls variable from the ButtonClick class
    public ButtonClick buttonClick;
    private bool isGood;
    //private bool spawned = false;

    //Gets a random true or false boolean that will check if the upcoming character will be good or bad
    private bool GoodOrBad()
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
            goodCharacter = Instantiate(goodCharacter, transform.position, Quaternion.identity);
            
        }
        else
        {
            badCharacter = Instantiate(badCharacter, transform.position, Quaternion.identity);
           
        }
    }

    //when yes or no button are clicked, destroy the character game objects
    private void DestroyCharacter()
    {
        if (buttonClick.buttonClicked == true)
        {
            Debug.Log("Destroyed character");
            GameObject.Destroy(badCharacter);
            GameObject.Destroy(goodCharacter);
            GoodOrBad();
            SpawnCharacter();
            buttonClick.buttonClicked = false;
            
        }
    }
    // Start is called before the first frame update
    void Start()
    {

        //calls the function that decide and spawn the type of character 
        GoodOrBad();
        SpawnCharacter();
       
    }

    // Update is called once per frame
    void Update()
    {
        DestroyCharacter();
    }
}
