using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerStateManager : MonoBehaviour
{
    //  Reference variables
    public PlayerController Controller { get; private set; }
    public Rigidbody PlayerRB { private set; get; }
    public PlayerStats PlayerStats;

    //  State variables
    public PlayerBaseState CurrentState { get; set; }
    private PlayerStateFactory states;

    //  Grounded & Jump
    public bool IsGrounded { get; private set; }
    public bool CanJump { get; private set; }

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
        CurrentState.UpdateStates();
    }

    void FixedUpdate()
    {
        CurrentState.FixedUpdateStates();
    }
}
