using UnityEngine;

public class SphereInteraction : MonoBehaviour
{
    public GameObject particleSystemPrefab;
    public InventoryUI inventoryUI;
    private GameManager gameManager;

    private void Start()
    {
        // Find the GameManager in the scene
        gameManager = FindObjectOfType<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();

        if (playerInventory != null)
        {
            playerInventory.SphereCollected();
            inventoryUI.UpdateSphereText(playerInventory);
            TriggerEffectAndDestroy();
        }
    }

    private void TriggerEffectAndDestroy()
    {
        // Instantiate the particle system
        GameObject particleSystemInstance = Instantiate(particleSystemPrefab, transform.position, Quaternion.identity);

        // Access the Particle System component directly
        ParticleSystem particleSystem = particleSystemInstance.GetComponent<ParticleSystem>();

        // Play the particle effect
        if (particleSystem != null)
        {
            particleSystem.Play();
        }

        // Destroy the sphere
        Destroy(gameObject);

        // Notify the GameManager that a sphere has been collected
        gameManager.CollectSphere();

        // Check if all spheres are collected
        if (gameManager.collectedSpheres >= gameManager.totalSpheres)
        {
            // Call the BeatGame method in GameManager
            gameManager.BeatGame();
        }
    }
}








