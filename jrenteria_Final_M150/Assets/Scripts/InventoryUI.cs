using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    private TextMeshProUGUI sphereText;

    // Start is called before the first frame update
    void Start()
    {
        sphereText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateSphereText(PlayerInventory playerInventory)
    {
       
        {
            sphereText.text = playerInventory.NumberOfSpheres.ToString();
        }
        
    }
}



