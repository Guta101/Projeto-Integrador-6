using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    [SerializeField] private Transform canvasTransform;
    [SerializeField] private InventorySlot itemSlot;
    [SerializeField] private PlayerInventory inventory;
    [SerializeField] private List<InventorySlot> inventorySlots;

    private void OnEnable()
    {
        GenInventory();
    }

    private void OnDisable()
    {
        DestroyInventory();
    }

    private void GenInventory()
    {
        foreach (ItemInterface item in inventory.Items)
        {
            InventorySlot newSlot = Instantiate(itemSlot, transform);
            newSlot.Init(item, canvasTransform);
            inventorySlots.Add(newSlot);
        }
    }

    private void DestroyInventory()
    {
        foreach (InventorySlot slot in inventorySlots)
        {
            Destroy(slot.gameObject);
        }
        inventorySlots.Clear();
    }

    public void UpdateInventory()
    {
        DestroyInventory();
        GenInventory();
    }
}
