using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Move the character forward");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.back * Time.deltaTime * 6f;
    }

  
}
