using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int lives = 3;
    public int score = 0;

    // This runs as soon as you press Play
    void Start()
    {
        // Requirement: At the start, display Lives = 3 and Score = 0
        Debug.Log("Lives = " + lives + " Score = " + score);
    }

    // Call this function when you feed an animal
    public void AddScore(int value)
    {
        score += value;
        // Requirement: Increase and display the Score
        Debug.Log("Score = " + score);
    }

    // Call this function when you miss an animal or get hit
    public void UpdateLives(int value)
    {
        lives += value; // value should be -1 to decrease

        // Requirement: Decrease and display the Lives
        Debug.Log("Lives = " + lives);

        // Requirement: When Lives reach 0, log "Game Over"
        if (lives <= 0)
        {
            Debug.Log("Game Over");
            lives = 0; // Stop lives from going below zero
        }
    }
}
