using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySlot : MonoBehaviour
{
    private ItemInterface item;
    private ItemBaseData itemData;

    public void Init(ItemInterface item)
    {
        this.item = item;
    }
}
