using System.Collections;
using System.Collections.Generic;

public abstract class PlayerBaseState
{
    protected PlayerStateManager Context { get; set; }

    public PlayerBaseState(PlayerStateManager context)
    {
        Context = context;
    }

    public abstract void CheckSwitchStates();
    public abstract void OnStateEnter();
    public abstract void OnStateExit();
    public abstract void UpdateState();
    public abstract void FixedUpdateState();
}
