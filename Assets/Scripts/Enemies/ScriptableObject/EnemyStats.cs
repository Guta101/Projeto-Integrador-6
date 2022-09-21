using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Enemies/EnemyStats")]
public class EnemyStats : ScriptableObject
{
    [SerializeField]
    private float _maxHP;
    [SerializeField]
    private float _speed;
    [SerializeField]
    private float _damage;
    [SerializeField]
    private float _attackCD;

    //  Get & Set
    public float MaxHP { get { return _maxHP; } set { _maxHP = value; } }
    public float Speed { get { return _speed; } set { _speed = value; } }
    public float Damage { get { return _damage; } set { _damage = value; } }
    public float AttackCD { get { return _attackCD; } set { _attackCD = value; } }
}
