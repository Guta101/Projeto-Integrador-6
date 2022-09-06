using UnityEngine;

public class PlayerAirState : PlayerBaseState, ISuperState
{
    private float _fallAcc = 50f;

    public PlayerAirState(PlayerStateManager currentContext, PlayerStateFactory playerStateFactory) : base(currentContext, playerStateFactory)
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
        Gravity();
    }

    public override void CheckSwitchStates()
    {
        if (Context.IsGrounded)
            SwitchState(Factory.Grounded());
        else if (Context.CurrentClimbing)
            SwitchState(Factory.Climb());
    }

    public void InitializeSubState()
    {
        if (!Context.Controller.PlayerInput.Player.Move.IsPressed())
            SetSubState(Factory.Idle());
        if (Context.Controller.PlayerInput.Player.Move.IsPressed())
            SetSubState(Factory.Run());
    }

    public override void ExitState()
    {

    }

    private void Gravity()
    {
        float _newAcc = Context.PlayerRB.velocity.y + _fallAcc;
        Context.PlayerRB.AddForce(Vector3.down * (Context.PlayerRB.velocity.y + _newAcc) / 2, ForceMode.Acceleration);
    }
}
