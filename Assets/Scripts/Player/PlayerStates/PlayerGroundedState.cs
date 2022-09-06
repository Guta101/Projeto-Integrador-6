using UnityEngine;

public class PlayerGroundedState : PlayerBaseState, ISuperState
{
    public PlayerGroundedState(PlayerStateManager currentContext, PlayerStateFactory playerStateFactory) : base(currentContext, playerStateFactory)
    {
        IsSuperState = true;
        InitializeSubState();
    }

    override public void EnterState()
    {
        
    }

    override public void UpdateState()
    {
        
    }

    public override void FixedUpdateState()
    {
        CheckSwitchStates();
    }

    public override void CheckSwitchStates()
    {
        if (!Context.IsGrounded)
            SwitchState(Factory.Air());
        else if (Context.CurrentClimbing)
            SwitchState(Factory.Climb());
    }

    public void InitializeSubState()
    {
        if (Context.Controller.PlayerInput.Player.Move.IsPressed())
            SetSubState(Factory.Run());
        else if (!Context.Controller.PlayerInput.Player.Move.IsPressed())
            SetSubState(Factory.Idle());
        else if (Context.Controller.PlayerInput.Player.Dash.IsPressed())
            SetSubState(Factory.Dash());
    }

    public override void ExitState()
    {
        
    }

}