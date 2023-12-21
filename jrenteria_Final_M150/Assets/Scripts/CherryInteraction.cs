// CherryInteraction.cs
using UnityEngine;

public class CherryInteraction : MonoBehaviour
{
    public CherryUI cherryUI;

    private bool hasInteracted = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !hasInteracted)
        {
            GameObject cherryBomb = GameObject.Find("cherry_bomb"); // Replace with the actual name
            if (cherryBomb != null && cherryBomb.activeSelf)
            {
                cherryUI.ShowCherry();
                hasInteracted = true;
            }
        }
    }
}











