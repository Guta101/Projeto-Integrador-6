using UnityEngine;

public class PlayerDashState : PlayerBaseState
{
    public PlayerDashState(PlayerStateManager currentContext, PlayerStateFactory playerStateFactory) : base(currentContext, playerStateFactory)
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

    }

    public override void CheckSwitchStates()
    {

    }

    public override void ExitState()
    {

    }
}
