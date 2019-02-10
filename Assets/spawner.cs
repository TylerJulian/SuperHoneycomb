using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    // Start is called before the first frame update
    public float spawnRate = .25f;
    public GameObject hexagonPrefab;
    private float nexTimeToSpawn = 0f;
      
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nexTimeToSpawn)
        {
            Instantiate(hexagonPrefab, Vector3.zero, Quaternion.identity);
            nexTimeToSpawn = Time.time + 1f / spawnRate;

        }
    }
}
