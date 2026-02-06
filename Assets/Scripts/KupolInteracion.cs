using UnityEngine;

public class KupolInteracion : InteractiveObject
{
    private Color material;
    void OnEnable() 
    {
        material = this.GetComponent<Renderer>().material.color;
    }
    private void OnMouseEnter()
    {
        OutlineHighlight();
    }
    private void OnMouseExit()
    {
        OutlineLowlight(material);
    }
    // Update is called once per frame
    void Update()
    {
        //Debug.Log(material);
    }
}
