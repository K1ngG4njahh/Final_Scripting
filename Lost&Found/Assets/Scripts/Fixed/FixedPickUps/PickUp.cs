using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    AudioClip audio;

    public PickUp(AudioClip audio)
    {
        Audio = audio;
    }
    public AudioClip Audio { get => audio; set => audio = value; }
}
