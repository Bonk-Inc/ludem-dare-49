using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverObstacle : Obstacle
{
    protected override void OnPlayerHit(Collider2D other)
    {
        other.GetComponent<PlayerHitHandler>().Die();
    }
}
