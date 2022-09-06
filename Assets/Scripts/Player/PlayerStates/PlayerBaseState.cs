using UnityEngine;

public abstract class PlayerBaseState
{
    protected PlayerStateManager Context { get; set; }
    protected PlayerStateFactory Factory { get; set; }
    public PlayerBaseState CurrentSubState { get; set; }
    protected PlayerBaseState CurrentSuperState { get; set; }
    protected bool IsSuperState { get; set; } = false;

    public abstract void EnterState();
    public abstract void UpdateState();
    public abstract void FixedUpdateState();
    public abstract void ExitState();
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

    public void FixedUpdateStates()
    {
        FixedUpdateState();
        if (CurrentSubState != null)
            CurrentSubState.FixedUpdateState();
    }

    //  Switch states with another one
    protected void SwitchState(PlayerBaseState newState)
    {
        ExitState();

        newState.EnterState();

        Debug.Log(newState.ToString());

        if (IsSuperState)
        {
            newState.SetSubState(CurrentSubState);
            Context.CurrentState = newState;
        }
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
