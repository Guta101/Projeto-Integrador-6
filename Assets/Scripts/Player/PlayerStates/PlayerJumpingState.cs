using UnityEngine;

public class PlayerJumpingState : PlayerBaseState, ISuperState
{
    private float _fallAcc = 50f;

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
        Gravity();
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

    private void Gravity()
    {
        float _newAcc = Context.PlayerRB.velocity.y + _fallAcc;
        Context.PlayerRB.AddForce(Vector3.down * (Context.PlayerRB.velocity.y + _newAcc) / 2, ForceMode.Acceleration);
    }
}
