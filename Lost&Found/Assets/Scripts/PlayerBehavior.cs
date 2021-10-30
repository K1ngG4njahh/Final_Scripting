using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    public List<GameObject> mapPowerUps, invPowerUps;
    public List<GameObject> lostObjects;
    [SerializeField]Collider2D playerCollider;
    [SerializeField] PlayerMovement playerMov;
    [SerializeField] TimerBehavior timeBehav;
    [SerializeField] float durationSpeedUP ,startTime, startSpeed, extrTime;
    bool speedON;

    void Start()
    {
        playerCollider.GetComponent<CapsuleCollider2D>();
        playerMov.GetComponent<PlayerMovement>();
        timeBehav.GetComponent<TimerBehavior>();
        startSpeed = playerMov.speed;
    }

    private void Update()
    {
        #region speedUp
        if (speedON)
        {
            durationSpeedUP -= 1 * Time.deltaTime;
        }
        if (durationSpeedUP <= 0)
        {
            durationSpeedUP = startTime/3;
            playerMov.speed = startSpeed;
            speedON = false;
        }
        #endregion


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        #region powerUps
        
        if (collision.tag == "VelUp")
        {
            playerMov.speed *= 2;
            speedON = true;
            foreach (GameObject item in invPowerUps)
            {
                foreach (GameObject j in mapPowerUps)
                {
                    if (j.name == item.name)
                    {
                        item.SetActive(false);
                    }
                }
            }
            
        }
        else if (collision.tag == "TimeUp")
        {
            timeBehav.seconds += extrTime;
            foreach (GameObject item in invPowerUps)
            {
                foreach (GameObject j in mapPowerUps)
                {
                    if (j.name == item.name)
                    {
                        item.SetActive(false);
                    }
                }
            }
        }
        #endregion
    }
}
