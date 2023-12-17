using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class change_text : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string testoScritta; // Riferimento al componente Text della scritta
    public float typingSpeed = 0.025f;
    public int score;

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
            if (SceneManager.GetActiveScene().name == "ChangeScene12"){
                testoScritta = "Congratulations, you have completed the first level!  Being healthy, free from anxiety or depression, enables you to perceive the world with clarity and without distortion. This is why you started with good visibility that allowed you to complete the level. But stay sharp!, this is just the beginning. We will be putting more and more pressure on you to understand how people with anxiety feel.";
            } else if (SceneManager.GetActiveScene().name == "ChangeScene23"){
                testoScritta = "Congratulations, you have completed the second level! Your game vision, as you could see, made it more difficult to collect coins and pay attention to the obstacles in front of you. In this level you were able to experience the distortion of reality that anxious people experience, so that in the future you can understand them better and help them. In spite of everything you are doing great. Don't give up because you are only a short time away from getting out of the quarry!";
            } else {
                testoScritta = "Congratulations, you completed the game and managed to get out of the quarry despite the pitfalls you were subjected to! Through the game you were able to momentarily experience the feeling of having a distorted view of reality, similar to one that people who suffer from anxiety experience every day. Remember what you learned: a gem in the game makes everything easier and in real life that gem could be you helping anxious people. ";
            }
        }
        else if (score < 6)
        {
            if (SceneManager.GetActiveScene().name == "ChangeScene12"){
                testoScritta = "Congratulations, you have completed the first level! As you have seen the game view is a bit narrow, this reflects how you feel some times. Don't let your guard down!, from now the game will get harder to make you relive what you sometimes feel because of anxiety and help you overcome it. But be careful because during the next level you can find little aids to help you cope better with these difficult moments.";
            } else if (SceneManager.GetActiveScene().name == "ChangeScene23"){
                testoScritta = "Congratulations, you have completed the second level! As you saw things got more complicated, but with little help you managed to get by. The next level will not be easy, as well as those moments where you don't feel your best and this is where you will have to put into action what you have learned so far to overcome the difficulties. Don't give up because it's only a little while before you get out of the quarry!";
            } else {
                testoScritta = "Congratulations, you completed the game and managed to get out of the quarry despite the pitfalls you were subjected to! You were tested and managed to cope in a beautiful way! Every time you overcome moments of anxiety, you strengthen your inner resilience. Remember, you are stronger than you think and capable of facing any challenge life throws your way. ";
            }
        }
        else
        {
            if (SceneManager.GetActiveScene().name == "ChangeScene12"){ 
                testoScritta = "Congratulations, you have completed the first level! Experiencing anxiety or depression leads to a blurred and distorted view of the reality around you. This is why, as you may have noticed, you started out with a dim view that did not allow you to complete the level with ease. Don't worry if you had any difficulties, in the next levels you will be able to find aids that will allow you to overcome the difficulties that appear in front of you.";
            } else if (SceneManager.GetActiveScene().name == "ChangeScene23"){
                testoScritta = "Congratulations, you have completed the second level! Your game vision, as you could see made it easier to collect coins. As you could see it only takes a little to change the way you deal with difficulties, in the game, as in life. Despite everything you are doing great. Don't give up because it's only a short time to get out of the quarry!";
            } else {
                testoScritta = "Congratulations, you have completed the game and managed to get out of the quarry despite the pitfalls you were subjected to!  By getting this far, you have proved to yourself that you are stronger than you think. Every time you overcome moments of anxiety, you strengthen your inner resilience. Remember, you are stronger than you think and you are able to face any challenge that life throws your way.";
            }
        }

        foreach (char letter in testoScritta.ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

}
