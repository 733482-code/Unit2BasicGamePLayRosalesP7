using UnityEngine;

public class Pizza : MonoBehaviour
{
    public int feedAmount = 1;

    private void OnTriggerEnter(Collider other)
    {
        AnimalHunger animal = other.GetComponent<AnimalHunger>();

        if (animal != null)
        {
            animal.FeedAnimal(feedAmount);
            Destroy(gameObject);
        }
    }
}
