using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSystem : MonoBehaviour
{

    public GameObject strike1;
    public GameObject strike2;
    public GameObject strike3;

    // Start is called before the first frame update
    void Start()
    {
        strike1.SetActive(false);
        strike2.SetActive(false);
        strike3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
