﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


/*To Do
 * need to randomize the selction of sentences from their arrays and figure out a way to not reuse them
 * set the Continue Game Object to the variable
 * Destroy the text when going to the next character
 */

public class GoodDialogue : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;

    //sets string array that will hold the sentences for good characters
    //need to put the dialogue in here
    [SerializeField] private string[] goodSentences = { "You look like a guy who would let me in", "Hello" };
    private int index;

    //how fast the letters in the sentences will be typed out
    [SerializeField] private float typingSpeed = .05f;

    public GameObject continueButton;

    public Button comeIn;
    public Button goAway;

    /// <summary>
    /// sets the continue button and text display to the in scene game objects
    /// still need to set the continue button
    /// </summary>
    /// 
    private void Awake()
    {
        comeIn = GetComponent<Button>();
        goAway = GetComponent<Button>();
    }
    private void Start()
    {
        comeIn = GameObject.Find("YES").GetComponent<Button>();
        goAway = GameObject.Find("NO").GetComponent<Button>();

        continueButton = GameObject.FindGameObjectWithTag("Button");

        textDisplay = GameObject.Find("Dialogue Text").GetComponent<TextMeshProUGUI>();
        StartCoroutine(Type());

        comeIn.onClick.AddListener(NextSentence);
        goAway.onClick.AddListener(NextSentence);
    }

    //when the text from the current sentence is fully displayed, the continue button will pop up
    private void Update()
    {
        if (textDisplay.text == goodSentences[index])
        {
            continueButton.SetActive(false);
        }
    }

    IEnumerator Type()
    {
        foreach (char letter in goodSentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    //this will be tied to the continue button 
    //when clicking the conntinue button, moves onto the next sentence in the list
    public void NextSentence()
    {
        continueButton.SetActive(false);
        Debug.Log("Testing NExt Sentence");

        if (index < goodSentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        }
        else
        {
            textDisplay.text = "";
        }
    }

}
