using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{

    private static MusicManager instance = null;
    public AudioClip backgroundMusic; // Assumi che questo sia il tuo file audio
    private AudioSource audioSource;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            audioSource = gameObject.AddComponent<AudioSource>();
            audioSource.loop = true;
            audioSource.clip = backgroundMusic;
            
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
    }
    public void Play()
    {
        if (audioSource != null && !audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }

    public void Pause()
    {
        if (audioSource != null && audioSource.isPlaying)
        {
            audioSource.Pause();
        }
    }

    void UnPause()
    {
        if (audioSource != null && audioSource.isPlaying && !audioSource.isPlaying)
        {
            audioSource.UnPause();
        }
    }
}


