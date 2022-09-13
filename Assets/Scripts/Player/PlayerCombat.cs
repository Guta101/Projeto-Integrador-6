using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    [SerializeField] private PlayerInventory inventory;
    [SerializeField] private PlayerController controller;

    private void OnEnable()
    {
        controller.PlayerInput.Player.Fire.performed += _ => AttackHandler();
    }

    private void OnDisable()
    {
        controller.PlayerInput.Player.Fire.performed += _ => AttackHandler();
    }

    private void AttackHandler()
    {

    }

    private void Attack(ItemWeaponData weapon)
    {
        
    }
}
