using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemActionMenu : MonoBehaviour
{
    [SerializeField] private ItemInterface item;

    [Header("Possible Buttons")]
    [SerializeField] private EquipWindow equipWindow;
    [SerializeField] private DropButton dropButton;

    public void Init(ItemInterface item)
    {
        this.item = item;
        GenButtons();
    }

    private void GenButtons()
    {
        Debug.Log(item.ItemData);
        Debug.Log(((WeaponInterface)item).ItemData);
        DropButton drop = Instantiate(dropButton, transform);
        drop.Init(item);
        if(item is EquipableInterface)
        {
            EquipWindow equip = Instantiate(equipWindow, transform);
            equip.Init((EquipableInterface)item);
        }
    }
}
