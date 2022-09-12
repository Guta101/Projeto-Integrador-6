using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Player/EquippablePart")]
public class PlayerEquippablePart : ScriptableObject
{
    public string Name;
    public int Amount;
    //  List of items equipped
    public List<EquipableInterface> EquippedItems = new List<EquipableInterface>();

    public void Equip(EquipableInterface item)
    {
        EquippedItems.Add(item);
        item.EquipEffect();
    }

    public void Unequip(EquipableInterface item)
    {
        EquippedItems.Remove(item);
        item.UnequipEffect();
    }
}
