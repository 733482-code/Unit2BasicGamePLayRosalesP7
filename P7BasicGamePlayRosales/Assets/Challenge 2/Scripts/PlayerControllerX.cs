using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    // 1. Add these variables to track timing
    public float spawnInterval = 0.5f;
    private float nextSpawnTime = 0f;

    void Update()
    {
        // 2. Check if space is pressed AND if current time has passed the cooldown
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextSpawnTime)
        {
            // 3. Set the next allowed spawn time
            nextSpawnTime = Time.time + spawnInterval;

            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}

