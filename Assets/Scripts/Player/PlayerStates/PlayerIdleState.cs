using UnityEngine;

public class PlayerIdleState : PlayerBaseState
{
    private float _frictionAmount = 0.22f;

    public PlayerIdleState(PlayerStateManager currentContext, PlayerStateFactory playerStateFactory) : base(currentContext, playerStateFactory)
    {

    }

    override public void EnterState()
    {
        Context.AppliedMovementInput = Vector2.zero;
    }

    override public void UpdateState()
    {
        CheckSwitchStates();
        Friction();
    }

    public override void CheckSwitchStates()
    {
        if (Context.IsRunPressed)
            SwitchState(Factory.Run());
        else if (Context.IsDodgePressed)
            SwitchState(Factory.Dodge());
    }

    public override void ExitState()
    {
        
    }

    private void Friction()
    {
        float amount = Mathf.Min(Mathf.Abs(Context.PlayerRB.velocity.x), Mathf.Abs(_frictionAmount));
        amount *= Mathf.Sign(Context.PlayerRB.velocity.x);
        Context.PlayerRB.AddForce(Vector2.right * -amount, ForceMode2D.Impulse);
    }
}
