using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponHolder : MonoBehaviour, IInteractible
{
    [SerializeField] private PlayerInventory inventory;
    [SerializeField] private WeaponInterface currentWeapon;
    [SerializeField] private WeaponsList weapons;

    private void Awake()
    {
        Randomize();
    }

    public void Interact()
    {
        if (inventory.AddItem(currentWeapon))
            Destroy(gameObject);
    }

    private void Randomize()
    {
        int index = Random.Range(0, weapons.weaponsList.Count);
        currentWeapon = new BasicShooter(weapons.weaponsList[index]);
    }
}
