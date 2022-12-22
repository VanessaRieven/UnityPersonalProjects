using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffects : MonoBehaviour
{
    public AudioSource jump;

    void jumpSound()
    {
        jump.Play();
    }
}
