using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    //A list of names for the characters
    public List<string> badNames = new List<string>();
    public List<string> goodNames = new List<string>();

    void Update()
    {
        void PickName()
        {
            if (Input.GetKeyDown(KeyCode.B))
            {
                //picks a random name from the bad name list outputs it
                string randomBadName = badNames[Random.Range(0, badNames.Count)];
                Debug.Log(randomBadName);
            }
            else if (Input.GetKeyDown(KeyCode.G))
            {
                //picks a random name from the good name list and outputs it
                string randomGoodName = goodNames[Random.Range(0, goodNames.Count)];
                Debug.Log(randomGoodName);
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
}

