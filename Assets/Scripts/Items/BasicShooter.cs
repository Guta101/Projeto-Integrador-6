using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BasicShooter : WeaponInterface
{
    public BasicShooter(ItemWeaponData weaponData)
    {
        WeaponData = weaponData;
        CurrentAmmo = weaponData.MagSize;
    }

    public override void Attack()
    {
        Debug.Log("Bang! " + WeaponData.BaseDamage + " Damage!");
    }

    public override void Reload()
    {
        
    }

    public override void EquipEffect()
    {
        
    }

    public override void UnequipEffect()
    {
        
    }
}
