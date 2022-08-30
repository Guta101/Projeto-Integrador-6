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
        CheckSwitchStates();
    }

    public override void FixedUpdateState()
    {

    }

    public override void CheckSwitchStates()
    {
        if (!Context.IsGrounded)
            SwitchState(Factory.Air());
        else if (Context.CanJump && Context.Controller.PlayerInput.Player.Jump.IsPressed())
            SwitchState(Factory.Jump());
        else if (Context.CurrentClimbing)
            SwitchState(Factory.Climb());
    }

    public void InitializeSubState()
    {

    }

    public override void ExitState()
    {
        
    }

}