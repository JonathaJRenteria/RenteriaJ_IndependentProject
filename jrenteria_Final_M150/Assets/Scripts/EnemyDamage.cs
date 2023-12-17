using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public int damageAmount = 10; // Adjust the damage amount as needed

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger entered");

        // Check if the collision is with the player
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player detected");

            // Get the AttributesManager component from the player
            AttributesManager playerAttributes = other.GetComponent<AttributesManager>();

            // Check if the player has the AttributesManager component
            if (playerAttributes != null)
            {
                Debug.Log("Dealing damage to player");
                // Deal damage to the player
                playerAttributes.TakeDamage(damageAmount);
            }
        }
    }
}
