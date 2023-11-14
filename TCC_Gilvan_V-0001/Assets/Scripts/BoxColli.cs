using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxColli : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioSource audioSource2;
    public Animator doorAnim;


    void Start()
    {
        if (audioSource == null)
        {
            Debug.LogError("AudioSource não atribuído ao DoorController.");
        }
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            doorAnim.SetTrigger("open");
            PlayDoorSound();
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            doorAnim.SetTrigger("close");
            PlayDoorSound2();
        }
    }

    void PlayDoorSound()
    {
        if (audioSource != null && !audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }

    void PlayDoorSound2()
    {
        if (audioSource != null && !audioSource.isPlaying)
        {
            audioSource2.Play();
        }
    }
}
