using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Good practice, though not strictly needed for Camera component

public class CustomTransparencySort : MonoBehaviour
{
    void Start()
    {
        Camera cam = GetComponent<Camera>();
        if (cam != null)
        {
            cam.transparencySortMode = TransparencySortMode.CustomAxis;
            cam.transparencySortAxis = new Vector3(0, 1, 0); // For top-down 2D sorting (Y-axis)

            // --- ADD THESE LINES FOR DEBUGGING ---
            Debug.Log("Camera Transparency Sort Mode set to: " + cam.transparencySortMode);
            Debug.Log("Camera Transparency Sort Axis set to: " + cam.transparencySortAxis);
            // --- END DEBUGGING LINES ---
        }
        else
        {
            Debug.LogError("No Camera component found on this GameObject!");
        }
    }
}