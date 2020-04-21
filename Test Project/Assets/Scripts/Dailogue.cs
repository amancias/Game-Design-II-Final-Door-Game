using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


/*To Do
 * need to randomize the selction of sentences from their arrays and figure out a way to not reuse them
 * set the Continue Game Object to the variable
 */

public class Dailogue : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;

    //sets two string arrays that will hold the sentences for good and bad characters
    //need to put the dialogue in here
    public string[] badSentences = {"string", "test", "discord"};
    public string[] goodSentences = {"poop", "this", "is a joke"};

    private int index;
    private CharacterSpawner _isGood;

    //how fast the letters in the sentences get typed out 
    public float typingSpeed = .05f;

    public GameObject continueButton;

    private void Start()
    {
        //(still need to figure out how to put the continue button into the dialogue script)
        //continueButton = GameObject.;

        //sets the dialogue text scene object text component into the textDisplay variable
        textDisplay = GameObject.Find("Dialogue Text").GetComponent<TextMeshProUGUI>();
        StartCoroutine(BadType());
        StartCoroutine(GoodType());
    }

    //if the character is good, display and type the sentence. Call the continue function NextGoodSentence
    private void Update()
    {
        switch (_isGood.isGood)
        {
            case true:
                Debug.Log("Outputting good sentence");
                OutputGoodSentence();
                NextSentence();
                break;
            default:
                Debug.Log("outputting bad sentence");
                OutputBadSentence();
                NextSentence();
                break;
        }
    }

    private void OutputBadSentence()
    {
        if (textDisplay.text == badSentences[index])
        {
            continueButton.SetActive(true);
        }
    }
    IEnumerator BadType()
    {
        foreach (char letter in badSentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    private void OutputGoodSentence()
    {
        if (textDisplay.text == goodSentences[index])
        {
            continueButton.SetActive(true);
        }
    }
    IEnumerator GoodType()
    {
        foreach (char letter in goodSentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    private void NextGoodSentence()
    {
        if (index < badSentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(BadType());
        }
        else
        {
            textDisplay.text = "";
        }
    }

    private void NextBadSentence()
    {
        if (index < badSentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(GoodType());
        }
        else
        {
            textDisplay.text = "";
        }
    }

    public void NextSentence()
    {
        continueButton.SetActive(false);

        if (_isGood.isGood == true)
        {
            NextGoodSentence();
        }
        else
        {
            NextBadSentence();
        }
    }
}
