using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotarConMouse : MonoBehaviour
{
   [SerializeField] private float velocidadRotacion = 500f;

    void Update()
    {
        float scrollInput = Input.GetAxis("Mouse ScrollWheel");

        if (scrollInput != 0f)
        {
           
            float grados = -scrollInput * velocidadRotacion * Time.deltaTime;
            
            transform.Rotate(0f, 0f, grados);
        }
    }
}
