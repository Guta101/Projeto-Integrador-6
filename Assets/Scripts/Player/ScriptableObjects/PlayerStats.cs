using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Player/PlayerStats")]
public class PlayerStats : ScriptableObject
{
    //  Main Stats
    [SerializeField] private float _maxHP;
    private float _extraMaxHP;
    [SerializeField] private float _currentHP;

    //  Movement
    [SerializeField] private float _playerSpeed;
    private float _extraPlayerSpeed;
    [SerializeField] private float _dashCooldown;
    private float _extraDashCooldown;
    [SerializeField] private float _dashTime;
    private float _extraDashTime;

    //  Get & Set
    public float PlayerSpeed { get { return _playerSpeed + _extraPlayerSpeed; } private set { _playerSpeed = value; } }
    public float MaxHP { get { return _maxHP + _extraMaxHP; } private set { _maxHP = value; } }
    public float DashCooldown { get { return _dashCooldown + _extraDashCooldown; } private set { _dashCooldown = value; } }
    public float DashTime { get { return _dashTime + _extraDashTime; } private set { _dashTime = value; } }

    //  Increase & Decrease
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

}
