using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    //Lists of names for the characters
    public List<string> badNames = new List<string>();
    public List<string> goodNames = new List<string>();

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            PickBadName();
        }
        else if (Input.GetKeyDown(KeyCode.G))
        {
            PickGoodName();
        }
    }

    //picks a random name from the bad name list, sets it into badGoodName and outputs it
    void PickBadName()
    {
        //
        string randomBadName = badNames[Random.Range(0, badNames.Count)];
        Debug.Log(randomBadName);
    }

    //picks a random name from the good name list, sets it into randomGoodNAme and outputs it
    void PickGoodName()
    {
        
        string randomGoodName = goodNames[Random.Range(0, goodNames.Count)];
        Debug.Log(randomGoodName);
    }
}

