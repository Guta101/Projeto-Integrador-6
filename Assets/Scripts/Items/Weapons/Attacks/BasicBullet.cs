using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicBullet : BasicAttack
{
    [SerializeField] private Rigidbody bulletRB;

    private void FixedUpdate()
    {
        MoveBullet();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.GetComponent<IDamageable>() != null)
        {
            collision.gameObject.GetComponent<IDamageable>().TakeDamage(weaponData.BaseDamage);
        }
        Destroy(gameObject);
    }

    private void MoveBullet()
    {
        bulletRB.velocity = transform.forward * weaponData.BulletSpeed;
    }
}
