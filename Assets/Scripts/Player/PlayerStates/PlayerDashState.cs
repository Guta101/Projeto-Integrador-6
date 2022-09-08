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
        if (CurrentSuperState == Factory.Air() || CurrentSuperState == Factory.Grounded())
        {
            if (Context.Controller.PlayerInput.Player.Move.IsPressed())
                SwitchState(Factory.Run());
            if (!Context.Controller.PlayerInput.Player.Move.IsPressed())
                SwitchState(Factory.Idle());
        }
        else if (CurrentSuperState == Factory.Climb())
        {
            SwitchState(Factory.Idle());
        }
    }

    public override void ExitState()
    {

    }

    private void Dash()
    {

    }
}
