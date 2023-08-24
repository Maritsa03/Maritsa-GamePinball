using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioManager : MonoBehaviour
{
    public AudioSource bgmAudioSource;
    public GameObject sfxAudioSource;
    public GameObject sfxHitAudioSource;
    public GameObject sfxPaddleAudioSource;
    
    void Start()
    {
        PlayBGM();
    }

    public void PlayBGM() 
    { 
        bgmAudioSource.Play();
    }

    public void PlaySFX(Vector3 spawnPosition) 
    { 
        GameObject.Instantiate(sfxAudioSource, spawnPosition, Quaternion.identity);
    }

    public void PlaySFXPaddle(Vector3 spawnPosition) 
    { 
        GameObject.Instantiate(sfxPaddleAudioSource, spawnPosition, Quaternion.identity);
    }

    public void PlaySFXHit(Vector3 spawnPosition) 
    { 
        GameObject.Instantiate(sfxHitAudioSource, spawnPosition, Quaternion.identity);
    }
}
