using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPatito : MonoBehaviour
{
   [SerializeField] GameObject patoPrefab;
   [SerializeField] float spawnPeriod = 2f;

    float timeStamp;

    // Start is called before the first frame update
    void Start()
    {
        timeStamp = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - timeStamp > spawnPeriod)
        {
            Instantiate(patoPrefab, transform.position, Quaternion.identity);
            timeStamp = Time.time;
        }
    }
}
