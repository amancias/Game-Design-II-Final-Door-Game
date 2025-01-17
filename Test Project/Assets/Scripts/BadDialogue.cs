﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


/*To Do
 * need to randomize the selction of sentences from their arrays and figure out a way to not reuse them (HP)
 */

public class BadDialogue : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;

    //sets string array that will hold the sentences for bad characters
    //need to put the dialogue in here
    public DialogueManager _sentence;
    private int index;

    //how fast the letters in the sentences will be typed out
    private float typingSpeed = .01f;

    //public GameObject continueButton;

    public Button _comeIn;
    public Button _goAway;

    public TriggerStop _stop;

    /// <summary>
    /// sets the continue button and text display to the in scene game objects
    /// still need to set the continue button
    /// </summary>
    /// 
    private void Awake()
    {
        _comeIn = GetComponent<Button>();
        _goAway = GetComponent<Button>();
       
    }
    private void Start()
    {
        _stop = GameObject.Find("Trigger").GetComponent<TriggerStop>();
        /*_comeIn = GameObject.Find("YES").GetComponent<Button>();
        _goAway = GameObject.Find("NO").GetComponent<Button>();
        _sentence = GameObject.Find("DialogueManager").GetComponent<DialogueManager>();

        //continueButton = GameObject.FindGameObjectWithTag("Button");

        textDisplay = GameObject.Find("Dialogue Text").GetComponent<TextMeshProUGUI>();
        StartCoroutine(Type());

        _comeIn.onClick.AddListener(NextSentence);
        _goAway.onClick.AddListener(NextSentence);*/
    }

    //when the text from the current sentence is fully displayed, the continue button will pop up
    private void Update()
    {
        /*if (textDisplay.text == badSentences[index])
        {
            continueButton.SetActive(false);
        }*/

        if (_stop.stop == true)
        {
            _comeIn = GameObject.Find("Yes").GetComponent<Button>();
            _goAway = GameObject.Find("No").GetComponent<Button>();
            _sentence = GameObject.Find("DialogueManager").GetComponent<DialogueManager>();

            //continueButton = GameObject.FindGameObjectWithTag("Button");

            textDisplay = GameObject.Find("Dialogue Text").GetComponent<TextMeshProUGUI>();
            StartCoroutine(Type());

            _comeIn.onClick.AddListener(NextSentence);
            _goAway.onClick.AddListener(NextSentence);

            //sets the stop variable in triggerstop back to false.
            _stop.stop = false;
        }
    }

    IEnumerator Type()
    {
        foreach (char letter in _sentence.sentence.ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    //this will be tied to the continue button 
    //when clicking the conntinue button, moves onto the next sentence in the list
    public void NextSentence()
    {
        //continueButton.SetActive(false);
        Debug.Log("Testing NExt Sentence");

        if (index < _sentence.sentence.Length - 1)
        {
            index++;
            textDisplay.text = "";
            //StartCoroutine(Type());
        }
        else
        {
            textDisplay.text = "";
        }
    }
    
}
