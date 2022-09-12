using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField] private PlayerController controller;
    [SerializeField] private GameObject inventory;

    private void OnEnable()
    {
        controller.PlayerInput.Player.OpenInventory.performed += _ => InventoryHandler();
    }

    private void OnDisable()
    {
        controller.PlayerInput.Player.OpenInventory.performed -= _ => InventoryHandler();
    }

    private void InventoryHandler()
    {
        bool isActive = inventory.gameObject.activeSelf ? true : false;
        inventory.gameObject.SetActive(!isActive);
    }
}
