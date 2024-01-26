using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerSC : MonoBehaviour
{
    public static AudioSource audioSource;
    public AudioClip clickClip;

    public static SoundManagerSC instance;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        instance = this;
    }
}
