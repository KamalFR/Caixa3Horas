using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMusic : MonoBehaviour
{
    public AudioSource audioSource;

    public void Start()
    {
        audioSource.Play();
    }
}
