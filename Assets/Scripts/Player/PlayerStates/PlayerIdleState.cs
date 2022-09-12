using UnityEngine;

public class PlayerIdleState : PlayerBaseState
{
    private float _decceleration = 14f;
    private float _velPower = 0.96f;

    public PlayerIdleState(PlayerStateManager currentContext, PlayerStateFactory playerStateFactory) : base(currentContext, playerStateFactory)
    {

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
        Friction();
    }

    public override void CheckSwitchStates()
    {
        if (CurrentSuperState == Factory.Air())
        {
            if (Context.Controller.PlayerInput.Player.Move.IsPressed())
                SwitchState(Factory.Run());
        }
        else if (CurrentSuperState == Factory.Grounded())
        {
            if (Context.Controller.PlayerInput.Player.Move.IsPressed())
                SwitchState(Factory.Run());
            else if (Context.Controller.PlayerInput.Player.Dash.IsPressed() && Context.CanDash)
                SwitchState(Factory.Dash());
        }
        else if (CurrentSuperState == Factory.Climb())
        {

        }
    }

    public override void ExitState()
    {
        
    }

    private void Friction()
    {
        Vector2 targetSpeed = Context.Controller.PlayerInput.Player.Move.ReadValue<Vector2>() * Context.PlayerStats.PlayerSpeed;
        Vector2 speedDif = targetSpeed - new Vector2(Context.PlayerRB.velocity.x, Context.PlayerRB.velocity.z);
        float movementY = Mathf.Pow(Mathf.Abs(speedDif.y) * _decceleration, _velPower) * Mathf.Sign(speedDif.y);
        float movementX = Mathf.Pow(Mathf.Abs(speedDif.x) * _decceleration, _velPower) * Mathf.Sign(speedDif.x);
        Context.PlayerRB.AddForce(new Vector3(movementX, 0, movementY));
    }
}
