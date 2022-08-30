using UnityEngine;

public class PlayerIdleState : PlayerBaseState
{
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

    }

    public override void CheckSwitchStates()
    {
        
    }

    public override void ExitState()
    {
        
    }
}
