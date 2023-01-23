using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class END : MonoBehaviour
{
        AudioSource audioSource;
        public AudioClip WinSound;

void Start()
    {
            audioSource = GetComponent<AudioSource>();
    }
public void PlaySound(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
    }
    
}
