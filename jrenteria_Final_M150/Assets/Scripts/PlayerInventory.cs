using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour
{
    public int NumberOfSpheres { get; private set; }

    public UnityEvent<PlayerInventory> OnSphereCollected;

    public void SphereCollected()
    {
        NumberOfSpheres++;
        OnSphereCollected.Invoke(this);
    }


}
