using UnityEngine;

public class DestoryOutOfBounds : MonoBehaviour
{
    private float topBound = 30;
    private float lowerbound = -10;
    private float sideBound = 30;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // if an object goes past the players view in the game, remove that object
        if (transform.position.z > topBound || transform.position.z < lowerbound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.x > sideBound || transform.position.x < -sideBound)
        {
            GameObject.Find("GameManager").GetComponent<GameManager>().UpdateLives(-1);
            Destroy(gameObject);
        }
    }
}
