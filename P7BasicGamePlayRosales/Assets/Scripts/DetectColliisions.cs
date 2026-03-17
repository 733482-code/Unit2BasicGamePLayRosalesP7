using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        // If the projectile hits an animal
        if (other.CompareTag("Animal"))
        {
            // Get the Hunger script from the animal and feed it
            other.GetComponent<AnimalHunger>().FeedAnimal(1);

            // Destroy ONLY the projectile (this script's object)
            Destroy(gameObject);
        }
    }
}
