using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttributesManager : MonoBehaviour
{
    public int health;

    private bool isDead;

    public GameManager gameManager;

    // Called when the player takes damage
    public void TakeDamage(int amount)
    {
        // Modify this method to include any logic related to taking damage
        health -= amount;
        Debug.Log("Player took damage. Current health: " + health);

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
}
