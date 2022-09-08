using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemHolder : MonoBehaviour, IInteractible
{
    [SerializeField] private PlayerInventory inventory;
    [SerializeField] private ItemBase currentItem;

    private void Start()
    {
        
    }

    public void Interact()
    {
        if (inventory.AddItem(currentItem))
            Destroy(gameObject);
    }
}
