using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemHolder : MonoBehaviour, IInteractible
{
    [SerializeField] private PlayerInventory inventory;
    [SerializeField] private ItemInterface currentItem;

    private void Awake()
    {
        
    }

    public void Interact()
    {
        if (inventory.AddItem(currentItem))
            Destroy(gameObject);
    }
}
