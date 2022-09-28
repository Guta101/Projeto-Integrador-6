using System.Collections;
using UnityEngine;

public class PlayerDashState : PlayerBaseState
{
    public PlayerDashState(PlayerStateManager currentContext, PlayerStateFactory playerStateFactory) : base(currentContext, playerStateFactory)
    {

    }

    override public void EnterState()
    {
        Context.StartCoroutine(DashTimer());
    }

    override public void UpdateState()
    {

    }

    public override void FixedUpdateState()
    {
        Dash();
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
        Context.CanDash = false;
        Context.StartCoroutine(Context.DashCooldown());
    }

    private void Dash()
    {
        if (Context.Controller.PlayerInput.Player.Move.ReadValue<Vector2>().x != 0 || Context.Controller.PlayerInput.Player.Move.ReadValue<Vector2>().y != 0)
            Context.PlayerRB.velocity = new Vector3(Context.Controller.PlayerInput.Player.Move.ReadValue<Vector2>().x * 50f, 0, Context.Controller.PlayerInput.Player.Move.ReadValue<Vector2>().y * 50f);
        else
            Context.PlayerRB.velocity = new Vector3(Context.transform.forward.x * 50f, 0, Context.transform.forward.y * 50f);
    }

    private IEnumerator DashTimer()
    {
        yield return new WaitForSeconds(Context.PlayerStats.DashDuration);
        CheckSwitchStates();
    }

    
}
