using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiraIsometrica : MonoBehaviour
{
    [SerializeField] private PlayerController playerController;
    [SerializeField] private Rigidbody rB;
    [SerializeField] private Camera mainCamera;
    [SerializeField] private Vector2 mousePosition;

    private void Update()
    {
        mousePosition = mainCamera.ScreenToWorldPoint(playerController.PlayerInput.Player.Look.ReadValue<Vector2>());
    }

    private void FixedUpdate()
    {
        transform.position = new Vector3(mousePosition.x, 0, mousePosition.y);

    }


}