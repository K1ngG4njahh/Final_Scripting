using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class PickUpScript : MonoBehaviour
{
    [SerializeField] ClipBoarScript clipBoar;
    [SerializeField]GameObject pickUp;
    [SerializeField]AudioClip audioClip;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            pickUp.SetActive(false);
            clipBoar.foundOjbs.Add(pickUp);
            clipBoar.stamping = true;
            AudioSource.PlayClipAtPoint(audioClip, transform.position);
            
        }
    }
}
