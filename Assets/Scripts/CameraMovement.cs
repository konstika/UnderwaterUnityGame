using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject player;
    public float zoomSpeed = 10f;
    public Vector3 offset = new Vector3(-3.7f,6,-5f);
    public int camSpeed = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        this.transform.position = Vector3.Lerp(this.transform.position, player.transform.position + offset, camSpeed * Time.deltaTime);
        if (scroll != 0)
        {
            GetComponent<Camera>().orthographicSize -= scroll * zoomSpeed;
        }
    }
}
