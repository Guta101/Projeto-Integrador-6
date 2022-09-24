using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(menuName = "Player/PlayerInventory")]
public class PlayerInventory : ScriptableObject
{
    [SerializeField] private int maxCapacity;

    //  List of equippable parts
    public PlayerCurrentParts PlayerCurrentParts;
    //  List of items in inventory
    [SerializeReference]
    public List<ItemInterface> Items = new List<ItemInterface>();
    //  Events
    [SerializeField] private GameEvent itemChange;
    [SerializeField] private GameEvent itemEquip;

    public bool AddItem(ItemInterface item)
    {
        if (Items.Count < maxCapacity)
        {
            Items.Add(item);
            itemChange.Raise();
            return true;
        }
        else
            return false;
    }

    public void RemoveItem(ItemInterface item)
    {
        Items.Remove(item);
        itemChange.Raise();
    }

    public void EquipItem(EquipableInterface item, PlayerEquippablePart part)
    {
        RemoveItem(item);
        if (part.EquippedItem != null)
            UnequipItem(part);
        part.EquippedItem = item;
        part.EquippedItem.EquipEffect();
        itemEquip.Raise();
    }

    public void UnequipItem(PlayerEquippablePart part)
    {
        AddItem(part.EquippedItem);
        part.EquippedItem.UnequipEffect();
        part.EquippedItem = null;
        itemEquip.Raise();
    }
}
