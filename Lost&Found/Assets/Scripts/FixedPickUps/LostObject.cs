using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LostObject : PickUp, I_Collect
{
    [SerializeField] AudioClip audio;
    [SerializeField] ClipBoarScript clipBoard;

    public LostObject(AudioClip audio, ClipBoarScript clipBoard) : base(audio)
    {
        audio = Audio1;
        clipBoard = ClipBoard;
    }

    public AudioClip Audio1 { get => audio; set => audio = value; }
    public ClipBoarScript ClipBoard { get => clipBoard; set => clipBoard = value; }

    public void Collect()
    {
        gameObject.GetComponent<Collider2D>().enabled = false;
        AudioSource.PlayClipAtPoint(Audio1, transform.position);
        gameObject.SetActive(false);
        ClipBoard.foundOjbs.Add(gameObject);
        ClipBoard.stamping = true;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Collect();
    }
}
