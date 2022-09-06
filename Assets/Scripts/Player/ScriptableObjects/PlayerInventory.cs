using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(menuName = "Player/PlayerInventory")]
public class PlayerInventory : ScriptableObject
{
    [SerializeField] private int maxCapacity;

    //  List of equippable parts
    public List<PlayerEquippablePart> PlayerParts = new List<PlayerEquippablePart>();
    //  List of items in inventory
    public List<ItemBase> Items = new List<ItemBase>();

    public void AddItem(ItemBase item)
    {
        if (Items.Count < maxCapacity)
            Items.Add(item);
    }

    public void RemoveItem(ItemBase item)
    {
        Items.Remove(item);
    }

    public void EquipItem(ItemEquip item, PlayerEquippablePart part)
    {
        part.Equip(item);
    }

    public void UnequipItem(ItemEquip item, PlayerEquippablePart part)
    {
        part.Equip(item);
    }
}
