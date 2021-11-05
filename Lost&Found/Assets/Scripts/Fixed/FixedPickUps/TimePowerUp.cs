using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimePowerUp : PowerUp
{
    public float extraTime;

    [SerializeField] AudioClip audio;
    [SerializeField] TimerBehavior timerBehavior;
    public TimePowerUp(AudioClip audio, TimerBehavior timerBehavior) : base(audio)
    {
        Audio2 = audio;
        TimerBehavior = timerBehavior;
    }
    public AudioClip Audio2 { get => audio; set => audio = value; }
    public TimerBehavior TimerBehavior { get => timerBehavior; set => timerBehavior = value; }

    public override void Collect()
    {
        gameObject.GetComponent<Collider2D>().enabled = false;
        AudioSource.PlayClipAtPoint(Audio2, transform.position);
        gameObject.SetActive(false);

        TimerBehavior.seconds += extraTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Collect();
    }
}
