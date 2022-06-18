using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SesKontrol : MonoBehaviour
{
    public AudioClip ziplama;
    public AudioClip mama;
    public AudioClip oyunBitti;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

   public void ZiplamaSes()
    {
        audioSource.clip = ziplama;
        audioSource.Play();
    }
    public void MamaSes()
    {
        audioSource.clip = mama;
        audioSource.Play();
    }
    public void GameOverSes()
    {
        audioSource.clip = oyunBitti;
        audioSource.Play();
    }
}
