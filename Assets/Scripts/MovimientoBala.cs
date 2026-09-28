using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoBala : MonoBehaviour
{
   [SerializeField] float speed = 10f;

    void Start()
    {
        Destroy(gameObject, 5f);
    }

    void Update()
    {
        // Cambiamos Vector3.right por Vector3.up para que vaya hacia arriba
        transform.Translate(Vector3.up * speed * Time.deltaTime, Space.Self);
    }
}
