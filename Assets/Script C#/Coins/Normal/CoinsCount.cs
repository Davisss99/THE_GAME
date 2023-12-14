using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CoinsCount : MonoBehaviour
{   
    public string nextScene;
    public int maxCoins1 = 41;
    public int maxCoins2 = 46;
    public int maxCoins3 = 132;
    
    void Start()
    {
        TextMeshProUGUI textMesh = GetComponent<TextMeshProUGUI>();
        textMesh.text = HideWhenClose.globalCoins.ToString();
    } 

    // Update is called once per frame
    
    void Update()
    {
        TextMeshProUGUI textMesh = GetComponent<TextMeshProUGUI>();
        textMesh.text = HideWhenClose.globalCoins.ToString();
        if (SceneManager.GetActiveScene().name == "Level_1")
        {
            if (HideWhenClose.globalCoins >= maxCoins1)
            {
                Invoke("LoadNextScene", 0.5f);
            }
        }
        else if (SceneManager.GetActiveScene().name == "Level_2")
        {
            if (HideWhenClose.globalCoins >= maxCoins2)
            {
                Invoke("LoadNextScene", 0.5f);
            }
        }
        else if  (SceneManager.GetActiveScene().name == "Level_3")
        {
            if (HideWhenClose.globalCoins >= maxCoins3)
            {
                Invoke("LoadNextScene", 0.5f);
            }
        }
    }

    void LoadNextScene()
    {
        SceneManager.LoadScene(nextScene);
    }
}
