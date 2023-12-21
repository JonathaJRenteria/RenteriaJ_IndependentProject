using UnityEngine;

public class PowerUpInteraction : MonoBehaviour
{
    public int healthRestoreAmount = 10;  // Adjust this value based on your design
    public HealthUI healthUI;  // Make sure to assign this reference in the Inspector

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            AttributesManager attributesManager = other.GetComponent<AttributesManager>();

            if (attributesManager != null && healthUI != null)
            {
                Debug.Log("Current Health: " + attributesManager.health);
                Debug.Log("Max Health: " + attributesManager.maxHealth);
                Debug.Log("Can Gain Heart: " + healthUI.CanGainHeart());

                if (healthUI.CanGainHeart())
                {
                    Debug.Log("Player can gain a heart. Restoring health!");
                    attributesManager.RestoreHealth(healthRestoreAmount);
                    healthUI.UpdateHealthUI(attributesManager.health, attributesManager.maxHealth);
                    Destroy(gameObject);
                }
                else
                {
                    Debug.Log("Player cannot gain a heart.");
                }
            }
        }
    }
}
