using UnityEngine;

public class PlayerRunningState : PlayerBaseState
{
    private float _acceleration = 13f;
    private float _decceleration = 14f;
    private float _velPower = 0.96f;

    public PlayerRunningState(PlayerStateManager currentContext, PlayerStateFactory playerStateFactory) : base(currentContext, playerStateFactory)
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
        HandleMovement();
    }

    public override void CheckSwitchStates()
    {
        if (CurrentSuperState == Factory.Air())
        {
            if (!Context.Controller.PlayerInput.Player.Move.IsPressed())
                SwitchState(Factory.Idle());
        }
        else if (CurrentSuperState == Factory.Grounded())
        {
            if (!Context.Controller.PlayerInput.Player.Move.IsPressed())
                SwitchState(Factory.Idle());
            else if (Context.Controller.PlayerInput.Player.Dash.IsPressed())
                SwitchState(Factory.Dash());
        }
        else if (CurrentSuperState == Factory.Climb())
        {
            SwitchState(Factory.Idle());
        }
    }

    public override void ExitState()
    {

    }

    private void HandleMovement()
    {
        Vector2 targetSpeed = Context.Controller.PlayerInput.Player.Move.ReadValue<Vector2>() * Context.PlayerStats.PlayerSpeed;
        Vector2 speedDif = targetSpeed - new Vector2(Context.PlayerRB.velocity.x, Context.PlayerRB.velocity.z);
        float accelrateY = (Mathf.Abs(targetSpeed.y) > 0.01f) ? _acceleration : _decceleration;
        float accelrateX = (Mathf.Abs(targetSpeed.x) > 0.01f) ? _acceleration : _decceleration;
        float movementY = Mathf.Pow(Mathf.Abs(speedDif.y) * accelrateY, _velPower) * Mathf.Sign(speedDif.y);
        float movementX = Mathf.Pow(Mathf.Abs(speedDif.x) * accelrateX, _velPower) * Mathf.Sign(speedDif.x);
        Context.PlayerRB.AddForce(new Vector3(movementX, 0, movementY));
    }
}
