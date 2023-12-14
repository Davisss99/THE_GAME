using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class change_text_failed : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string testoScritta; // Riferimento al componente Text della scritta
    public int score = ScoreManager.globalScore;
    public float typingSpeed = 0.025f;

    // Start is called before the first frame update
    private void Start()
    {
        StartCoroutine(Type());
    }

    IEnumerator Type()
    {
                // Controlla il valore della variabile e imposta il testo di conseguenza
        if (score < 3)
        {
            if (SceneManager.GetActiveScene().name == "ChangeScene12Failed"){
                testoScritta = "Mission failed! Even the healthiest players stumble in the game. Your resilience and determination define your victories, both in gaming and in life.Click on the button below to restart.";
            } else if (SceneManager.GetActiveScene().name == "ChangeScene23Failed"){
                testoScritta = "Mission failed! Facing a tough game and falling short doesn’t define your capability. Keep playing; victory awaits those who persist. Click on the button below to restart.";
            } else {
                testoScritta = "Mission failed! Have you seen how difficult it is to play by feeling anxious? Click on the button below to restart.";
            }
        }
        else if (score < 6)
        {
            if (SceneManager.GetActiveScene().name == "ChangeScene12Failed"){
                testoScritta = "Mission failed! Don’t worry, failure in a game is an opportunity to learn and return stronger. Click on the button below to restart.";
            } else if (SceneManager.GetActiveScene().name == "ChangeScene23Failed"){
                testoScritta = "Mission failed! Embrace the challenge and keep calm. Click on the button below to restart. ";
            } else {
                testoScritta = "Mission failed! Facing defeat in a difficult game is not the end, but an opportunity to grow, adapt and overcome the challenges to come. Click on the button below to restart.";
            }
        }
        else
        {
            if (SceneManager.GetActiveScene().name == "ChangeScene12Failed"){ 
                testoScritta = "Mission failed! Don’t worry, failure is not the end, embrace it, learn from it, and level up your game. Click on the button below to restart.";
            } else if (SceneManager.GetActiveScene().name == "ChangeScene23Failed"){
                testoScritta = "Mission failed! Don’t worry, your worth isn't defined by a game. It's okay to stumble; your strength lies in getting back up, both in the game and in life. Click on the button below to restart.";
            } else {
                testoScritta = "Mission failed! Sometimes, the game of life throws us tougher levels. Remember, it's okay to pause, breathe, and restart. Your worth isn't defined by wins or losses in a game; it's in the courage you show while facing each level, both in the game and in life. Click on the button below to restart.";
            }
        }

        foreach (char letter in testoScritta.ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }
}

