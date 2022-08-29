using UnityEngine;

public class PlayerDodgingState : PlayerBaseState
{
    public PlayerDodgingState(PlayerStateManager currentContext, PlayerStateFactory playerStateFactory) : base(currentContext, playerStateFactory)
    {

    }

    override public void EnterState()
    {
        HandleDodge();
    }

    override public void UpdateState()
    {
        CheckSwitchStates();
    }

    public override void CheckSwitchStates()
    {
        if (Context.IsRunPressed)
            SwitchState(Factory.Run());
        else if (!Context.IsDodgePressed)
            SwitchState(Factory.Idle());
    }

    public override void ExitState()
    {

    }

    //  Fuctions
    void HandleDodge()
    {
        Vector3 mouseDistance = Context.Controller.MouseLocation.normalized;
        Context.PlayerRB.AddForce(mouseDistance * Context.DodgeForce, ForceMode2D.Impulse);
    }
}
