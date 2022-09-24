using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class ItemActionMenu : MonoBehaviour
{
    [SerializeReference] private PlayerEquippablePart part;
    [SerializeReference] private ItemInterface item;

    [Header("Possible Buttons")]
    [SerializeField] private ItemEquipWindow equipWindow;
    [SerializeField] private DropButton dropButton;
    [SerializeField] private UnequipButton unequipButton;

    public void Init(ItemInterface item)
    {
        this.item = item;
        GenItemButtons();
    }

    public void Init(PlayerEquippablePart part)
    {
        this.part = part;
        GenEquipButtons();
    }

    //  Generates buttons for item in invetory
    private void GenItemButtons()
    {
        DropButton drop = Instantiate(dropButton, transform);
        drop.Init(item);
        if(item is EquipableInterface)
        {
            ItemEquipWindow equip = Instantiate(equipWindow, transform);
            equip.Init((EquipableInterface)item);
        }
    }

    //  Generates buttons for already equipped items
    private void GenEquipButtons()
    {
        UnequipButton unequip = Instantiate(unequipButton, transform);
        unequip.Init(part);
    }

    private void DestroyMenu()
    {
        Destroy(gameObject);
    }
}
