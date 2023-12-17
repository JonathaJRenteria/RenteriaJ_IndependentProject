using UnityEngine;

public class PowerUpInteraction : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Perform any actions you want when the player interacts with the power-up
            Debug.Log("Player interacted with Power Up!");

            // Destroy the Power Up sphere
            Destroy(gameObject);
        }
    }
}
