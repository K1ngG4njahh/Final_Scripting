using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    public List<GameObject> mapPowerUps, invPowerUps;
    [SerializeField]Collider2D playerCollider;
    public PlayerMovement playerMov;
    [SerializeField] TimerBehavior timeBehav;
    [SerializeField] float durationSpeedUP ,startTime, startSpeed, extrTime;
    public bool speedON;

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
}
