using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnequipButton : MonoBehaviour
{
    [SerializeField] private GameEvent itemEquip;
    [SerializeField] private PlayerEquippablePart part;
    [SerializeField] private EquipableInterface item;
    [SerializeField] private PlayerInventory playerInventory;

    public void Init(PlayerEquippablePart part)
    {
        this.part = part;
    }

    public void Unequip()
    {
        playerInventory.UnequipItem(part);
    }
}
