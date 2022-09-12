using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Items/Weapons/WeaponData")]
public class ItemWeaponData : ItemEquipData
{
    [SerializeField] private float baseDamage;
    [SerializeField] private float attackSpeed;
    [SerializeField] private float reloadSpeed;
    [SerializeField] private float magSize;

    public float BaseDamage { get { return baseDamage; } }
    public float AttackSpeed { get { return attackSpeed; } }
    public float ReloadSpeed { get { return reloadSpeed; } }
    public float MagSize { get { return magSize; } }
}
