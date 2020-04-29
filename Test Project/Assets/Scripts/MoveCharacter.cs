using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour
{
    public TriggerStop Stop;
    public int speed = 6;
    // Start is called before the first frame update
    void Start()
    {
        Stop = GameObject.Find("Trigger").GetComponent<TriggerStop>();
        Debug.Log("Move the character forward");
    }

    // Update is called once per frame
    void Update()
    {
        MoveCube(); // makes character move

       
    }

    void MoveCube()
    {
        transform.Translate(Vector3.back * speed * Time.deltaTime);
    }
}
