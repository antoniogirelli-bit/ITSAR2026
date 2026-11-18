using UnityEngine;

public class ProjectileWeapon : MonoBehaviour
{
    [SerializeField] Projectile projectilePrefab;
    [SerializeField] float bulletVelocity;
    [SerializeField] Transform muzzle;
    protected override void Fire()
    {
        if (projectilePrefab == null) return;
        Projectile nProjectile = Instantiate(projectilePrefab,muzzle.position,Quaternion.identity);
        Vector3 direction= targeter.Targetpoint-muzzle.position;
        Projectile nProjectile = Instantiate(projectilePrefab, muzzzle.postion, Quaternion.LookRotation));
    }
}
