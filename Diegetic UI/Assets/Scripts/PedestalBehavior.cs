using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PedestalBehavior : MonoBehaviour
{
    private Material oldMaterai;
    private MeshRenderer[] renderers;

    // Start is called before the first frame update
    void Start()
    {
        renderers = GetComponentsInChildren<MeshRenderer>();
        oldMaterai = renderers[0].material;
    }

    public void ChangeColor(Material newMaterial)
    {
        foreach(MeshRenderer r in renderers)
        {
            r.material = newMaterial;
        }
    }
}
