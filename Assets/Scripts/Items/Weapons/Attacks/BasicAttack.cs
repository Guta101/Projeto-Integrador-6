using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BasicAttack : MonoBehaviour
{
    public ItemWeaponData weaponData;
    public Vector3 direction;

    public void Init(Vector3 direction, ItemWeaponData weaponData)
    {
        this.direction = direction;
        this.weaponData = weaponData;
    }
}
