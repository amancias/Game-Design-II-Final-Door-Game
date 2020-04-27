using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    //Lists of names for the characters
    public List<string> badNames = new List<string>();
    public List<string> goodNames = new List<string>();

    //lists of sentences for each type of characters
    public List<string> goodSentences = new List<string>(); 
    public List<string> badSentences = new List<string>();

    public string sentence;
    public CharacterSpawner _isgood;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    void Update()
    {
        if (_isgood.isGood == false)
        {
            Debug.Log("false");
            PickBadName();
        }
        else if (_isgood.isGood == true)
        {
            Debug.Log("true");
            PickGoodName();
        }
    }

    //picks a random name from the bad name list, sets it into badGoodName and outputs it
    public void PickBadName()
    {
        //
        string randomBadName = badNames[Random.Range(0, badNames.Count)];
        Debug.Log(randomBadName);
        GrabAndRemoveBad();
    }

    //picks a random name from the good name list, sets it into randomGoodNAme and outputs it
    public void PickGoodName()
    {
        
        string randomGoodName = goodNames[Random.Range(0, goodNames.Count)];
        Debug.Log(randomGoodName);
        GrabAndRemoveGood();
    }

    //functions that grab a good or bad sentence. Called in the Update function 
    //still need to find a way to delete the grabs
    public void GrabAndRemoveBad()
    { 
        sentence = badSentences[Random.Range(0, badSentences.Count)];
        Debug.Log(sentence);
        
    }

    public void GrabAndRemoveGood()
    {
        sentence = goodSentences[Random.Range(0, goodSentences.Count)];
        Debug.Log(sentence);
    }
}

