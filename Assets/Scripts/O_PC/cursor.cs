using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursor : MonoBehaviour
{
    // Define the boundaries of the cursor movement
    public float leftBoundary = -6.6f;
    public float rightBoundary = 6.6f;
    public float topBoundary = -3.8f;
    public float bottomBoundary = -4.0f;

    // Update is called once per frame
    void Update()
    {
        // Get the mouse position in screen space
        Vector3 mousePosition = Input.mousePosition;

        // Convert the mouse position to world space
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);

        // Set the z position to 0 to ensure the object stays in the 2D plane
        worldPosition.z = 0;

        // Clamp the position of the game object within the defined boundaries
        worldPosition.x = Mathf.Clamp(worldPosition.x, leftBoundary, rightBoundary);
        worldPosition.y = Mathf.Clamp(worldPosition.y, bottomBoundary, topBoundary);

        // Move the game object to the mouse position
        transform.position = worldPosition;
    }
}
