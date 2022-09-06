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
        if (CurrentSuperState == Factory.Air())
        {
            if (Context.Controller.PlayerInput.Player.Move.IsPressed())
                SwitchState(Factory.Run());
        }
        else if (CurrentSuperState == Factory.Grounded())
        {
            if (Context.Controller.PlayerInput.Player.Move.IsPressed())
                SwitchState(Factory.Run());
            else if (Context.Controller.PlayerInput.Player.Dash.IsPressed())
                SwitchState(Factory.Dash());
        }
        else if (CurrentSuperState == Factory.Climb())
        {

        }
    }

    public override void ExitState()
    {
        
    }
}
