using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSpawner : MonoBehaviour
{
    public GameObject goodCharacter = null;
    public GameObject badCharacter = null;
    private bool isGood;

    //Gets a random true or false boolean that will check if the upcoming character will be goor or bad
    public bool GoodOrBad()
    {

        if (Random.value >= 0.5)
        {
            return isGood = true;
        }
        return isGood = false;

    }
    // Start is called before the first frame update
    void Start()
    {
        //calls the random good or bad character function at the beginning of the game
        GoodOrBad();

        //spawns a good or bad character model 
        if (isGood == true)
        {
            Instantiate(goodCharacter, transform.position, Quaternion.identity);
        }
        else
        {
            Instantiate(badCharacter, transform.position, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
