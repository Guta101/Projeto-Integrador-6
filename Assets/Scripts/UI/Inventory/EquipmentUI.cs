using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentUI : MonoBehaviour
{
    [SerializeField] private PlayerInventory inventory;
    [SerializeField] private EquipmentSlot equipSlot;

    private void OnEnable()
    {
        GenEquipment();
    }

    private void GenEquipment()
    {
        foreach (PlayerEquippablePart part in inventory.PlayerCurrentParts.Arms)
        {
            EquipmentSlot newSlot = Instantiate(equipSlot, transform);
            newSlot.Init(part);
        }
    }
}
