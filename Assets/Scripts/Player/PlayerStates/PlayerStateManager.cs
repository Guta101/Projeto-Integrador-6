using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerStateManager : MonoBehaviour
{
    //  Reference variables
    public PlayerController Controller { get; private set; }
    public Rigidbody2D PlayerRB { private set; get; }
    [SerializeField]
    GameObject _groundCheck;
    [SerializeField]
    LayerMask _groundLayer;
    
    //  Input values
    public Vector2 CurrentMovementInput { get; set; }
    public Vector2 AppliedMovementInput { get; set; }
    public Vector2 SmoothedInputVector { get; set; }
    public bool IsRunPressed { get; private set; }
    public bool IsJumpPressed { get; private set; }
    public bool IsDodgePressed { get; private set; }

    //  Movement speed values
    public float PlayerSpeed { get; set; } = 9f;
    private Vector2 _smoothInputVelocity;
    private float _smoothInputSpeed = 0.1f;
    private float _acceleration = 13f;
    private float _decceleration = 14f;
    private float _velPower = 0.96f;


    //  Jump variables
    [SerializeField]
    private float _checkGroundRadius = .1f;
    public bool IsGrounded { get; private set; }
    public float JumpForce { get; set; } = 6f;

    //  Dodge variables
    public float DodgeForce { get; set; } = 10f;

    //  State variables
    public PlayerBaseState CurrentState { get; set; }
    PlayerStateFactory _states;


    //  MonoBehaviour stuff
    void Awake()
    {
        //  Get component
        Controller = GetComponent<PlayerController>();
        PlayerRB = GetComponent<Rigidbody2D>();

        //  Setup state
        _states = new PlayerStateFactory(this);
        CurrentState = _states.Grounded();
        CurrentState.EnterState();
    }

    void Update()
    {
        CurrentState.UpdateStates();
        HandleInput();
        CheckGround();
    }

    void FixedUpdate()
    {
        HandleMovement();
    }

    //  Movement
    private void HandleInput()
    {
        CurrentMovementInput = Controller.PlayerInput.Player.Move.ReadValue<Vector2>();
        SmoothedInputVector = Vector2.SmoothDamp(SmoothedInputVector, AppliedMovementInput, ref _smoothInputVelocity, _smoothInputSpeed);
        IsRunPressed = Controller.PlayerInput.Player.Move.IsPressed();
        IsJumpPressed = Controller.PlayerInput.Player.Jump.IsPressed();
        IsDodgePressed = Controller.PlayerInput.Player.Dodge.IsPressed();
    }

    private void HandleMovement()
    {
        float targetSpeed = CurrentMovementInput.x * PlayerSpeed;
        float speedDif = targetSpeed - PlayerRB.velocity.x;
        float accelRate = (Mathf.Abs(targetSpeed) > 0.01f) ? _acceleration : _decceleration;
        float movement = Mathf.Pow(Mathf.Abs(speedDif) * accelRate, _velPower) * Mathf.Sign(speedDif);
        PlayerRB.AddForce(movement * Vector2.right);
    }

    //  Jump
    private void CheckGround()
    {
        if (Physics2D.OverlapCircle(_groundCheck.transform.position, _checkGroundRadius, _groundLayer))
            IsGrounded = true;
        else
            IsGrounded = false;
    }

}
