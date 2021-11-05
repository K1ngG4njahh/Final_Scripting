using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPowerUp : PowerUp
{
    [SerializeField] AudioClip audio;
    [SerializeField] PlayerBehavior playerBehav;
    public SpeedPowerUp(AudioClip audio, PlayerBehavior playerBehav) : base(audio)
    {
        Audio2 = audio;
        PlayerBehav = playerBehav;
    }
    public AudioClip Audio2 { get => audio; set => audio = value; }
    public PlayerBehavior PlayerBehav { get => playerBehav; set => playerBehav = value; }

    public override void Collect()
    {
        gameObject.GetComponent<Collider2D>().enabled = false;
        AudioSource.PlayClipAtPoint(Audio2, transform.position);
        gameObject.SetActive(false);

        PlayerBehav.playerMov.speed *= 2;
        playerBehav.speedON = true;

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Collect();
    }
}
