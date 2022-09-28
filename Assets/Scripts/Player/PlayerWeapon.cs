using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon : MonoBehaviour
{
    [SerializeReference] private WeaponInterface weapon;
    [SerializeField] private Transform attackPoint;
    [SerializeField] private WeaponsList weapons;
    private bool canAttack = true;
    private bool isReloading = false;

    private void Awake()
    {
        int index = Random.Range(0, weapons.weaponsList.Count);
        weapon = new BasicShooter(weapons.weaponsList[index]);
    }

    public void Attack()
    {
        if (canAttack)
        {
            weapon.Attack(attackPoint);
            canAttack = false;
            StartCoroutine(AttackCdTimer());
        }
    }

    public void Reload()
    {
        if (!isReloading)
            StartCoroutine(ReloadTimer());
    }

    IEnumerator AttackCdTimer()
    {
        yield return new WaitForSeconds(weapon.ItemData.AttackSpeed);
        canAttack = true;
    }

    IEnumerator ReloadTimer()
    {
        isReloading = true;
        yield return new WaitForSeconds(weapon.ItemData.ReloadSpeed);
        weapon.Reload();
        isReloading = false;
    }
}
