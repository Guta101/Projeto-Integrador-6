using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Player/PlayerStats")]
public class PlayerStats : ScriptableObject
{
    [Header("Base Stats")]
    //  Main Stats
    [SerializeField] private float _maxHP;
    [SerializeField] private float _currentHP;

    //  Movement
    [SerializeField] private float _playerSpeed;
    [SerializeField] private float _dashCooldown;
    [SerializeField] private float _dashDuration;
    

    [Header("Extra Stats")]
    [SerializeField] private StatVariable extraMaxHP;
    [SerializeField] private StatVariable extraPlayerSpeed;
    [SerializeField] private StatVariable extraDashCooldown;
    [SerializeField] private StatVariable extraDashDuration;

    //  Get & Set
    public float PlayerSpeed { get { return _playerSpeed + extraPlayerSpeed.StatBoost; } private set { _playerSpeed = value; } }
    public float MaxHP { get { return _maxHP + extraMaxHP.StatBoost; } private set { _maxHP = value; } }
    public float DashCooldown { get { return _dashCooldown + extraDashCooldown.StatBoost; } private set { _dashCooldown = value; } }
    public float DashDuration { get { return _dashDuration + extraDashDuration.StatBoost; } private set { _dashDuration = value; } }

    //  Increase & Decrease
    /*
    public void AddMaxHP(float extraHP)
    {
        _extraMaxHP += extraHP;
    }
    public void RemoveMaxHP(float extraHP)
    {
        _extraMaxHP -= extraHP;
    }

    public void AddPlayerSpeed(float extraSpeed)
    {
        _extraPlayerSpeed += extraSpeed;
    }
    public void RemovePlayerSpeed(float extraSpeed)
    {
        _extraPlayerSpeed -= extraSpeed;
    }

    public void AddDashCooldown(float extraCooldown)
    {
        _extraDashCooldown += extraCooldown;
    }
    public void RemoveDashCooldown(float extraCooldown)
    {
        _extraDashCooldown -= extraCooldown;
    }

    public void AddDashTime(float extraDashTime)
    {
        _extraDashTime += extraDashTime;
    }
    public void RemoveDashTime(float extraDashTime)
    {
        _extraDashTime -= extraDashTime;
    }
    */
}
