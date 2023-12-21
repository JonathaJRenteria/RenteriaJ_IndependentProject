using UnityEngine;

public class AttributesManager : MonoBehaviour
{
    public int health = 30;  // Initial health
    public int maxHealth = 30;  // Maximum health

    public GameManager gameManager;
    public HealthUI healthUI;  // Reference to the HealthUI script or component

    private bool isDead;

    // Called when the player takes damage
    public void TakeDamage(int amount)
    {
        // Modify this method to include any logic related to taking damage
        health -= amount;

        // Update Health UI
        if (healthUI != null)
        {
            healthUI.UpdateHealthUI(health, maxHealth);
        }

        // Check if health is zero or less
        if (health <= 0 && !isDead)
        {
            isDead = true;
            gameObject.SetActive(false);
            gameManager.gameOver();
            Die(); // Call the Die method when health is zero or less
        }

        // Add any additional logic here, such as triggering animations, etc.
    }

    // Method to handle player death
    private void Die()
    {
        Debug.Log("Player has died.");
        gameObject.SetActive(false);
        gameManager.gameOver("GameOverScene");
    }

    // Method to restore health
    public void RestoreHealth(int amount)
    {
        // Add logic to ensure health doesn't exceed maxHealth
        health += amount;
        if (health > maxHealth)
        {
            health = maxHealth;
        }

        // Update Health UI
        if (healthUI != null)
        {
            healthUI.UpdateHealthUI(health, maxHealth);
        }
    }
}





