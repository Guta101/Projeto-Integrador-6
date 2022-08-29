using UnityEngine;

public abstract class PlayerBaseState
{
    protected PlayerStateManager Context { get; set; }
    protected PlayerStateFactory Factory { get; set; }
    protected PlayerBaseState CurrentSubState { get; set; }
    protected PlayerBaseState CurrentSuperState { get; set; }
    protected bool IsSuperState { get; set; } = false;

    //  What should happen when the state enters
    public abstract void EnterState();

    //  What should be executed in an update
    public abstract void UpdateState();

    //  What should be executed at the end of the state
    public abstract void ExitState();

    //  Check if the states should switch
    public abstract void CheckSwitchStates();

    public PlayerBaseState(PlayerStateManager currentContext, PlayerStateFactory playerStateFactory)
    {
        Context = currentContext;
        Factory = playerStateFactory;
    }

    //  Execute this state's update and it's substate's
    public void UpdateStates()
    {
        UpdateState();
        if(CurrentSubState != null)
            CurrentSubState.UpdateState();
    }

    //  Switch states with another one
    protected void SwitchState(PlayerBaseState newState)
    {
        ExitState();

        newState.EnterState();

        Debug.Log(newState.ToString());

        if (IsSuperState)
            Context.CurrentState = newState;
        else if (CurrentSuperState != null)
            CurrentSuperState.SetSubState(newState);
    }

    //  Set the superstate of this state
    protected void SetSuperState(PlayerBaseState newSuperState)
    {
        CurrentSuperState = newSuperState;
    }

    //  Set the substate of this state
    protected void SetSubState(PlayerBaseState newSubState)
    {
        CurrentSubState = newSubState;
        newSubState.SetSuperState(this);
    }
}
