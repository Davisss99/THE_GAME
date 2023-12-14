using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ScoreManager : MonoBehaviour
{
    public static int globalScore = 0; // Questa è la variabile globale del punteggio
    public  int globalScore_2 = 0;

    public void OnButtonClick(string input)
    {
        
        if (input.Contains("NotAtAll"))
        {
            globalScore += 0;
        }
        else if (input.Contains("SeveralDays"))
        { 
            globalScore += 1;
        }
        else if (input.Contains("MoreThenHalfTheDays"))
        {
            globalScore += 2;
        }
        else if (input.Contains("NearlyEveryDay"))
        {
            globalScore += 3;
        }

        globalScore_2 = globalScore;
        
        
        //SceneManager.LoadScene(input.Split(" ")[1]); //this code splits the string at the space and returns the scene name
        if (SceneManager.GetActiveScene().name == "Quest1"){
            SceneManager.LoadScene("Quest2");
        }
        else if (SceneManager.GetActiveScene().name == "Quest2"){
            SceneManager.LoadScene("Quest3");
        }
        else if (SceneManager.GetActiveScene().name == "Quest3"){
            SceneManager.LoadScene("Quest4");
        }
        else if (SceneManager.GetActiveScene().name == "Quest4"){
            SceneManager.LoadScene("AYR");
        }
    }
}


