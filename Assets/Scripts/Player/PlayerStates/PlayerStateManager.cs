using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerStateManager : MonoBehaviour
{
    //  Reference variables
    [SerializeField] private PlayerController controller;
    [SerializeField] private Rigidbody playerRB;
    [SerializeField] private PlayerStats playerStats;
    [SerializeField] private PlayerGroundCheck groundCheck;
    public PlayerController Controller { get { return controller; } }
    public Rigidbody PlayerRB { get { return playerRB; } }
    public PlayerStats PlayerStats { get { return playerStats; } }
    public PlayerGroundCheck GroundCheck { get { return groundCheck; } }

    //  State variables
    public PlayerBaseState CurrentState { get; set; }
    private PlayerStateFactory states;

    //  Grounded
    public bool IsGrounded { get; private set; }

    //  Climb
    public GameObject CurrentClimbing { get; private set; }

    //  MonoBehaviour stuff
    void Awake()
    {
        //  Setup state
        states = new PlayerStateFactory(this);
        CurrentState = states.Grounded();
        CurrentState.EnterState();
    }

    void Update()
    {
        IsGrounded = GroundCheck.IsGrounded;
        CurrentState.UpdateStates();
    }

    void FixedUpdate()
    {
        CurrentState.FixedUpdateStates();
    }
}
