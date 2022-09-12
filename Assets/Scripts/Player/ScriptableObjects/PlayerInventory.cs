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
    [SerializeReference]
    public List<ItemInterface> Items = new List<ItemInterface>();

    public bool AddItem(ItemInterface item)
    {
        if (Items.Count < maxCapacity)
        {
            Items.Add(item);
            return true;
        }
        else
            return false;
    }

    public void RemoveItem(ItemInterface item)
    {
        Items.Remove(item);
    }

    public void EquipItem(EquipableInterface item, PlayerEquippablePart part)
    {
        part.Equip(item);
    }

    public void UnequipItem(EquipableInterface item, PlayerEquippablePart part)
    {
        part.Equip(item);
    }
}
