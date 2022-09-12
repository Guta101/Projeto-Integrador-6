using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    [SerializeField] private InventorySlot itemSlot;
    [SerializeField] private PlayerInventory inventory;

    private void OnEnable()
    {
        GenInventory();
    }

    private void GenInventory()
    {
        foreach (ItemInterface item in inventory.Items)
        {
            InventorySlot newSlot = Instantiate(itemSlot, transform);
            newSlot.Init(item);
        }
    }
}
