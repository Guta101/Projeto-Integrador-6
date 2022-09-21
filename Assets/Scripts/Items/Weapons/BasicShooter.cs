using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BasicShooter : WeaponInterface
{
    public BasicShooter(ItemWeaponData weaponData)
    {
        ItemData = weaponData;
        CurrentAmmo = weaponData.MagSize;
    }

    public override void Attack(Transform attackPoint)
    {
        if (CurrentAmmo > 0)
        {
            BasicAttack oAttack = GameObject.Instantiate(ItemData.Attack, attackPoint.position, attackPoint.rotation);
            oAttack.Init(attackPoint.position, ItemData);
            CurrentAmmo--;
        }
        
    }

    public override void Reload()
    {
        CurrentAmmo = ItemData.MagSize;
    }

    public override void EquipEffect()
    {
        
    }

    public override void UnequipEffect()
    {
        
    }
}
