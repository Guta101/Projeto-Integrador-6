using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropButton : MonoBehaviour
{
    [SerializeField] private WeaponHolder weaponHolder;
    [SerializeField] private PlayerInventory inventory;
    [SerializeField] private ItemInterface item;

    public void Init(ItemInterface item)
    {
        this.item = item;
    }

    public void Drop()
    {
        inventory.RemoveItem(item);
        //Instantiate(weaponHolder, transform);
    }
}
