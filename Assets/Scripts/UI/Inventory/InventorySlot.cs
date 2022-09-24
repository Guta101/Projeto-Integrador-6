using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    private Transform canvasTransform;
    private ItemInterface item;
    [SerializeField] private ItemActionMenu menu;

    public void Init(ItemInterface item, Transform canvasTransform)
    {
        this.canvasTransform = canvasTransform;
        this.item = item;
    }

    public void GenMenu()
    {
        ItemActionMenu menuInstance = Instantiate(menu, transform.position, transform.rotation, canvasTransform);
        menuInstance.Init(item);
    }
}
