using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon : MonoBehaviour
{
    private WeaponInterface weapon;
    [SerializeField] private Transform attackPoint;
    [SerializeField] private WeaponsList weapons;

    private void Awake()
    {
        int index = Random.Range(0, weapons.weaponsList.Count);
        weapon = new BasicShooter(weapons.weaponsList[index]);
    }

    public void Attack()
    {
        weapon.Attack(attackPoint);
    }

    public void Reload()
    {
        weapon.Reload();
    }
}
