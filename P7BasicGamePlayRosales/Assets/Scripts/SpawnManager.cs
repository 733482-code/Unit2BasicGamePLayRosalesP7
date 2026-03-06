using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalsPrefabs;
    public int animalIndex;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.S))
        {
            Instantiate(animalsPrefabs[animalIndex], new Vector3(0, 0, 20), animalsPrefabs[animalIndex].transform.rotation);
        }
    }
}
