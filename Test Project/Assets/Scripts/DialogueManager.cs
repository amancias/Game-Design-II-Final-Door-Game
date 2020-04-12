using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    //A list of names for the characters
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

    void PickBadName()
    {
        //picks a random name from the bad name list outputs it
        string randomBadName = badNames[Random.Range(0, badNames.Count)];
        Debug.Log(randomBadName);
    }

    void PickGoodName()
    {
        //picks a random name from the good name list and outputs it
        string randomGoodName = goodNames[Random.Range(0, goodNames.Count)];
        Debug.Log(randomGoodName);
    }
}

