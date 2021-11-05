using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LostObject : PickUp
{
    [SerializeField] AudioClip audio;
    [SerializeField] ClipBoard clipBoard;
    [SerializeField] int id;

    public LostObject(AudioClip audio, ClipBoard clipBoard, int id) : base(audio)
    {
        audio = Audio1;
        clipBoard = ClipBoard;
        id = Id;
    }

    public AudioClip Audio1 { get => audio; set => audio = value; }
    public ClipBoard ClipBoard { get => clipBoard; set => clipBoard = value; }
    public int Id { get => id; set => id = value; }

    public void Collect()
    {
        AudioSource.PlayClipAtPoint(Audio1, transform.position);
        gameObject.SetActive(false);
        ClipBoard.foundObjects.Add(gameObject);
        ClipBoard.Collected(this);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameObject.GetComponent<Collider2D>().enabled = false;
        Collect();
    }
}
