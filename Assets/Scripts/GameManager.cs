using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // La colección de patos
    public List<GameObject> listaPatos = new List<GameObject>();

    // el spawner agregua cada pato nuevo a la lista
    public void RegistrarPato(GameObject pato)
    {
        listaPatos.Add(pato);
    }

    public void CheckFinish()
    {
        int desactivados = 0;

        // bucle para revisar la lista
        foreach (GameObject pato in listaPatos)
        {
            if (pato != null && !pato.activeInHierarchy)
            {
                desactivados++;
            }
        }

        // Si más de la mitad están desactivados entonces mensaje
        if (listaPatos.Count > 0 && desactivados > listaPatos.Count / 2f)
        {
            Debug.Log("You Win");
        }
    }
}