using UnityEngine;

public abstract class WeaponInterface : EquipableInterface
{
    [SerializeField] private float _currentAmmo;
    public float CurrentAmmo { get { return _currentAmmo; } set { _currentAmmo = value; } }

    [SerializeField] private ItemWeaponData _weaponData;
    public ItemWeaponData WeaponData { get { return _weaponData; } set { _weaponData = value; } }

    public abstract void Attack();
    public abstract void Reload();
}
