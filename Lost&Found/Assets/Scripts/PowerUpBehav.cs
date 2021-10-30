using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpBehav : MonoBehaviour
{
    [SerializeField] AudioClip audioClip;
    [SerializeField] GameObject powerUp;
    [SerializeField] PlayerBehavior playerScript;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            AudioSource.PlayClipAtPoint(audioClip, transform.position);
            playerScript.invPowerUps.Add(powerUp);
        }
    }
}
