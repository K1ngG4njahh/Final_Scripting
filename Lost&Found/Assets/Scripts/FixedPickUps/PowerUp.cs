using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : PickUp, I_Collect
{
    [SerializeField] AudioClip audio;
    [SerializeField] PlayerBehavior player;

    public PowerUp(AudioClip audio, PlayerBehavior player) : base(audio)
    {
        audio = Audio1;
        player = Player;
    }

    public AudioClip Audio1 { get => audio; set => audio = value; }
    public PlayerBehavior Player { get => player; set => player = value; }

    public void Collect()
    {
        gameObject.GetComponent<Collider2D>().enabled = false;
        AudioSource.PlayClipAtPoint(Audio1, transform.position);
        Player.invPowerUps.Add(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Collect();
    }
}
