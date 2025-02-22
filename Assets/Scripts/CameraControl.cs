using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public float moveSpeed = 5f; // Speed at which the camera moves
    public float zoomSpeed = 2f; // Speed at which the camera zooms in/out
    public float minZoom = 5f;   // Minimum zoom level
    public float maxZoom = 15f;  // Maximum zoom level

    private void Update()
    {
        // Handle camera movement (independent of animals)
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(horizontal, vertical, 0) * moveSpeed * Time.deltaTime;
        transform.Translate(move, Space.World);

        // Handle camera zoom (independent of animals)
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        Camera.main.orthographicSize = Mathf.Clamp(Camera.main.orthographicSize - scroll * zoomSpeed, minZoom, maxZoom);
    }
}