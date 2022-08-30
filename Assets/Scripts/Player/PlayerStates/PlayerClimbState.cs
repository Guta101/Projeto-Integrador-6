using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClimbState : PlayerBaseState, ISuperState
{
    public PlayerClimbState(PlayerStateManager currentContext, PlayerStateFactory playerStateFactory) : base(currentContext, playerStateFactory)
    {
        IsSuperState = true;
        InitializeSubState();
    }

    public override void CheckSwitchStates()
    {
        if (Context.IsGrounded)
            SwitchState(Factory.Grounded());
        else if (!Context.CurrentClimbing)
            SwitchState(Factory.Air());
        else if (Context.CanJump && Context.Controller.PlayerInput.Player.Jump.IsPressed())
            SwitchState(Factory.Jump());
    }

    public override void EnterState()
    {
        
    }

    public override void ExitState()
    {
        
    }

    public override void FixedUpdateState()
    {
        
    }

    public void InitializeSubState()
    {
        
    }

    public override void UpdateState()
    {
        CheckSwitchStates();
    }
}
