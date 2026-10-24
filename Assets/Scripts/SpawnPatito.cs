using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPatito : MonoBehaviour
{
    [SerializeField] GameObject patoPrefab;
    [SerializeField] float spawnPeriod = 2f;

    float timeStamp;

    void Start()
    {
        timeStamp = Time.time;
    }

    void Update()
    {
        if (Time.time - timeStamp > spawnPeriod)
        {
            // 1. Instanciamos el pato guardándolo en una variable
            GameObject nuevoPato = Instantiate(patoPrefab, transform.position, transform.rotation);

            // 2. Buscamos el GameManager en la escena y registramos el pato en su colección
            GameManager gm = FindObjectOfType<GameManager>();
            if (gm != null)
            {
                gm.RegistrarPato(nuevoPato);
            }

            timeStamp = Time.time;
        }
    }
}