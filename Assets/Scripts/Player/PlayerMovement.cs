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

    //  Monobehaviour Stuff
    private void Start()
    {
        playerRB = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        HandleMovement();
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
}
