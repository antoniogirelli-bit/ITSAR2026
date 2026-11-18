using UnityEngine;

public class BeamWeapon : Weapon
{
    [SerializeField]LineRenderer lineRenderer;
    [SerializeField] Transform muzzle;
    [SerializeField] Color startColor = Color.red;
    [SerializeField] Color endColor = Color.purple;
        
}
