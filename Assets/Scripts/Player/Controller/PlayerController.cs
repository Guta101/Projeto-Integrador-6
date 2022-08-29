using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Player/PlayerController")]
public class PlayerController : ScriptableObject
{
    public PlayerInputMap PlayerInput { get; private set; }

    private void OnEnable()
    {
        PlayerInput = new PlayerInputMap();
        PlayerInput.Enable();
    }

    private void OnDisable()
    {
        PlayerInput.Disable();
    }
}
