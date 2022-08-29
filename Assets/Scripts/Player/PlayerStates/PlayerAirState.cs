using UnityEngine;

public class PlayerAirState : PlayerBaseState, ISuperState
{
    private float _originalFallGravity = .02f;
    private float _fallGravity;
    private float _fallGravityMultiplier = 2f;
    private float _maxFallGravity = .8f;
    private float _originalGravity;

    public PlayerAirState(PlayerStateManager currentContext, PlayerStateFactory playerStateFactory) : base(currentContext, playerStateFactory)
    {
        IsSuperState = true;
        InitializeSubState();
    }

    override public void EnterState()
    {
         _originalGravity = Context.PlayerRB.gravityScale;
        _fallGravity = _originalFallGravity;
    }

    override public void UpdateState()
    {
        CheckSwitchStates();
        HandleFall();
    }

    public override void CheckSwitchStates()
    {
        if (Context.IsGrounded)
            SwitchState(Factory.Grounded());
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
        Context.PlayerRB.gravityScale = _originalGravity;
        _fallGravity = _originalFallGravity;

    }
    
    private void HandleFall()
    {
        Context.PlayerRB.gravityScale = (1 + _fallGravity);

        if (_fallGravity < _maxFallGravity)
        {
            _fallGravity *= _fallGravityMultiplier;
        }
    }
    

}
