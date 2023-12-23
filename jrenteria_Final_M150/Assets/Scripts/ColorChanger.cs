using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    // Define an array of Christmas colors
    Color[] christmasColors = { Color.red, Color.green, Color.white, Color.blue };

    // Start is called before the first frame update
    void Start()
    {
        // Call a function to change the color at a regular interval
        InvokeRepeating("ChangeColor", 0f, 2f); // Change color every 2 seconds (you can adjust this interval)
    }

    // Function to change the color of the object
    void ChangeColor()
    {
        // Get the renderer component of the object
        Renderer rend = GetComponent<Renderer>();

        // Pick a random Christmas color from the array
        Color newColor = christmasColors[Random.Range(0, christmasColors.Length)];

        // Apply the new color to the object
        rend.material.color = newColor;
    }
}

