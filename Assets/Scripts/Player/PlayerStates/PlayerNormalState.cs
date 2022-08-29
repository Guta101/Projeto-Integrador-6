using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerNormalState : PlayerBaseState
{
    //  Movement speed values
    private float _acceleration = 13f;
    private float _decceleration = 14f;
    private float _velPower = 0.96f;

    public PlayerNormalState(PlayerStateManager context) : base(context)
    {
    }

    public override void CheckSwitchStates()
    {
        
    }

    public override void FixedUpdateState()
    {
        HandleMovement();
    }

    public override void OnStateEnter()
    {
        
    }

    public override void OnStateExit()
    {
        
    }

    public override void UpdateState()
    {
        
    }

    private void HandleMovement()
    {
        Vector2 targetSpeed = Context.Controller.PlayerInput.Player.Move.ReadValue<Vector2>() * Context.Stats.PlayerSpeed;
        Vector2 speedDif = targetSpeed - new Vector2(Context.PlayerRB.velocity.x, Context.PlayerRB.velocity.z);
        float accelrateY = (Mathf.Abs(targetSpeed.y) > 0.01f) ? _acceleration : _decceleration;
        float accelrateX = (Mathf.Abs(targetSpeed.x) > 0.01f) ? _acceleration : _decceleration;
        float movementY = Mathf.Pow(Mathf.Abs(speedDif.y) * accelrateY, _velPower) * Mathf.Sign(speedDif.y);
        float movementX = Mathf.Pow(Mathf.Abs(speedDif.x) * accelrateX, _velPower) * Mathf.Sign(speedDif.x);
        Context.PlayerRB.AddForce(new Vector3(movementX, 0, movementY));
    }
}
