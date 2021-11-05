using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : PickUp 
{
    AudioClip audio;

    public PowerUp(AudioClip audio) : base(audio)
    {
        audio = Audio1;
    }

    public AudioClip Audio1 { get => audio; set => audio = value; }

}
