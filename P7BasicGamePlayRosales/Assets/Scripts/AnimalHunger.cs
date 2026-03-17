using UnityEngine;
using UnityEngine.UI;

public class AnimalHunger : MonoBehaviour
{
    public Slider hungerSlider;
    public int amountToBeFed;
    private int currentFedAmount = 0;

    private GameManager gameManager;

    void Start()
    {
        // Link the slider to the animal's specific needs
        hungerSlider.maxValue = amountToBeFed;
        hungerSlider.value = 0;
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    public void FeedAnimal(int amount)
    {
        currentFedAmount += amount;
        hungerSlider.value = currentFedAmount;

        if (currentFedAmount >= amountToBeFed)
        {
            gameManager.AddScore(amountToBeFed); // More food = more points!
            Destroy(gameObject);
        }
    }
}
