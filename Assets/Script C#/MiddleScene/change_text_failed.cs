using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class change_text_failed : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string testoScritta; // Riferimento al componente Text della scritta
    public int score;
    public float typingSpeed = 0.025f;

    // Start is called before the first frame update
    private void Start()
    {
		ScoreManager scoreManager = Object.FindFirstObjectByType<ScoreManager>();
        score = ScoreManager.globalScore;
        StartCoroutine(Type());
    }

    IEnumerator Type()
    {
                // Controlla il valore della variabile e imposta il testo di conseguenza
        if (score < 3)
        {
            if (SceneManager.GetActiveScene().name == "ChangeScene12Failed"){
                testoScritta = "Mission failed! Even the most skilled players stumble through the game. Your resilience and determination define your victories, both in the game and in life. Click the button below to begin again.";
            } else if (SceneManager.GetActiveScene().name == "ChangeScene23Failed"){
                testoScritta = "Mission failed! We wanted to make the game difficult for you, but this failure does not define your capabilities. Keep playing; victory awaits those who persist. Click on the button below to start again.";
            } else {
                testoScritta = "Mission failed! Have you seen how difficult it is to play while experiencing anxiety? Failure in a mission can become an opportunity to better understanding and supporting those who struggle with anxiety in real life. Click the button below to start again.";
            }
        }
        else if (score < 6)
        {
            if (SceneManager.GetActiveScene().name == "ChangeScene12Failed"){
                testoScritta = "Mission failed! Don't worry, failure in a game is an opportunity to better learn how to react in dark time in your life and come back stronger. Click the button below to start over.";
            } else if (SceneManager.GetActiveScene().name == "ChangeScene23Failed"){
                testoScritta = "Mission failed! Embrace the challenge and keep your cool. Don't worry if you didn't succeed, we are testing you so that you can find the right way and strength to confront difficult moments. Click on the button below to start again.";
            } else {
                testoScritta = "Mission failed! Facing defeat in a difficult game, as well as in life, is not the end. it is an opportunity to grow, adapt and overcome future challenges. Click the button below to begin again.";
            }
        }
        else
        {
            if (SceneManager.GetActiveScene().name == "ChangeScene12Failed"){ 
                testoScritta = "Mission failed! Don't worry, failure is not the end, embrace it, learn from it and improve your control . Click the button below to start again.";
            } else if (SceneManager.GetActiveScene().name == "ChangeScene23Failed"){
                testoScritta = "Mission failed! Don't worry, your value is not defined by a game. It's okay to stumble. Your strength lies in getting back up, both in the game and in life. Click the button below to start again.";
            } else {
                testoScritta = "Mission failed! the game has confronted you with a more difficult level, just as in life there are more complicated moments to overcome. Remember, it is normal to pause, breathe and start again. Your worth is not defined by wins or losses in a game. Click on the button below to start over.";
            }
        }

        foreach (char letter in testoScritta.ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }
}

