using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemHolder : MonoBehaviour, IInteractible
{
    [SerializeField] private PlayerInventory inventory;
    [SerializeReference] private ItemInterface currentItem;
    [SerializeField] private EquipablesList equipables;

    private void Awake()
    {
        Randomize();
    }

    public void Interact()
    {
        if (inventory.AddItem(currentItem))
            Destroy(gameObject);
    }

    private void Randomize()
    {
        int index = Random.Range(0, equipables.equipablesList.Count - 1);
        currentItem = new EquipableStatBoost(equipables.equipablesList[index]);
        currentItem.ItemData = equipables.equipablesList[index];
        Debug.Log(currentItem.ItemData);
    }
}
