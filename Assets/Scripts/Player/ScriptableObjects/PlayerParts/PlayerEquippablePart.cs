using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Player/EquippablePart")]
public class PlayerEquippablePart : ScriptableObject
{
    public string Name;
    public int Amount;
    //  List of items equipped
    public List<ItemEquip> EquippedItems = new List<ItemEquip>();

    public void Equip(ItemEquip item)
    {
        EquippedItems.Add(item);
    }

    public void Unequip(ItemEquip item)
    {
        EquippedItems.Remove(item);
    }
}
