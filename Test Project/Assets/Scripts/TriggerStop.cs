using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerStop : MonoBehaviour
{
    public bool stop;
    public GameObject canvas;
    public MoveCharacter _speed;

    // Start is called before the first frame update
    void Start()
    {
        
        stop = false;
        canvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        _speed = GameObject.FindGameObjectWithTag("Character").GetComponent<MoveCharacter>();

        if (stop == true)
        {
            canvas.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggered");
        stop = true;
        _speed.speed = 0;
    }
}
