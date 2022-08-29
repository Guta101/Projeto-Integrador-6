using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClimbingState : PlayerBaseState
{
    public PlayerClimbingState(PlayerStateManager context) : base(context)
    {
    }

    public override void CheckSwitchStates()
    {
        
    }

    public override void FixedUpdateState()
    {
        Climb();
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

    private void Climb()
    {

    }
}
