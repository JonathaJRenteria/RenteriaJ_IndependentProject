// CherryInteraction.cs
using UnityEngine;

public class CherryInteraction : MonoBehaviour
{
    public CherryUI cherryUI; // This line is likely already in your script

    private bool hasInteracted = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !hasInteracted)
        {
            GameObject cherryBomb = GameObject.Find("cherry_bomb"); // Replace with the actual name
            if (cherryBomb != null && cherryBomb.activeSelf)
            {
                // Your interaction logic here

                cherryUI.ShowCherry(); // Show the UI after interaction
                hasInteracted = true;

                // Check if the cherry has been collected
                bool hasCollectedCherry = /* Your logic to check if the cherry has been collected */ true;

                if (hasCollectedCherry)
                {
                    // Call the GameManager to indicate cherry collection
                    GameManager gameManager = FindObjectOfType<GameManager>();
                    if (gameManager != null)
                    {
                        gameManager.hasCollectedCherry = true;
                    }
                }
            }
        }
    }
}
















