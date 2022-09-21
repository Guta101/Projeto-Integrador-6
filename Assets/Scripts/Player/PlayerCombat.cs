using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    [SerializeField] private PlayerInventory inventory;
    [SerializeField] private PlayerController controller;
    [SerializeField] private PlayerWeapon weapon;

    private void OnEnable()
    {
        controller.PlayerInput.Player.Fire.performed += _ => AttackHandler();
        controller.PlayerInput.Player.Reload.performed += _ => ReloadHandler();
    }

    private void OnDisable()
    {
        controller.PlayerInput.Player.Fire.performed += _ => AttackHandler();
        controller.PlayerInput.Player.Reload.performed -= _ => ReloadHandler();
    }

    private void AttackHandler()
    {
        weapon.Attack();
    }

    private void ReloadHandler()
    {
        weapon.Reload();
    }
}
