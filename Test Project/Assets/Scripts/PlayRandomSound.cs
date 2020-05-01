using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayRandomSound : MonoBehaviour
{

    public AudioSource yesSound;
    public AudioSource noSound;

    public AudioClip[] yesClipArray;
    public AudioClip[] noClipArray;

    private void Awake()
    {
        yesSound = GetComponent<AudioSource>();
        noSound = GetComponent<AudioSource>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        
    }

    public void ComeInSound()
    {
        yesSound.clip = yesClipArray[Random.Range(0, yesClipArray.Length)];
        yesSound.PlayOneShot(yesSound.clip);
    }

    public void GoAwaySound()
    {
        noSound.clip = noClipArray[Random.Range(0, noClipArray.Length)];
        noSound.PlayOneShot(noSound.clip);
    }
}
