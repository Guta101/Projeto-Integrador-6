using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //  Reference Variables
    private Rigidbody playerRB;
    [SerializeField] private PlayerStats playerStats;
    [SerializeField] private PlayerController controller;

    //  Movement speed values
    private float _acceleration = 13f;
    private float _decceleration = 14f;
    private float _velPower = 0.96f;

    //  Jump variables
    [Header("Jump")]
    [SerializeField] LayerMask groundLayer;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private float groundRadius;
    public bool IsGrounded { get; private set; }

    //  Fall variables
    [Header("Fall")]
    [SerializeField] private float _fallAcc;

    //  Monobehaviour Stuff
    private void Start()
    {
        playerRB = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        GroundCheck();
    }

    private void FixedUpdate()
    {
        HandleMovement();
        HandleJump();
        if (!IsGrounded)
            FallGravity();
    }

    //  Movement
    private void HandleMovement()
    {
        Vector2 targetSpeed = controller.PlayerInput.Player.Move.ReadValue<Vector2>() * playerStats.PlayerSpeed;
        Vector2 speedDif = targetSpeed - new Vector2(playerRB.velocity.x, playerRB.velocity.z);
        float accelrateY = (Mathf.Abs(targetSpeed.y) > 0.01f) ? _acceleration : _decceleration;
        float accelrateX = (Mathf.Abs(targetSpeed.x) > 0.01f) ? _acceleration : _decceleration;
        float movementY = Mathf.Pow(Mathf.Abs(speedDif.y) * accelrateY, _velPower) * Mathf.Sign(speedDif.y);
        float movementX = Mathf.Pow(Mathf.Abs(speedDif.x) * accelrateX, _velPower) * Mathf.Sign(speedDif.x);
        playerRB.AddForce(new Vector3(movementX, 0, movementY));
    }

    //  Jump
    private void HandleJump()
    {
        if (IsGrounded && controller.PlayerInput.Player.Jump.IsPressed())
            Jump();
    }

    private void GroundCheck()
    {
        IsGrounded = Physics.CheckSphere(groundCheck.position, groundRadius, groundLayer);
    }

    void Jump()
    {
        playerRB.velocity = new Vector3(playerRB.velocity.x, 0, playerRB.velocity.z);
        playerRB.AddForce(Vector2.up * playerStats.PlayerJumpForce, ForceMode.Impulse);
    }

    //  Gravity Stuff
    private void FallGravity()
    {
            float _newAcc = playerRB.velocity.y + _fallAcc;
            playerRB.AddForce(Vector3.down * (playerRB.velocity.y + _newAcc) / 2, ForceMode.Acceleration);
    }
}
