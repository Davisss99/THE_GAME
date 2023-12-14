using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void ChangeScene(string sceneName)
	{	
		SceneManager.LoadScene (sceneName);
		MusicManager musicManager = Object.FindFirstObjectByType<MusicManager>();
		AudioSource audioSource = musicManager.GetComponent<AudioSource>();
		
		if (musicManager != null)
		{
			if(sceneName=="Mainpage")
			{
				ScoreManager.globalScore=0;
			
				if (!audioSource.isPlaying)
				{
					audioSource.Play();
				}
				else
				{
					audioSource.UnPause();
				}
			}
			
			if(sceneName=="Intro" || sceneName=="IntroQuest" || sceneName=="Quest1" || sceneName=="Quest2" || sceneName=="Quest3" || sceneName=="Quest4" || sceneName=="AYR" )
			{
				audioSource.UnPause();
			}
			
			if(sceneName=="Level_1"  || sceneName=="Level_2" || sceneName=="Level_3")
			{
				audioSource.Pause();
			}

			if (sceneName=="ChangeScene12" || sceneName=="ChangeScene12Failed" || sceneName=="ChangeScene23" || sceneName=="ChangeScene23Failed" || sceneName=="Final" || sceneName=="FinalFailed")
			{
				audioSource.UnPause();
			}
			
			// Assicura che l'oggetto MusicManager persista durante il cambio di scena
			DontDestroyOnLoad(musicManager.gameObject);
		}
	}
	public void Exit()
	{
		Application.Quit ();
	}
}

