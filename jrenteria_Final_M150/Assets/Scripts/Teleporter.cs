using System.Collections;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    [SerializeField] private Transform teleporter;
    [SerializeField] private GameObject player;
    [SerializeField] private float teleportDelay = 1f; // Adjust this value for teleport delay

    private Vector3 playerInitialPosition;
    private Quaternion playerInitialRotation;
    private CharacterController characterController;

    private bool isTeleporting = false;

    private void Start()
    {
        // Store the player's initial position and rotation
        playerInitialPosition = player.transform.position;
        playerInitialRotation = player.transform.rotation;
        characterController = player.GetComponent<CharacterController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !isTeleporting) // Ensure the colliding object is the player and not currently teleporting
        {
            StartCoroutine(TeleportCoroutine());
        }
    }

    private IEnumerator TeleportCoroutine()
    {
        // Store the initial state of the CharacterController
        bool wasEnabled = characterController.enabled;

        // Set a flag to prevent teleporting again before completion
        isTeleporting = true;

        // Disable the CharacterController temporarily during teleportation
        characterController.enabled = false;

        // Teleport the player to the teleporter destination after a delay
        yield return new WaitForSeconds(teleportDelay);

        // Reset the player's position and rotation
        player.transform.position = teleporter.position;
        player.transform.rotation = playerInitialRotation;

        // Re-enable the CharacterController after teleportation
        characterController.enabled = wasEnabled;

        // Allow some time for the CharacterController to re-apply gravity
        yield return new WaitForSeconds(0.1f);

        // Unlock the cursor (if using a first-person controller)
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        // Reset the teleporting flag to allow teleportation again
        isTeleporting = false;
    }
}



