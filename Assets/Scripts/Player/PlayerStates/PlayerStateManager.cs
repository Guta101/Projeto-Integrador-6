using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateManager : MonoBehaviour
{
    [SerializeField] private PlayerController controller;
    [SerializeField] private PlayerStats stats;
    private Rigidbody playerRB;
    public PlayerController Controller { get { return controller; } }
    public PlayerStats Stats { get { return stats; } }
    public Rigidbody PlayerRB { get { return playerRB; } }

    [Header("Fall")]
    [SerializeField] private string climbTag = "Climbing";
    public bool IsClimbing { get; private set; }

    public PlayerBaseState CurrentState { get; private set; }

    private void Start()
    {
        playerRB = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        CurrentState.CheckSwitchStates();
        CurrentState.UpdateState();
    }

    private void FixedUpdate()
    {
        CurrentState.FixedUpdateState();
    }

    public void SwitchStates(PlayerBaseState newState)
    {
        CurrentState.OnStateExit();
        CurrentState = newState;
        CurrentState.OnStateEnter();
    }    
}
