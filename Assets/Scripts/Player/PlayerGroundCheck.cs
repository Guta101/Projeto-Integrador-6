using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGroundCheck : MonoBehaviour
{
    [SerializeField] LayerMask groundLayer;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private float groundRadius;
    public bool IsGrounded { get; private set; }

    // Update is called once per frame
    void Update()
    {
        IsGrounded = Physics.CheckSphere(groundCheck.position, groundRadius, groundLayer);
    }
}
