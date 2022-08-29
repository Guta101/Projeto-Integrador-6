public class PlayerStateFactory
{
    PlayerStateManager _context;

    public PlayerStateFactory(PlayerStateManager currentContext)
    {
        _context = currentContext;
    }

    public PlayerBaseState Idle()
    {
        return new PlayerIdleState(_context, this);
    }

    public PlayerBaseState Run()
    {
        return new PlayerRunningState(_context, this);
    }

    public PlayerBaseState Dodge()
    {
        return new PlayerDodgingState(_context, this);
    }

    public PlayerJumpingState Jump()
    {
        return new PlayerJumpingState(_context, this);
    }

    public PlayerGroundedState Grounded()
    {
        return new PlayerGroundedState(_context, this);
    }

    public PlayerAirState Air()
    {
        return new PlayerAirState(_context, this);
    }
}
