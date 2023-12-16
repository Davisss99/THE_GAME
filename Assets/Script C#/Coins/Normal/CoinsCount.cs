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
    public int Remaining1;
    public int Remaining2;
    public int Remaining3;
    public int globCoins;
    
    void Start()
    {
        HideWhenClose hideWhenClose = Object.FindFirstObjectByType<HideWhenClose>();
        int globCoins = HideWhenClose.globalCoins;
        
        if (SceneManager.GetActiveScene().name == "Level_1")
        {
            Remaining1 = maxCoins1;
            TextMeshProUGUI textMesh = GetComponent<TextMeshProUGUI>();
            textMesh.text = maxCoins1.ToString();
        }
        else if (SceneManager.GetActiveScene().name == "Level_2")
        {
            Remaining2 = maxCoins2;
            TextMeshProUGUI textMesh = GetComponent<TextMeshProUGUI>();
            textMesh.text = maxCoins2.ToString();
        }
        else if  (SceneManager.GetActiveScene().name == "Level_3")
        {
            Remaining3 = maxCoins3;
            TextMeshProUGUI textMesh = GetComponent<TextMeshProUGUI>();
            textMesh.text = maxCoins3.ToString();
        }
    } 

    // Update is called once per frame
    
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Level_1")
        {
            globCoins = HideWhenClose.globalCoins;
            Remaining1 = maxCoins1 - globCoins;
            TextMeshProUGUI textMesh = GetComponent<TextMeshProUGUI>();
            textMesh.text = Remaining1.ToString();
            
            if (HideWhenClose.globalCoins >= maxCoins1)
            {
                Invoke("LoadNextScene", 0.5f);
            }
        }
        else if (SceneManager.GetActiveScene().name == "Level_2")
        {
            globCoins = HideWhenClose.globalCoins;
            Remaining2 = maxCoins2 - globCoins;
            TextMeshProUGUI textMesh = GetComponent<TextMeshProUGUI>();
            textMesh.text = Remaining2.ToString();
            
            if (HideWhenClose.globalCoins >= maxCoins2)
            {
                Invoke("LoadNextScene", 0.5f);
            }
        }
        else if  (SceneManager.GetActiveScene().name == "Level_3")
        {
            globCoins = HideWhenClose.globalCoins;
            Remaining3 = maxCoins3 - globCoins;
            TextMeshProUGUI textMesh = GetComponent<TextMeshProUGUI>();
            textMesh.text = Remaining3.ToString();
            
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
