using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{
    public Image[] heartImages;
    private int maxHearts;  // Maximum number of hearts

    // Start is called before the first frame update
    void Start()
    {
        maxHearts = heartImages.Length;
    }

    // Update the Health UI based on the player's current and max health
    public void UpdateHealthUI(int currentHealth, int maxHealth)
    {
        int heartsToShow = Mathf.CeilToInt((float)currentHealth / (float)maxHealth * maxHearts);

        for (int i = 0; i < maxHearts; i++)
        {
            heartImages[i].enabled = i < heartsToShow;
        }
    }

    // Check if there's room to gain another heart
    public bool CanGainHeart()
    {
        // Check if any heart is not enabled (indicating an empty heart slot)
        return System.Array.Exists(heartImages, heart => !heart.enabled);
    }
}
