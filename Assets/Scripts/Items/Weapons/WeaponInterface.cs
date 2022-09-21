using UnityEngine;

public abstract class WeaponInterface : EquipableInterface
{
    [SerializeField] private float _currentAmmo;
    public float CurrentAmmo { get { return _currentAmmo; } set { _currentAmmo = value; } }

    private ItemWeaponData _itemData;
    public new ItemWeaponData ItemData { get { return _itemData; } set { _itemData = value; } }

    public abstract void Attack(Transform attackPoint);
    public abstract void Reload();
}
