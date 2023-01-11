using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollidsionPlatformBehavior : MonoBehaviour
{
    public Material newMaterial;
    public PedestalBehavior pedestalBehavior;

    private void OnTriggerEnter(Collider other)
    {
        pedestalBehavior.ChangeColor(newMaterial);
    }
}
