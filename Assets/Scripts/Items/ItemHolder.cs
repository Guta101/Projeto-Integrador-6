using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemHolder : MonoBehaviour, IInteractible
{
    [SerializeField] private PlayerInventory inventory;
    [SerializeReference] private ItemInterface currentItem;
    [SerializeField] private WeaponsList weapons;

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
        int index = Random.Range(0, weapons.weaponsList.Count - 1);
        currentItem = new BasicShooter(weapons.weaponsList[index]);
    }
}
