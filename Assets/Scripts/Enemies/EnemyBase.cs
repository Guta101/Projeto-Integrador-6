using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyBase : MonoBehaviour, IDamageable
{
    //  Stats
    [SerializeField]
    protected EnemyStats enemyStats;
    [SerializeField]
    protected float _currentHP;

    //  References
    [SerializeField]
    protected PlayerStats playerStats;
    [SerializeField]
    protected LayerMask playerMask;
    protected Rigidbody enemyRB;

    private void Start()
    {
        enemyRB = GetComponent<Rigidbody>();
        _currentHP = enemyStats.MaxHP;
    }

    public void TakeDamage(float damage)
    {
        _currentHP -= damage;
        if (_currentHP <= 0)
            Die();
    }

    public void Die()
    {
        Destroy(gameObject);
    }

    protected abstract void Attack();

    protected abstract void Move();
}
