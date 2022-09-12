using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Player/EquippablePart")]
public class PlayerEquippablePart : ScriptableObject
{
    //  Item Equipped
    private EquipableInterface equippedItem;

    public void Equip(EquipableInterface item)
    {
        equippedItem = item;
        item.EquipEffect();
    }

    public void Unequip()
    {
        equippedItem.UnequipEffect();
        equippedItem = null;
    }
}
