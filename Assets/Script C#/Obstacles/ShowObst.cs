using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShowObst : MonoBehaviour
{
	public int threshold1 = 2;
    public int threshold2 = 6;
    

    void Start()
    {
        // Getting the ScoreManager component from the object in the scene
        ScoreManager scoreManager = Object.FindFirstObjectByType<ScoreManager>();

        if (scoreManager != null)
        {
            // Reading the global score from the ScoreManager
            int score = ScoreManager.globalScore;
            
            if (SceneManager.GetActiveScene().name == "Level_1")
            {
                if (score <= threshold1)
                {
                    Destroy(gameObject);
                }
            }
            else if (SceneManager.GetActiveScene().name == "Level_2")
            {
                if (score >= threshold2)
                {
                    Destroy(gameObject);
                }
            }
            else if (SceneManager.GetActiveScene().name == "Level_3")
            {
                if (score > threshold1)
                {
                    Destroy(gameObject);
                }
            }
        }
        else
        {
            Debug.LogError("ScoreManager not found in the scene!");
        }
    }
}	
    




