using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public static AudioController Instance { get; private set;}
    private AudioSource audioSource;

    void Awake()
    {
         if (Instance != null && Instance != this){
            Destroy(this);
         }
         else
         {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
            audioSource = GetComponent<AudioSource>();
         }
    }

    [SerializeField]
    private AudioClip[] audios;

    public void ReproducirAudio(int id){
        audioSource.PlayOneShot(audios[id],1);
    }

    public void ReproducirClip(AudioClip audioClip){
        audioSource.PlayOneShot(audioClip, 1);
    }
}
