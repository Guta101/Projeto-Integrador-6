using System.Collections.Generic;

public class PlayerStateFactory
{
    enum PlayerStates
    {
        idle,
        run,
        dash,
        grounded,
        jump,
        air,
        climb
    }

    PlayerStateManager context;
    Dictionary<PlayerStates, PlayerBaseState> _states = new Dictionary<PlayerStates, PlayerBaseState>();

    public PlayerStateFactory(PlayerStateManager currentContext)
    {
        context = currentContext;
        _states[PlayerStates.idle] = new PlayerIdleState(context, this);
        _states[PlayerStates.run] = new PlayerRunningState(context, this);
        _states[PlayerStates.jump] = new PlayerJumpingState(context, this);
        _states[PlayerStates.grounded] = new PlayerGroundedState(context, this);
        _states[PlayerStates.air] = new PlayerAirState(context, this);
        _states[PlayerStates.dash] = new PlayerDashState(context, this);
        _states[PlayerStates.climb] = new PlayerClimbState(context, this);
    }

    public PlayerBaseState Idle()
    {
        return _states[PlayerStates.idle];
    }

    public PlayerBaseState Run()
    {
        return _states[PlayerStates.run];
    }

    public PlayerBaseState Jump()
    {
        return _states[PlayerStates.jump];
    }

    public PlayerBaseState Grounded()
    {
        return _states[PlayerStates.grounded];
    }

    public PlayerBaseState Air()
    {
        return _states[PlayerStates.air];
    }

    public PlayerBaseState Dash()
    {
        return _states[PlayerStates.dash];
    }

    public PlayerBaseState Climb()
    {
        return _states[PlayerStates.climb];
    }
}
