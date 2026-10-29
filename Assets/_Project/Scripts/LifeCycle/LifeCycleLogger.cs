using UnityEngine;

public class LifeCycleLogger : MonoBehaviour
{
    // Awake è eseguito solo alla prima attivazione in scena dell'oggetto
    void Awake()
    {
        Debug.Log($"Eseguo Awake {gameObject.name}");    // print in C#
    }

    // OnEnable è eseguito solo al primo avvio della scena
    void OnEnable()
    {
        Debug.Log($"Eseguo OnEnable {gameObject.name}");
    }
    // Start è eseguito solo al primo avvio della scena
    void Start()
    {
        Debug.Log($"Eseguo Start {gameObject.name}");
    }

    // FixedUpdate è chiamato a intervalli fissi mente l'oggetto e attivo
    void FixedUpdate()
    {
        Debug.Log($"Eseguo FixedUpdate {gameObject.name}");
    }

    // Update aggiorna ad ogni frame
    void Update()
    {
        Debug.Log($"Eseguo Update {gameObject.name}");
    }

    // LateUpdate è chiamato al termine del ciclo Update/FixedUpdate come
    void LateUpdate()
    {
        Debug.Log($"Eseguo LateUpdate {gameObject.name}");
    }

    // OnDestroy è chiamato alla distruzione dell'oggetto
    void OnDestroy()
    {
        Debug.Log($"Eseguo OnDestroy {gameObject.name}");
    }
}