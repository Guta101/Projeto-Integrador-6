using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemy : EnemyBase
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.tag == "Player")
            Attack();
    }

    protected override void Attack()
    {
        Debug.Log(gameObject + " Attacked for " + enemyStats.Damage + " damage!");
    }

    protected override void Move()
    {
        
    }
}
