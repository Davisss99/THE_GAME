using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class change_text : MonoBehaviour
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
            if (SceneManager.GetActiveScene().name == "ChangeScene12"){
                testoScritta = "Congratulations, you have completed the first level!  Don't relax, this is just the beginning. We will put more and more pressure on you to understand how people with anxiety feel.";
            } else if (SceneManager.GetActiveScene().name == "ChangeScene23"){
                testoScritta = "Congratulations, you have completed the second level! Don't give up because it's only a short time to get out of the cave.";
            } else {
                testoScritta = "Congratulations, you completed the game despite the pitfalls you were subjected to! You have experienced what it is like to be under pressure, think of those who have anxiety every day. Don't forget the lesson you learned today. ";
            }
        }
        else if (score < 6)
        {
            if (SceneManager.GetActiveScene().name == "ChangeScene12"){
                testoScritta = "Congratulations, you have completed the first level! Don't relax too much from now on the game will get tougher...but don't worry, you will get little helps to help you cope with the times when you feel anxiety.";
            } else if (SceneManager.GetActiveScene().name == "ChangeScene23"){
                testoScritta = "Congratulations, you have completed the second level! Don't give up because it's just a little while before you can get out of the quarry.Don't worry if you're struggling because you'll have little helps that will allow you to complete the game.";
            } else {
                testoScritta = "Congratulations, you completed the game! We put you under pressure but you managed to tackle the levels and cope on your own!";
            }
        }
        else
        {
            if (SceneManager.GetActiveScene().name == "ChangeScene12"){ 
                testoScritta = "Congratulations, you have completed the first level! Don't worry if you had any difficulties, in the next levels you will be helped so that you can overcome each difficulty and get out of the cave.";
            } else if (SceneManager.GetActiveScene().name == "ChangeScene23"){
                testoScritta = "Congratulations, you have completed the second level! Don't give up because it's just a short time to get out of the quarry, don't worry if you're in trouble because you'll have little helps that will allow you to complete the game.";
            } else {
                testoScritta = "Congratulations, you completed the game! We put you under pressure but you managed to tackle the levels and cope on your own!";
            }
        }

        foreach (char letter in testoScritta.ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

}
