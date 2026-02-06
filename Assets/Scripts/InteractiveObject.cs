using UnityEngine;
using System.Collections;

public class InteractiveObject : MonoBehaviour
{
    void Start()
    {
        
    }

    public void OutlineHighlight()
    {
        GetComponent<Renderer>().material.color = Color.yellow;
    }
    public void OutlineLowlight(Color material)
    {
        GetComponent<Renderer>().material.color = material;
    }

}
