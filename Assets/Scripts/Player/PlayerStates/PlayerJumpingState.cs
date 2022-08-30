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
        HandleJump();
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
        if (!Context.Controller.PlayerInput.Player.Jump.IsPressed() || Context.PlayerRB.velocity.y <= 0)
            SwitchState(Factory.Air());
        else if (Context.IsGrounded)
            SwitchState(Factory.Grounded());
        else if (Context.CurrentClimbing)
            SwitchState(Factory.Climb());
    }

    public void InitializeSubState()
    {

    }

    public override void ExitState()
    {
       
    }

    private void HandleJump()
    {
        Context.PlayerRB.velocity = new Vector3(Context.PlayerRB.velocity.x, 0, Context.PlayerRB.velocity.z);
        Context.PlayerRB.AddForce(Vector2.up * Context.PlayerStats.PlayerJumpForce, ForceMode.Impulse);
    }
}
