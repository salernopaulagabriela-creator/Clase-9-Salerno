using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverPatitos : MonoBehaviour
{
    [SerializeField] float velocidad = 3f;

    void Update()
    {
        transform.Translate(Vector3.right * velocidad * Time.deltaTime);
    }
}
