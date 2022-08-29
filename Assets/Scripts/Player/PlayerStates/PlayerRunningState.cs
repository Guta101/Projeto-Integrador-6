using UnityEngine;

public class PlayerRunningState : PlayerBaseState
{
    public PlayerRunningState(PlayerStateManager currentContext, PlayerStateFactory playerStateFactory) : base(currentContext, playerStateFactory)
    {

    }

    override public void EnterState()
    {
        Context.AppliedMovementInput = Context.CurrentMovementInput;
    }

    override public void UpdateState()
    {
        CheckSwitchStates();
        //Run();
    }

    public override void CheckSwitchStates()
    {
        if (Context.IsDodgePressed)
            SwitchState(Factory.Dodge());
        else if (!Context.IsRunPressed)
            SwitchState(Factory.Idle());
    }

    public override void ExitState()
    {

    }
}
