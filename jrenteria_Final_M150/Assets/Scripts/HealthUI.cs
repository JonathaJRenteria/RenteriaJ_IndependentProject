using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{
    public Image[] heartImages;

    // Update the Health UI based on the player's current and max health
    public void UpdateHealthUI(int currentHealth, int maxHealth)
    {
        int heartsToShow = Mathf.CeilToInt((float)currentHealth / (float)maxHealth * heartImages.Length);

        for (int i = 0; i < heartImages.Length; i++)
        {
            heartImages[i].enabled = i < heartsToShow;
        }
    }
}