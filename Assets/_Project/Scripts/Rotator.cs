using UnityEngine;

public class Rotator : MonoBehaviour
{
    [Header("Rotazione")]
    [Tooltip("Velocità di rotazione in gradi al secondo. Valori negativi invertono il verso.")]
    [SerializeField] private float rotationSpeed = 45f;

    [Tooltip("Ruota nello spazio locale (true) o nello spazio mondo (false).")]
    [SerializeField] private bool useLocalSpace = true;

    private void Update()
    {
        Space space = useLocalSpace ? Space.Self : Space.World;
        transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f, space);
    }
}