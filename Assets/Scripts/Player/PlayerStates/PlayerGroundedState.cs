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

    public override void CheckSwitchStates()
    {
        if (Context.IsJumpPressed)
            SwitchState(Factory.Jump());
        if (!Context.IsGrounded)
            SwitchState(Factory.Air());
    }

    public void InitializeSubState()
    {
        if (Context.IsRunPressed)
            SetSubState(Factory.Run());
        else if (Context.IsDodgePressed)
            SetSubState(Factory.Dodge());
        else
            SetSubState(Factory.Idle());
    }

    public override void ExitState()
    {
        
    }

}