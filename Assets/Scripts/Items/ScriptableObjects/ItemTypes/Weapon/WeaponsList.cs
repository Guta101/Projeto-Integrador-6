using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Items/Weapons/WeaponsList")]
public class WeaponsList : ScriptableObject
{
    [SerializeField] public List<ItemWeaponData> weaponsList;
}
