using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    private ItemInterface item;
    [SerializeField] private ItemActionMenu menu;

    public void Init(ItemInterface item)
    {
        this.item = item;
    }

    public void GenMenu()
    {
        ItemActionMenu menuInstance = Instantiate(menu, transform);
        menuInstance.Init(item);
    }
}
