using System;
using UnityEngine;

public class DroneMovement : MonoBehaviour
{
    public float speed = 0.1f;
    private Vector3 target;
    private bool isMoving = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0)) {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit)) {
                if (hit.collider.CompareTag("WaterPath")) { 
                    target = hit.point;
                    isMoving = true;
                    //print("target: "+target);
                }
            }
        }

        if (isMoving) { 
            transform.LookAt(target);
            transform.position = Vector3.MoveTowards(transform.position, target, speed*Time.deltaTime);
            if (Vector3.Distance(target, transform.position) < 0.01f) { 
                isMoving = false;
            }
        }
    }
}
