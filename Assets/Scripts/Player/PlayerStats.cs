using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Player/PlayerStats")]
public class PlayerStats : ScriptableObject
{
    //  Main Stats
    [SerializeField]
    private float _maxHP;
    private float _extraMaxHP;
    [SerializeField]
    private float _currentHP;

    //  Movement
    [SerializeField]
    private float _playerSpeed;
    private float _extraPlayerSpeed;
    [SerializeField]
    private float _playerJumpForce;
    private float _extraPlayerJumpForce;

    //  Get & Set
    public float PlayerSpeed { get { return _playerSpeed + _extraPlayerSpeed; } private set { _playerSpeed = value; } }
    public float MaxHP { get { return _maxHP + _extraMaxHP; } private set { _maxHP = value; } }
    public float PlayerJumpForce { get { return _playerJumpForce + _extraPlayerJumpForce; } private set { _playerJumpForce = value; } }

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

    public void AddPlayerJumpForce(float extraJumpForce)
    {
        _extraPlayerJumpForce += extraJumpForce;
    }
    public void RemovePlayerJumpForce(float extraJumpForce)
    {
        _extraPlayerJumpForce -= extraJumpForce;
    }
}
