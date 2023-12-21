using UnityEngine;

public class CherryCollector : MonoBehaviour
{
    public CherryUI cherryUI;

    public void OnTriggerEnter(Collider other)
    {
        // Check if the collider has the "Cherry" tag
        if (other.CompareTag("Cherry"))
        {
            // Handle the cherry collection logic here
            // For example, you can deactivate the cherry object
            other.gameObject.SetActive(false);

            // Add any other logic you need
        }
    }

    private void CollectCherry(GameObject cherry)
    {
        // Perform cherry collection logic

        // Show cherry in the UI
        cherryUI.ShowCherry();

        // Destroy the cherry GameObject
        Destroy(cherry);
    }
}
