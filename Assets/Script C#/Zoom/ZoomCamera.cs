using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ZoomCamera : MonoBehaviour
{   
    public bool zoomOut=false;
    public float low=3.5f;
    public float medium= 2.5f;
    public float high=1.5f;
    public float zoomValue=2.5f;
    public int threshold1 = 2;
    public int threshold2 = 6;

    // Start is called before the first frame update
    void Start()
    {
        ScoreManager scoreManager = Object.FindFirstObjectByType<ScoreManager>();
        
        Camera camera = GetComponent<Camera>();
        
        if (scoreManager != null)
        {
            // Reading the global score from the ScoreManager
            int score = ScoreManager.globalScore;
            
            if (SceneManager.GetActiveScene().name == "Level_1")
            {
                if (score <= threshold1)
                {
                    camera.orthographicSize = low;
                }
                else if (score > threshold1 && score < threshold2)
                {
                    camera.orthographicSize = medium;
                }
                else 
                {
                    camera.orthographicSize = high;
                }
            }
            else if (SceneManager.GetActiveScene().name == "Level_2")
            {
                if (score > threshold1 && score < threshold2)
                {
                    camera.orthographicSize = low;
                }
                else 
                {
                    camera.orthographicSize = medium;
                }
            }
            else if (SceneManager.GetActiveScene().name == "Level_3")
            {
                if (score >= threshold2)
                {
                    camera.orthographicSize = low;
                }
                else 
                {
                    camera.orthographicSize = high;
                }
            }
        }
        else
        {
            Debug.LogError("ScoreManager not found in the scene!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (zoomOut)
        {
            GetComponent<Camera>().orthographicSize+=zoomValue;
            zoomOut=false; 
        }   
    }
}
