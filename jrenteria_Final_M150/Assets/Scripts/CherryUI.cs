// CherryUI.cs
using UnityEngine;
using UnityEngine.UI;

public class CherryUI : MonoBehaviour
{
    public Image cherryImage;

    // Call this method to show the cherry UI
    public void ShowCherry()
    {
        cherryImage.enabled = true;
    }

    // Call this method to hide the cherry UI
    public void HideCherry()
    {
        cherryImage.enabled = false;
    }
}



