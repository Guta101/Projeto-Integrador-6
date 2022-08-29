using UnityEngine;

public class PlayerJumpingState : PlayerBaseState, ISuperState
{
    public PlayerJumpingState(PlayerStateManager currentContext, PlayerStateFactory playerStateFactory) : base(currentContext, playerStateFactory)
    {
        IsSuperState = true;
        InitializeSubState();
    }

    override public void EnterState()
    {
        Context.PlayerRB.velocity = new Vector2(Context.PlayerRB.velocity.x, 0f);
        HandleJump();
    }

    override public void UpdateState()
    {
        CheckSwitchStates();
    }

    public override void CheckSwitchStates()
    {
        if ((!Context.IsJumpPressed && !Context.IsGrounded) || (Context.PlayerRB.velocity.y <= 0 && !Context.IsGrounded))
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

    //  Functions
    void HandleJump()
    {
        Context.PlayerRB.AddForce(Vector2.up * Context.JumpForce, ForceMode2D.Impulse);
    }
}
