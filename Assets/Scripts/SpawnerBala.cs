using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBala : MonoBehaviour
{
  [SerializeField] private GameObject balaPrefab; 
  [SerializeField] private float tiempoEntreDisparos = 1.5f;
  [SerializeField] private Transform puntoDisparo;

    void Start()
    {
        StartCoroutine(GenerarBalas());
    }

    IEnumerator GenerarBalas()
    {
        while (true)
        {
            Instantiate(balaPrefab, puntoDisparo.position, puntoDisparo.rotation);

            yield return new WaitForSeconds(tiempoEntreDisparos);
        }
    }
}
